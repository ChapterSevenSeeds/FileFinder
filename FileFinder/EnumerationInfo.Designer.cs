
namespace FileFinder
{
    partial class EnumerationInfo
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
            this.groupSourceInfo = new System.Windows.Forms.GroupBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblSourceStatus = new System.Windows.Forms.Label();
            this.lblSourceBytes = new System.Windows.Forms.Label();
            this.lblSourceFilesCount = new System.Windows.Forms.Label();
            this.lblSourceFolderCount = new System.Windows.Forms.Label();
            this.lblMainStatus = new System.Windows.Forms.Label();
            this.groupDestinationInfo = new System.Windows.Forms.GroupBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblDestinationStatus = new System.Windows.Forms.Label();
            this.lblDestinationTotalBytes = new System.Windows.Forms.Label();
            this.lblDestinationFilesCount = new System.Windows.Forms.Label();
            this.lblDestinationFoldersCount = new System.Windows.Forms.Label();
            this.groupSourceInfo.SuspendLayout();
            this.groupDestinationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupSourceInfo
            // 
            this.groupSourceInfo.Controls.Add(this.lblSource);
            this.groupSourceInfo.Controls.Add(this.lblSourceStatus);
            this.groupSourceInfo.Controls.Add(this.lblSourceBytes);
            this.groupSourceInfo.Controls.Add(this.lblSourceFilesCount);
            this.groupSourceInfo.Controls.Add(this.lblSourceFolderCount);
            this.groupSourceInfo.Location = new System.Drawing.Point(13, 13);
            this.groupSourceInfo.Name = "groupSourceInfo";
            this.groupSourceInfo.Size = new System.Drawing.Size(781, 291);
            this.groupSourceInfo.TabIndex = 0;
            this.groupSourceInfo.TabStop = false;
            this.groupSourceInfo.Text = "Source Information";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(6, 38);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(63, 29);
            this.lblSource.TabIndex = 6;
            this.lblSource.Text = "asdf";
            // 
            // lblSourceStatus
            // 
            this.lblSourceStatus.AutoSize = true;
            this.lblSourceStatus.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceStatus.Location = new System.Drawing.Point(6, 259);
            this.lblSourceStatus.Name = "lblSourceStatus";
            this.lblSourceStatus.Size = new System.Drawing.Size(163, 26);
            this.lblSourceStatus.TabIndex = 3;
            this.lblSourceStatus.Text = "Enumerating...";
            // 
            // lblSourceBytes
            // 
            this.lblSourceBytes.AutoSize = true;
            this.lblSourceBytes.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceBytes.Location = new System.Drawing.Point(6, 163);
            this.lblSourceBytes.Name = "lblSourceBytes";
            this.lblSourceBytes.Size = new System.Drawing.Size(157, 29);
            this.lblSourceBytes.TabIndex = 2;
            this.lblSourceBytes.Text = "Total Bytes:";
            // 
            // lblSourceFilesCount
            // 
            this.lblSourceFilesCount.AutoSize = true;
            this.lblSourceFilesCount.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceFilesCount.Location = new System.Drawing.Point(6, 121);
            this.lblSourceFilesCount.Name = "lblSourceFilesCount";
            this.lblSourceFilesCount.Size = new System.Drawing.Size(77, 29);
            this.lblSourceFilesCount.TabIndex = 1;
            this.lblSourceFilesCount.Text = "Files:";
            // 
            // lblSourceFolderCount
            // 
            this.lblSourceFolderCount.AutoSize = true;
            this.lblSourceFolderCount.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceFolderCount.Location = new System.Drawing.Point(6, 78);
            this.lblSourceFolderCount.Name = "lblSourceFolderCount";
            this.lblSourceFolderCount.Size = new System.Drawing.Size(111, 29);
            this.lblSourceFolderCount.TabIndex = 0;
            this.lblSourceFolderCount.Text = "Folders:";
            // 
            // lblMainStatus
            // 
            this.lblMainStatus.AutoSize = true;
            this.lblMainStatus.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainStatus.Location = new System.Drawing.Point(6, 320);
            this.lblMainStatus.Name = "lblMainStatus";
            this.lblMainStatus.Size = new System.Drawing.Size(233, 40);
            this.lblMainStatus.TabIndex = 2;
            this.lblMainStatus.Text = "Please wait...";
            // 
            // groupDestinationInfo
            // 
            this.groupDestinationInfo.Controls.Add(this.lblDestination);
            this.groupDestinationInfo.Controls.Add(this.lblDestinationStatus);
            this.groupDestinationInfo.Controls.Add(this.lblDestinationTotalBytes);
            this.groupDestinationInfo.Controls.Add(this.lblDestinationFilesCount);
            this.groupDestinationInfo.Controls.Add(this.lblDestinationFoldersCount);
            this.groupDestinationInfo.Location = new System.Drawing.Point(800, 13);
            this.groupDestinationInfo.Name = "groupDestinationInfo";
            this.groupDestinationInfo.Size = new System.Drawing.Size(781, 291);
            this.groupDestinationInfo.TabIndex = 3;
            this.groupDestinationInfo.TabStop = false;
            this.groupDestinationInfo.Text = "Destination Information";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(6, 38);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(63, 29);
            this.lblDestination.TabIndex = 5;
            this.lblDestination.Text = "asdf";
            // 
            // lblDestinationStatus
            // 
            this.lblDestinationStatus.AutoSize = true;
            this.lblDestinationStatus.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationStatus.Location = new System.Drawing.Point(6, 259);
            this.lblDestinationStatus.Name = "lblDestinationStatus";
            this.lblDestinationStatus.Size = new System.Drawing.Size(163, 26);
            this.lblDestinationStatus.TabIndex = 4;
            this.lblDestinationStatus.Text = "Enumerating...";
            // 
            // lblDestinationTotalBytes
            // 
            this.lblDestinationTotalBytes.AutoSize = true;
            this.lblDestinationTotalBytes.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationTotalBytes.Location = new System.Drawing.Point(6, 163);
            this.lblDestinationTotalBytes.Name = "lblDestinationTotalBytes";
            this.lblDestinationTotalBytes.Size = new System.Drawing.Size(157, 29);
            this.lblDestinationTotalBytes.TabIndex = 2;
            this.lblDestinationTotalBytes.Text = "Total Bytes:";
            // 
            // lblDestinationFilesCount
            // 
            this.lblDestinationFilesCount.AutoSize = true;
            this.lblDestinationFilesCount.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationFilesCount.Location = new System.Drawing.Point(6, 121);
            this.lblDestinationFilesCount.Name = "lblDestinationFilesCount";
            this.lblDestinationFilesCount.Size = new System.Drawing.Size(77, 29);
            this.lblDestinationFilesCount.TabIndex = 1;
            this.lblDestinationFilesCount.Text = "Files:";
            // 
            // lblDestinationFoldersCount
            // 
            this.lblDestinationFoldersCount.AutoSize = true;
            this.lblDestinationFoldersCount.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationFoldersCount.Location = new System.Drawing.Point(6, 78);
            this.lblDestinationFoldersCount.Name = "lblDestinationFoldersCount";
            this.lblDestinationFoldersCount.Size = new System.Drawing.Size(111, 29);
            this.lblDestinationFoldersCount.TabIndex = 0;
            this.lblDestinationFoldersCount.Text = "Folders:";
            // 
            // EnumerationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 388);
            this.Controls.Add(this.groupDestinationInfo);
            this.Controls.Add(this.lblMainStatus);
            this.Controls.Add(this.groupSourceInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EnumerationInfo";
            this.Text = "Enumerating Files...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EnumerationInfo_FormClosing);
            this.groupSourceInfo.ResumeLayout(false);
            this.groupSourceInfo.PerformLayout();
            this.groupDestinationInfo.ResumeLayout(false);
            this.groupDestinationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSourceInfo;
        private System.Windows.Forms.Label lblSourceFolderCount;
        private System.Windows.Forms.Label lblSourceFilesCount;
        private System.Windows.Forms.Label lblSourceBytes;
        private System.Windows.Forms.Label lblMainStatus;
        private System.Windows.Forms.GroupBox groupDestinationInfo;
        private System.Windows.Forms.Label lblDestinationTotalBytes;
        private System.Windows.Forms.Label lblDestinationFilesCount;
        private System.Windows.Forms.Label lblDestinationFoldersCount;
        private System.Windows.Forms.Label lblSourceStatus;
        private System.Windows.Forms.Label lblDestinationStatus;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDestination;
    }
}