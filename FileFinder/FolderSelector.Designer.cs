
namespace FileFinder
{
    partial class FormFolderSelector
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
            this.TextSourcePath = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.BtnSourceBrowse = new System.Windows.Forms.Button();
            this.BtnBrowseDestination = new System.Windows.Forms.Button();
            this.lblDestination = new System.Windows.Forms.Label();
            this.TextDestinationPath = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextSourcePath
            // 
            this.TextSourcePath.Location = new System.Drawing.Point(18, 47);
            this.TextSourcePath.Name = "TextSourcePath";
            this.TextSourcePath.Size = new System.Drawing.Size(1491, 26);
            this.TextSourcePath.TabIndex = 0;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(12, 9);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(126, 35);
            this.lblSource.TabIndex = 1;
            this.lblSource.Text = "Source:";
            // 
            // BtnSourceBrowse
            // 
            this.BtnSourceBrowse.Location = new System.Drawing.Point(1516, 47);
            this.BtnSourceBrowse.Name = "BtnSourceBrowse";
            this.BtnSourceBrowse.Size = new System.Drawing.Size(75, 26);
            this.BtnSourceBrowse.TabIndex = 2;
            this.BtnSourceBrowse.Text = "Browse";
            this.BtnSourceBrowse.UseVisualStyleBackColor = true;
            this.BtnSourceBrowse.Click += new System.EventHandler(this.BtnSourceBrowse_Click);
            // 
            // BtnBrowseDestination
            // 
            this.BtnBrowseDestination.Location = new System.Drawing.Point(1516, 193);
            this.BtnBrowseDestination.Name = "BtnBrowseDestination";
            this.BtnBrowseDestination.Size = new System.Drawing.Size(75, 26);
            this.BtnBrowseDestination.TabIndex = 5;
            this.BtnBrowseDestination.Text = "Browse";
            this.BtnBrowseDestination.UseVisualStyleBackColor = true;
            this.BtnBrowseDestination.Click += new System.EventHandler(this.BtnBrowseDestination_Click);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(12, 155);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(192, 35);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "Destination:";
            // 
            // TextDestinationPath
            // 
            this.TextDestinationPath.Location = new System.Drawing.Point(18, 193);
            this.TextDestinationPath.Name = "TextDestinationPath";
            this.TextDestinationPath.Size = new System.Drawing.Size(1491, 26);
            this.TextDestinationPath.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1562, 317);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 32);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // FormFolderSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 361);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.BtnBrowseDestination);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.TextDestinationPath);
            this.Controls.Add(this.BtnSourceBrowse);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.TextSourcePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormFolderSelector";
            this.Text = "Folder Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextSourcePath;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Button BtnSourceBrowse;
        private System.Windows.Forms.Button BtnBrowseDestination;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox TextDestinationPath;
        private System.Windows.Forms.Button btnStart;
    }
}