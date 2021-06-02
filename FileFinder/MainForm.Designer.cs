
namespace FileFinder
{
    partial class FormFileFinder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridResults = new System.Windows.Forms.DataGridView();
            this.columnResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSourceFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDestinationFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleSelectRightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openSourceFileFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDestinationFileFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSourceFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDestinationFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSourceFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDestinationFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiSelectRightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSourceFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDestinationFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allIdenticalItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.singleSelectRightClickMenu.SuspendLayout();
            this.multiSelectRightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridResults
            // 
            this.gridResults.AllowUserToAddRows = false;
            this.gridResults.AllowUserToDeleteRows = false;
            this.gridResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnResult,
            this.columnSourceFile,
            this.columnDestinationFile});
            this.gridResults.Location = new System.Drawing.Point(13, 36);
            this.gridResults.Name = "gridResults";
            this.gridResults.RowHeadersWidth = 62;
            this.gridResults.RowTemplate.Height = 28;
            this.gridResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridResults.Size = new System.Drawing.Size(2389, 1314);
            this.gridResults.TabIndex = 0;
            this.gridResults.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridResults_ColumnHeaderMouseClick);
            this.gridResults.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridResults_MouseUp);
            // 
            // columnResult
            // 
            this.columnResult.DataPropertyName = "Status";
            this.columnResult.HeaderText = "Result";
            this.columnResult.MinimumWidth = 8;
            this.columnResult.Name = "columnResult";
            this.columnResult.ReadOnly = true;
            this.columnResult.Width = 150;
            // 
            // columnSourceFile
            // 
            this.columnSourceFile.DataPropertyName = "EntryName";
            this.columnSourceFile.HeaderText = "Source File";
            this.columnSourceFile.MinimumWidth = 8;
            this.columnSourceFile.Name = "columnSourceFile";
            this.columnSourceFile.ReadOnly = true;
            this.columnSourceFile.Width = 150;
            // 
            // columnDestinationFile
            // 
            this.columnDestinationFile.DataPropertyName = "ConjugateFile";
            this.columnDestinationFile.HeaderText = "Destination File";
            this.columnDestinationFile.MinimumWidth = 8;
            this.columnDestinationFile.Name = "columnDestinationFile";
            this.columnDestinationFile.ReadOnly = true;
            this.columnDestinationFile.Width = 150;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(13, 1356);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(2389, 23);
            this.progressBar.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1386);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(2414, 32);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(179, 25);
            this.statusLabel.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.selectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2414, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(144, 34);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // singleSelectRightClickMenu
            // 
            this.singleSelectRightClickMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.singleSelectRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSourceFileFolderToolStripMenuItem,
            this.openDestinationFileFolderToolStripMenuItem,
            this.openSourceFileToolStripMenuItem,
            this.openDestinationFileToolStripMenuItem,
            this.deleteSourceFileToolStripMenuItem,
            this.deleteDestinationFileToolStripMenuItem});
            this.singleSelectRightClickMenu.Name = "singleSelectRightClickMenu";
            this.singleSelectRightClickMenu.Size = new System.Drawing.Size(310, 196);
            // 
            // openSourceFileFolderToolStripMenuItem
            // 
            this.openSourceFileFolderToolStripMenuItem.Name = "openSourceFileFolderToolStripMenuItem";
            this.openSourceFileFolderToolStripMenuItem.Size = new System.Drawing.Size(309, 32);
            this.openSourceFileFolderToolStripMenuItem.Text = "Open Source File Folder";
            this.openSourceFileFolderToolStripMenuItem.Click += new System.EventHandler(this.openSourceFileFolderToolStripMenuItem_Click);
            // 
            // openDestinationFileFolderToolStripMenuItem
            // 
            this.openDestinationFileFolderToolStripMenuItem.Name = "openDestinationFileFolderToolStripMenuItem";
            this.openDestinationFileFolderToolStripMenuItem.Size = new System.Drawing.Size(309, 32);
            this.openDestinationFileFolderToolStripMenuItem.Text = "Open Destination File Folder";
            this.openDestinationFileFolderToolStripMenuItem.Click += new System.EventHandler(this.openDestinationFileFolderToolStripMenuItem_Click);
            // 
            // openSourceFileToolStripMenuItem
            // 
            this.openSourceFileToolStripMenuItem.Name = "openSourceFileToolStripMenuItem";
            this.openSourceFileToolStripMenuItem.Size = new System.Drawing.Size(309, 32);
            this.openSourceFileToolStripMenuItem.Text = "Open Source File";
            this.openSourceFileToolStripMenuItem.Click += new System.EventHandler(this.openSourceFileToolStripMenuItem_Click);
            // 
            // openDestinationFileToolStripMenuItem
            // 
            this.openDestinationFileToolStripMenuItem.Name = "openDestinationFileToolStripMenuItem";
            this.openDestinationFileToolStripMenuItem.Size = new System.Drawing.Size(309, 32);
            this.openDestinationFileToolStripMenuItem.Text = "Open Destination File";
            this.openDestinationFileToolStripMenuItem.Click += new System.EventHandler(this.openDestinationFileToolStripMenuItem_Click);
            // 
            // deleteSourceFileToolStripMenuItem
            // 
            this.deleteSourceFileToolStripMenuItem.Name = "deleteSourceFileToolStripMenuItem";
            this.deleteSourceFileToolStripMenuItem.Size = new System.Drawing.Size(309, 32);
            this.deleteSourceFileToolStripMenuItem.Text = "Delete Source File";
            this.deleteSourceFileToolStripMenuItem.Click += new System.EventHandler(this.deleteSourceFileToolStripMenuItem_Click);
            // 
            // deleteDestinationFileToolStripMenuItem
            // 
            this.deleteDestinationFileToolStripMenuItem.Name = "deleteDestinationFileToolStripMenuItem";
            this.deleteDestinationFileToolStripMenuItem.Size = new System.Drawing.Size(309, 32);
            this.deleteDestinationFileToolStripMenuItem.Text = "Delete Destination File";
            this.deleteDestinationFileToolStripMenuItem.Click += new System.EventHandler(this.deleteDestinationFileToolStripMenuItem_Click);
            // 
            // multiSelectRightClickMenu
            // 
            this.multiSelectRightClickMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.multiSelectRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSourceFilesToolStripMenuItem,
            this.deleteDestinationFilesToolStripMenuItem});
            this.multiSelectRightClickMenu.Name = "contextMenuStrip1";
            this.multiSelectRightClickMenu.Size = new System.Drawing.Size(269, 68);
            // 
            // deleteSourceFilesToolStripMenuItem
            // 
            this.deleteSourceFilesToolStripMenuItem.Name = "deleteSourceFilesToolStripMenuItem";
            this.deleteSourceFilesToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.deleteSourceFilesToolStripMenuItem.Text = "Delete Source Files";
            this.deleteSourceFilesToolStripMenuItem.Click += new System.EventHandler(this.deleteSourceFilesToolStripMenuItem_Click);
            // 
            // deleteDestinationFilesToolStripMenuItem
            // 
            this.deleteDestinationFilesToolStripMenuItem.Name = "deleteDestinationFilesToolStripMenuItem";
            this.deleteDestinationFilesToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.deleteDestinationFilesToolStripMenuItem.Text = "Delete Destination Files";
            this.deleteDestinationFilesToolStripMenuItem.Click += new System.EventHandler(this.deleteDestinationFilesToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allIdenticalItemsToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // allIdenticalItemsToolStripMenuItem
            // 
            this.allIdenticalItemsToolStripMenuItem.Name = "allIdenticalItemsToolStripMenuItem";
            this.allIdenticalItemsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.allIdenticalItemsToolStripMenuItem.Text = "All Identical Items";
            this.allIdenticalItemsToolStripMenuItem.Click += new System.EventHandler(this.allIdenticalItemsToolStripMenuItem_Click);
            // 
            // FormFileFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2414, 1418);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.gridResults);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormFileFinder";
            this.Text = "File Finder";
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.singleSelectRightClickMenu.ResumeLayout(false);
            this.multiSelectRightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridResults;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSourceFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDestinationFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip singleSelectRightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem openSourceFileFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDestinationFileFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSourceFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDestinationFileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip multiSelectRightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteSourceFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDestinationFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSourceFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDestinationFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allIdenticalItemsToolStripMenuItem;
    }
}

