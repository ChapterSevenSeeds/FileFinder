
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
            this.LblSource = new System.Windows.Forms.Label();
            this.BtnSourceBrowse = new System.Windows.Forms.Button();
            this.BtnBrowseDestination = new System.Windows.Forms.Button();
            this.LblDestination = new System.Windows.Forms.Label();
            this.TextDestinationPath = new System.Windows.Forms.TextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.CheckboxDisplayNoMatches = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TextSourcePath
            // 
            this.TextSourcePath.Location = new System.Drawing.Point(18, 48);
            this.TextSourcePath.Name = "TextSourcePath";
            this.TextSourcePath.Size = new System.Drawing.Size(1490, 26);
            this.TextSourcePath.TabIndex = 0;
            // 
            // LblSource
            // 
            this.LblSource.AutoSize = true;
            this.LblSource.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSource.Location = new System.Drawing.Point(12, 9);
            this.LblSource.Name = "LblSource";
            this.LblSource.Size = new System.Drawing.Size(126, 35);
            this.LblSource.TabIndex = 1;
            this.LblSource.Text = "Source:";
            // 
            // BtnSourceBrowse
            // 
            this.BtnSourceBrowse.Location = new System.Drawing.Point(1516, 48);
            this.BtnSourceBrowse.Name = "BtnSourceBrowse";
            this.BtnSourceBrowse.Size = new System.Drawing.Size(75, 26);
            this.BtnSourceBrowse.TabIndex = 2;
            this.BtnSourceBrowse.Text = "Browse";
            this.BtnSourceBrowse.UseVisualStyleBackColor = true;
            this.BtnSourceBrowse.Click += new System.EventHandler(this.BtnSourceBrowse_Click);
            // 
            // BtnBrowseDestination
            // 
            this.BtnBrowseDestination.Location = new System.Drawing.Point(1516, 192);
            this.BtnBrowseDestination.Name = "BtnBrowseDestination";
            this.BtnBrowseDestination.Size = new System.Drawing.Size(75, 26);
            this.BtnBrowseDestination.TabIndex = 5;
            this.BtnBrowseDestination.Text = "Browse";
            this.BtnBrowseDestination.UseVisualStyleBackColor = true;
            this.BtnBrowseDestination.Click += new System.EventHandler(this.BtnBrowseDestination_Click);
            // 
            // LblDestination
            // 
            this.LblDestination.AutoSize = true;
            this.LblDestination.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDestination.Location = new System.Drawing.Point(12, 155);
            this.LblDestination.Name = "LblDestination";
            this.LblDestination.Size = new System.Drawing.Size(192, 35);
            this.LblDestination.TabIndex = 4;
            this.LblDestination.Text = "Destination:";
            // 
            // TextDestinationPath
            // 
            this.TextDestinationPath.Location = new System.Drawing.Point(18, 192);
            this.TextDestinationPath.Name = "TextDestinationPath";
            this.TextDestinationPath.Size = new System.Drawing.Size(1490, 26);
            this.TextDestinationPath.TabIndex = 3;
            // 
            // BtnStart
            // 
            this.BtnStart.Enabled = false;
            this.BtnStart.Location = new System.Drawing.Point(1562, 317);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(90, 32);
            this.BtnStart.TabIndex = 6;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // CheckboxDisplayNoMatches
            // 
            this.CheckboxDisplayNoMatches.AutoSize = true;
            this.CheckboxDisplayNoMatches.Location = new System.Drawing.Point(12, 322);
            this.CheckboxDisplayNoMatches.Name = "CheckboxDisplayNoMatches";
            this.CheckboxDisplayNoMatches.Size = new System.Drawing.Size(231, 24);
            this.CheckboxDisplayNoMatches.TabIndex = 7;
            this.CheckboxDisplayNoMatches.Text = "Display Files With No Match";
            this.CheckboxDisplayNoMatches.UseVisualStyleBackColor = true;
            this.CheckboxDisplayNoMatches.CheckedChanged += new System.EventHandler(this.CheckboxDisplayNoMatches_CheckedChanged);
            // 
            // FormFolderSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 362);
            this.Controls.Add(this.CheckboxDisplayNoMatches);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnBrowseDestination);
            this.Controls.Add(this.LblDestination);
            this.Controls.Add(this.TextDestinationPath);
            this.Controls.Add(this.BtnSourceBrowse);
            this.Controls.Add(this.LblSource);
            this.Controls.Add(this.TextSourcePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormFolderSelector";
            this.Text = "Folder Selector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFolderSelector_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextSourcePath;
        private System.Windows.Forms.Label LblSource;
        private System.Windows.Forms.Button BtnSourceBrowse;
        private System.Windows.Forms.Button BtnBrowseDestination;
        private System.Windows.Forms.Label LblDestination;
        private System.Windows.Forms.TextBox TextDestinationPath;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.CheckBox CheckboxDisplayNoMatches;
    }
}