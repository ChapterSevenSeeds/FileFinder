using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace FileFinder
{
    public partial class FormFolderSelector : Form
    {
        SessionInfo session;

        CommonOpenFileDialog dialog = new CommonOpenFileDialog() { IsFolderPicker = true };

        string source;
        string destination;
        public FormFolderSelector(SessionInfo session)
        {
            this.session = session;

            InitializeComponent();
        }

        private void BtnSourceBrowse_Click(object sender, EventArgs e)
        {
            dialog.ShowDialog();
            try
            {
                source = dialog.FileName;
                TextSourcePath.Text = source;
            }
            catch (Exception) { }
        }

        private void BtnBrowseDestination_Click(object sender, EventArgs e)
        {
            dialog.ShowDialog();
            try
            {
                destination = dialog.FileName;
                TextDestinationPath.Text = destination;
            }
            catch (Exception) { }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            session.Source = new DirectoryInfo(source);
            session.Destination = new DirectoryInfo(destination);
            Close();
        }
    }
}
