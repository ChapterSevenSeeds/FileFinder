using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Timers;
using System.Collections.Concurrent;

namespace FileFinder
{
    public partial class EnumerationInfo : Form
    {
        SessionInfo session;
        System.Timers.Timer updateUITimer;

        int sourceDirectoryCount = 1, sourceFileCount = 0, destinationDirectoryCount = 1, destinationFileCount = 0;
        long sourceByteCount = 0, destinationByteCount = 0;

        bool sourceDone = false, destinationDone = false;

        public EnumerationInfo(SessionInfo session)
        {
            InitializeComponent();

            lblSource.Text = session.Source.FullName;
            lblDestination.Text = session.Destination.FullName;

            Task.Run(() => Enumerate(session.Source, session.SourceFiles, ref sourceDirectoryCount, ref sourceFileCount, ref sourceByteCount, lblSourceStatus, ref sourceDone, true));
            Task.Run(() => Enumerate(session.Destination, session.DestinationFiles, ref destinationDirectoryCount, ref destinationFileCount, ref destinationByteCount, lblDestinationStatus, ref destinationDone, false));

            this.session = session;
            updateUITimer = new System.Timers.Timer(50);
            updateUITimer.Elapsed += UpdateUI;
            updateUITimer.AutoReset = true;
            updateUITimer.Enabled = true;
        }

        private void Enumerate(DirectoryInfo root, ConcurrentBag<FileEntry> fileContainer, ref int directoryCount, ref int fileCount, ref long byteCount, Label statusLabel, ref bool isDone, bool isSource)
        {
            Queue<DirectoryInfo> destinationDirectories = new Queue<DirectoryInfo>();
            destinationDirectories.Enqueue(root);

            while (destinationDirectories.Count > 0)
            {
                DirectoryInfo currentDirectory = destinationDirectories.Dequeue();
                DirectoryInfo[] currentDirectories;
                try
                {
                    currentDirectories = currentDirectory.GetDirectories();
                }
                catch (Exception)
                {
                    continue;
                }
                directoryCount += currentDirectories.Length;
                foreach (var directory in currentDirectories)
                {
                    destinationDirectories.Enqueue(directory);
                }

                FileInfo[] currentFiles = currentDirectory.GetFiles();
                fileCount += currentFiles.Length;
                foreach (var file in currentFiles)
                {
                    if (file.Length > 0 && !file.FullName.ToLower().EndsWith(".db"))
                    {
                        fileContainer.Add(new FileEntry() { Entry = file });
                        byteCount += file.Length;
                    }
                }
            }

            isDone = true;

            try
            {
                Invoke(new Action(() => { statusLabel.Text = "Done!"; CheckDone(); }));
            } catch (Exception)
            {

            }

            if (isSource)
                session.SourceByteCount = byteCount;
            else
                session.DestinationByteCount = byteCount;
        }

        private void CheckDone()
        {
            if(sourceDone && destinationDone)
            {
                lblMainStatus.Text = "Done!";
                updateUITimer.Stop();
                Close();
            }
        }

        private void UpdateUI(object source, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                lblSourceFolderCount.Text = "Folders: " + String.Format("{0:n0}", sourceDirectoryCount);
                lblSourceFilesCount.Text = "Files: " + String.Format("{0:n0}", sourceFileCount);
                lblSourceBytes.Text = "Total Bytes: " + String.Format("{0:n0}", sourceByteCount);

                lblDestinationFoldersCount.Text = "Folders: " + String.Format("{0:n0}", destinationDirectoryCount);
                lblDestinationFilesCount.Text = "Files: " + String.Format("{0:n0}", destinationFileCount);
                lblDestinationTotalBytes.Text = "Total Bytes: " + String.Format("{0:n0}", destinationByteCount);
            }));
        }
    }
}
