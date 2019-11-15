﻿namespace RevertSteam
{
    partial class RevertSteamWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevertSteamWindow));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnRevert = new System.Windows.Forms.Button();
            this.btnPatch = new System.Windows.Forms.Button();
            this.pgbDownload = new System.Windows.Forms.ProgressBar();
            this.txtSteamPath = new System.Windows.Forms.TextBox();
            this.lblSteamPath = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.btnBrowse.Location = new System.Drawing.Point(234, 29);
            this.btnBrowse.Name = "browseButton";
            this.btnBrowse.Size = new System.Drawing.Size(28, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // revertButton
            // 
            this.btnRevert.Location = new System.Drawing.Point(12, 161);
            this.btnRevert.Name = "revertButton";
            this.btnRevert.Size = new System.Drawing.Size(75, 23);
            this.btnRevert.TabIndex = 1;
            this.btnRevert.Text = "Revert";
            this.btnRevert.UseVisualStyleBackColor = true;
            this.btnRevert.Click += new System.EventHandler(this.revertButton_Click);
            // 
            // patchButton
            // 
            this.btnPatch.Location = new System.Drawing.Point(190, 161);
            this.btnPatch.Name = "patchButton";
            this.btnPatch.Size = new System.Drawing.Size(75, 23);
            this.btnPatch.TabIndex = 2;
            this.btnPatch.Text = "Patch";
            this.btnPatch.UseVisualStyleBackColor = true;
            this.btnPatch.Click += new System.EventHandler(this.patchButton_Click);
            // 
            // downloadProgressBar
            // 
            this.pgbDownload.Location = new System.Drawing.Point(12, 190);
            this.pgbDownload.Name = "downloadProgressBar";
            this.pgbDownload.Size = new System.Drawing.Size(253, 23);
            this.pgbDownload.TabIndex = 3;
            // 
            // browseTextBox
            // 
            this.txtSteamPath.Location = new System.Drawing.Point(12, 29);
            this.txtSteamPath.Name = "browseTextBox";
            this.txtSteamPath.Size = new System.Drawing.Size(216, 20);
            this.txtSteamPath.TabIndex = 4;
            this.txtSteamPath.TabStop = false;
            // 
            // lblSteamPath
            // 
            this.lblSteamPath.AutoSize = true;
            this.lblSteamPath.Location = new System.Drawing.Point(12, 9);
            this.lblSteamPath.Name = "lblSteamPath";
            this.lblSteamPath.Size = new System.Drawing.Size(138, 13);
            this.lblSteamPath.TabIndex = 6;
            this.lblSteamPath.Text = "Steam Installation Directory:";
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(12, 73);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(250, 39);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "This tool automatically reverts Steam back to the\r\nprevious version of the Librar" +
    "y UI, undoing the\r\nSteam Library update from October 30th 2019.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(12, 220);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(253, 23);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Ready.";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RevertSteamWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 252);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblSteamPath);
            this.Controls.Add(this.txtSteamPath);
            this.Controls.Add(this.pgbDownload);
            this.Controls.Add(this.btnPatch);
            this.Controls.Add(this.btnRevert);
            this.Controls.Add(this.btnBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RevertSteamWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RevertSteam";
            this.Load += new System.EventHandler(this.RevertSteamWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnRevert;
        private System.Windows.Forms.Button btnPatch;
        private System.Windows.Forms.ProgressBar pgbDownload;
        private System.Windows.Forms.TextBox txtSteamPath;
        private System.Windows.Forms.Label lblSteamPath;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblStatus;
    }
}

