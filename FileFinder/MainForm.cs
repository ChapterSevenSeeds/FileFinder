using System;
using System.Collections.Concurrent;
using Microsoft.VisualBasic.FileIO;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Timers;
using System.Diagnostics;
using System.Collections.Generic;

namespace FileFinder
{
    public partial class FormFileFinder : Form
    {
        readonly SessionInfo session;
        BindingList<FileEntry> dataBind;
        string status = "";
        string log = "";
        int progressBarCompletion = 0;
        readonly System.Timers.Timer uiUpdater;
        bool sortStatusFlag = false, sortSourceFlag = false, sortDestFlag = false;
        public FormFileFinder()
        {
            InitializeComponent();

            gridResults.AutoGenerateColumns = false;
            gridResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            session = new SessionInfo();

            FormFolderSelector selector = new FormFolderSelector(session);
            if (selector.ShowDialog() == DialogResult.Cancel)
                Process.GetCurrentProcess().Kill();

            EnumerationInfo enumerationInfo = new EnumerationInfo(session);
            if (enumerationInfo.ShowDialog() == DialogResult.Cancel)
                Process.GetCurrentProcess().Kill();

            progressBar.Maximum = session.SourceFiles.Count;

            Task.Run(DoWork);

            uiUpdater = new System.Timers.Timer(200) { AutoReset = true, Enabled = true };
            uiUpdater.Elapsed += UpdateUI;
        }

        private void UpdateUI(object source, ElapsedEventArgs e)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    progressBar.Value = progressBarCompletion;
                    statusLabel.Text = status;
                }));
            }
            catch (Exception)
            {
                WriteStatus("Unable to update UI. Skipping invocation...");
            }
        }

        public void DoWork()
        {
            WriteStatus("Sifting through files...");

            WriteToLog($"Source file count: {string.Format("{0:n0}", session.SourceFiles.Count)}");
            WriteToLog($"Total source bytes: {string.Format("{0:n0}", session.SourceByteCount)}");
            WriteToLog("");
            WriteToLog($"Destination file count: {string.Format("{0:n0}", session.DestinationFiles.Count)}");
            WriteToLog($"Total Destination bytes: {string.Format("{0:n0}", session.DestinationByteCount)}");
            WriteToLog("");
            WriteToLog("Beginning work...");

            Parallel.ForEach(session.SourceFiles.Keys, sourceLength =>
            {
                if (!session.DestinationFiles.TryGetValue(sourceLength, out var candidates))
                {
                    if (!session.DisplayNoMatches)
                        session.SourceFiles.TryRemove(sourceLength, out _);
                    return;
                }

                foreach (var file in session.SourceFiles[sourceLength])
                {
                    WriteToLog($"Looking for {file.EntryName}. Size: {string.Format("{0:n0}", file.Entry.Length)}");

                    if (session.DestinationFiles.ContainsKey(file.Entry.Length))
                    {
                        ComputeHash(file);
                        if (file.Hash == "cant")
                        {
                            candidates.TryPeek(out var result);
                            file.Conjugate = result;
                            continue;
                        }

                        foreach (var candidateFile in candidates)
                        {
                            lock(candidateFile)
                            {
                                if (candidateFile.Hash == null)
                                    ComputeHash(candidateFile);

                                if (file.Hash == candidateFile.Hash)
                                {
                                    file.Conjugate = candidateFile;
                                    return;
                                }
                            }
                        }
                    }
                }

                ++progressBarCompletion;
            });

            uiUpdater.Stop();
            Invoke(new Action(() => progressBar.Value = progressBar.Maximum));

            if (!session.DisplayNoMatches)
            {
                WriteToLog("\nFiltering results.");

                Parallel.ForEach(session.SourceFiles.Keys, sourceLength =>
                {
                    session.SourceFiles[sourceLength] = new ConcurrentBag<FileEntry>(session.SourceFiles[sourceLength].Where(x => x.Status != "No Match"));
                });
            }


            WriteToLog("\nDone working.");
            
            WriteStatus("Loading results into BindingList...", false);

            Task.Run(() =>
            {
                dataBind = new BindingList<FileEntry>();

                foreach (var pair in session.SourceFiles)
                {
                    foreach (var file in pair.Value)
                        dataBind.Add(file);
                }

                WriteStatus("Binding results to DataGridView. The UI will be locked during this time...", false);
                Invoke(new Action(() => gridResults.DataSource = dataBind));
                WriteStatus("Done...", false);
            });

            WriteStatus("Creating log...", false);
            Task.Run(CreateLog);
            WriteStatus("Done...", false);
        }

        public void WriteToLog(string message)
        {
            lock(log)
            {
                log += message + "\r\n";
            }
        }
        public void CreateLog()
        {
            File.WriteAllText($@"{Path.GetTempPath()}/filefinderlog.txt", log);
        }

        public void WriteStatus(string message, bool inParallelExecution = true)
        {
            if (inParallelExecution)
                status = message;
            else
                Invoke(new Action(() => statusLabel.Text = message));
        }

        public void ComputeHash(FileEntry file)
        {
            using (SHA256 mySHA256 = SHA256.Create())
            {
                try
                {
                    FileStream fileStream = new FileStream(file.EntryName, FileMode.Open, FileAccess.Read)
                    {
                        Position = 0
                    };
                    file.Hash = string.Join("", mySHA256.ComputeHash(fileStream));
                    fileStream.Close();
                }
                catch (Exception e)
                {
                    file.Hash = "cant";
                    WriteStatus("Unable to compute hash of " + file.Entry.FullName);
                    log += "Unable to compute hash of " + file.Entry.FullName + ". " + e.Message;
                }
            }
        }

        #region Handlers
        private void GridResults_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            WriteStatus("Sorting...", false);
            Task.Run(() => Sort(e.ColumnIndex));
        }

        private void OpenSourceFileFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(((FileEntry)gridResults.SelectedRows[0].DataBoundItem).Entry.DirectoryName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open containing folder of source file. " + ex.Message);
            }
        }

        private void OpenDestinationFileFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(((FileEntry)gridResults.SelectedRows[0].DataBoundItem).Conjugate.Entry.DirectoryName);
            }
            catch (Exception)
            {

            }
        }

        private void OpenSourceFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(((FileEntry)gridResults.SelectedRows[0].DataBoundItem).Entry.FullName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open source file. " + ex.Message);
            }
        }

        private void OpenDestinationFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(((FileEntry)gridResults.SelectedRows[0].DataBoundItem).Conjugate.Entry.FullName);
            }
            catch (Exception)
            {

            }
        }

        private void DeleteSourceFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileEntry file = (FileEntry)gridResults.SelectedRows[0].DataBoundItem;
                FileSystem.DeleteFile(file.EntryName, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                dataBind.Remove(file);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to send source file to the Recycle Bin. " + ex.Message);
            }
        }

        private void DeleteDestinationFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileEntry file = (FileEntry)gridResults.SelectedRows[0].DataBoundItem;
            try
            {

                if (file.Conjugate != null)
                {
                    FileSystem.DeleteFile(file.ConjugateFile, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                    file.Conjugate = null;
                    gridResults.Refresh();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to send destination file to the Recycle Bin. " + ex.Message);
            }
        }

        private void DeleteSourceFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteStatus("Deleting selected source files...", false);

            List<FileEntry> toDelete = new List<FileEntry>();
            foreach (DataGridViewRow row in gridResults.SelectedRows)
                toDelete.Add((FileEntry)row.DataBoundItem);

            gridResults.DataSource = null;

            Parallel.ForEach(toDelete, file =>
            {
                FileSystem.DeleteFile(file.EntryName, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
            });

            foreach(FileEntry file in toDelete)
                dataBind.Remove(file);

            gridResults.DataSource = dataBind;


            WriteStatus("Done.", false);
        }

        private void DeleteDestinationFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteStatus("Deleting selected destination files...", false);

            List<FileEntry> toDelete = new List<FileEntry>();
            foreach (DataGridViewRow row in gridResults.SelectedRows)
                toDelete.Add((FileEntry)row.DataBoundItem);

            gridResults.DataSource = null;

            Parallel.ForEach(toDelete, file =>
            {
                if (file.Conjugate != null)
                {
                    FileSystem.DeleteFile(file.ConjugateFile, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                    file.Conjugate = null;
                }
            });

            gridResults.DataSource = dataBind;

            WriteStatus("Done.", false);
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AllIdenticalItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteStatus("Selecting all identical files...", false);

            foreach(DataGridViewRow row in gridResults.Rows)
            {
                if (((FileEntry)row.DataBoundItem).Status == "Identical")
                    row.Selected = true;
                else
                    row.Selected = false;
            }

            WriteStatus("Done.", false);
        }

        private void GridResults_SelectionChanged(object sender, EventArgs e)
        {
            if (gridResults.SelectedRows.Count > 1)
                gridResults.ContextMenuStrip = multiSelectRightClickMenu;
            else if (gridResults.SelectedRows.Count == 1)
                gridResults.ContextMenuStrip = singleSelectRightClickMenu;
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FileFinder.\nServes to confirm if all source files in a directory exist in a destination directory.\nWritten by Tyson Jones.", "About");
        }

        private void LogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start($@"{Path.GetTempPath()}/filefinderlog.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open log. " + ex.Message);
            }
        }

        #endregion

        private void Sort(int columnClicked)
        {
            switch (gridResults.Columns[columnClicked].DataPropertyName)
            {
                case "Status":
                    if (sortStatusFlag)
                        dataBind = new BindingList<FileEntry>(dataBind.OrderBy(x => x.Status).ToList());
                    else
                        dataBind = new BindingList<FileEntry>(dataBind.OrderByDescending(x => x.Status).ToList());

                    sortStatusFlag = !sortStatusFlag;

                    break;
                case "ConjugateFile":
                    if (sortDestFlag)
                        dataBind = new BindingList<FileEntry>(dataBind.OrderBy(x => x.ConjugateFile).ToList());
                    else
                        dataBind = new BindingList<FileEntry>(dataBind.OrderByDescending(x => x.ConjugateFile).ToList());

                    sortDestFlag = !sortDestFlag;
                    break;
                case "EntryName":
                    if (sortSourceFlag)
                        dataBind = new BindingList<FileEntry>(dataBind.OrderBy(x => x.EntryName).ToList());
                    else
                        dataBind = new BindingList<FileEntry>(dataBind.OrderByDescending(x => x.EntryName).ToList());

                    sortSourceFlag = !sortSourceFlag;
                    break;
            }

            WriteStatus("Re-attaching binding list. The UI will most likely lock up during this step...", false);

            Invoke(new Action(() =>
            {
                gridResults.DataSource = null;
                gridResults.DataSource = dataBind;
            }));

            WriteStatus("Done.", false);
        }

    }
    public class SessionInfo
    {
        public DirectoryInfo Source { get; set; }
        public DirectoryInfo Destination { get; set; }

        public long SourceByteCount { get; set; }
        public long DestinationByteCount { get; set; }

        public ConcurrentDictionary<long, ConcurrentBag<FileEntry>> SourceFiles { get; set; } = new ConcurrentDictionary<long, ConcurrentBag<FileEntry>>();
        public ConcurrentDictionary<long, ConcurrentBag<FileEntry>> DestinationFiles { get; set; } = new ConcurrentDictionary<long, ConcurrentBag<FileEntry>>();

        public bool DisplayNoMatches { get; set; }
    }

    public class FileEntry
    {
        public FileInfo Entry { get; set; }
        public FileEntry Conjugate { get; set; }
        public string Hash { get; set; }

        public string Status 
        { 
            get
            {
                if (Conjugate == null)
                    return "No Match";
                if (Hash == "cant" || Conjugate.Hash == "cant")
                    return "Indeterminate";
                if (Hash == Conjugate.Hash)
                    return "Identical";

                return "";
            } 
        }

        public string ConjugateFile
        {
            get
            {
                if (Conjugate != null)
                    return Conjugate.Entry.FullName;
                else
                    return "";
            }
        }

        public string EntryName
        {
            get
            {
                return Entry.FullName;
            }
        }
    }
}
