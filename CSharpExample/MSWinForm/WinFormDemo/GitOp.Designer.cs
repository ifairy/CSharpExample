﻿namespace WinFormDemo
{
    partial class GitOp
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
            this.folderBrowserDialogGit = new System.Windows.Forms.FolderBrowserDialog();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtGitDir = new System.Windows.Forms.TextBox();
            this.lblTaskCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPull = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGetUrl = new System.Windows.Forms.Button();
            this.txtUrls = new System.Windows.Forms.TextBox();
            this.txtGitPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDestBasePath = new System.Windows.Forms.TextBox();
            this.txtUrlsPath = new System.Windows.Forms.TextBox();
            this.btnPullSourceUrl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectUrlsFile = new System.Windows.Forms.Button();
            this.openFileDialogGit = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialogGit
            // 
            this.folderBrowserDialogGit.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.txtMessage);
            this.tabPage3.Controls.Add(this.txtGitDir);
            this.tabPage3.Controls.Add(this.lblTaskCount);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btnUpdate);
            this.tabPage3.Controls.Add(this.btnBrowser);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1095, 551);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "更新";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(37, 237);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(748, 231);
            this.txtMessage.TabIndex = 4;
            // 
            // txtGitDir
            // 
            this.txtGitDir.Location = new System.Drawing.Point(112, 23);
            this.txtGitDir.Name = "txtGitDir";
            this.txtGitDir.Size = new System.Drawing.Size(673, 21);
            this.txtGitDir.TabIndex = 1;
            // 
            // lblTaskCount
            // 
            this.lblTaskCount.AutoSize = true;
            this.lblTaskCount.Location = new System.Drawing.Point(706, 55);
            this.lblTaskCount.Name = "lblTaskCount";
            this.lblTaskCount.Size = new System.Drawing.Size(53, 12);
            this.lblTaskCount.TabIndex = 5;
            this.lblTaskCount.Text = "线程数：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Git库目录：";
            // 
            // btnPull
            // 
            this.btnPull.Location = new System.Drawing.Point(829, 68);
            this.btnPull.Name = "btnPull";
            this.btnPull.Size = new System.Drawing.Size(75, 23);
            this.btnPull.TabIndex = 3;
            this.btnPull.Text = "Pull";
            this.btnPull.UseVisualStyleBackColor = true;
            this.btnPull.Click += new System.EventHandler(this.BtnPull_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(872, 22);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(791, 21);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 2;
            this.btnBrowser.Text = "浏览";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGetUrl);
            this.tabPage1.Controls.Add(this.txtUrls);
            this.tabPage1.Controls.Add(this.txtGitPath);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(910, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "获取Url";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGetUrl
            // 
            this.btnGetUrl.Location = new System.Drawing.Point(808, 63);
            this.btnGetUrl.Name = "btnGetUrl";
            this.btnGetUrl.Size = new System.Drawing.Size(94, 23);
            this.btnGetUrl.TabIndex = 6;
            this.btnGetUrl.Text = "获取PushUrl";
            this.btnGetUrl.UseVisualStyleBackColor = true;
            this.btnGetUrl.Click += new System.EventHandler(this.BtnGetUrl_Click);
            // 
            // txtUrls
            // 
            this.txtUrls.Location = new System.Drawing.Point(37, 74);
            this.txtUrls.Multiline = true;
            this.txtUrls.Name = "txtUrls";
            this.txtUrls.Size = new System.Drawing.Size(764, 275);
            this.txtUrls.TabIndex = 5;
            // 
            // txtGitPath
            // 
            this.txtGitPath.Location = new System.Drawing.Point(113, 22);
            this.txtGitPath.Name = "txtGitPath";
            this.txtGitPath.Size = new System.Drawing.Size(688, 21);
            this.txtGitPath.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(807, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "浏览";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "GIt库目录：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1103, 577);
            this.tabControl1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSelectUrlsFile);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUrlsPath);
            this.groupBox1.Controls.Add(this.btnPullSourceUrl);
            this.groupBox1.Controls.Add(this.txtDestBasePath);
            this.groupBox1.Controls.Add(this.btnPull);
            this.groupBox1.Location = new System.Drawing.Point(37, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 125);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "拉取";
            // 
            // txtDestBasePath
            // 
            this.txtDestBasePath.Location = new System.Drawing.Point(70, 68);
            this.txtDestBasePath.Name = "txtDestBasePath";
            this.txtDestBasePath.Size = new System.Drawing.Size(673, 21);
            this.txtDestBasePath.TabIndex = 4;
            // 
            // txtUrlsPath
            // 
            this.txtUrlsPath.Location = new System.Drawing.Point(71, 22);
            this.txtUrlsPath.Name = "txtUrlsPath";
            this.txtUrlsPath.Size = new System.Drawing.Size(673, 21);
            this.txtUrlsPath.TabIndex = 6;
            // 
            // btnPullSourceUrl
            // 
            this.btnPullSourceUrl.Location = new System.Drawing.Point(751, 69);
            this.btnPullSourceUrl.Name = "btnPullSourceUrl";
            this.btnPullSourceUrl.Size = new System.Drawing.Size(75, 23);
            this.btnPullSourceUrl.TabIndex = 5;
            this.btnPullSourceUrl.Text = "浏览";
            this.btnPullSourceUrl.UseVisualStyleBackColor = true;
            this.btnPullSourceUrl.Click += new System.EventHandler(this.BtnPullSourceUrl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "GitUrls：";
            // 
            // btnSelectUrlsFile
            // 
            this.btnSelectUrlsFile.Location = new System.Drawing.Point(750, 22);
            this.btnSelectUrlsFile.Name = "btnSelectUrlsFile";
            this.btnSelectUrlsFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectUrlsFile.TabIndex = 8;
            this.btnSelectUrlsFile.Text = "浏览";
            this.btnSelectUrlsFile.UseVisualStyleBackColor = true;
            this.btnSelectUrlsFile.Click += new System.EventHandler(this.BtnSelectUrlsFile_Click);
            // 
            // openFileDialogGit
            // 
            this.openFileDialogGit.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dest：";
            // 
            // GitOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 577);
            this.Controls.Add(this.tabControl1);
            this.Name = "GitOp";
            this.Text = "GitOp";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogGit;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtGitDir;
        private System.Windows.Forms.Label lblTaskCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPull;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnGetUrl;
        private System.Windows.Forms.TextBox txtUrls;
        private System.Windows.Forms.TextBox txtGitPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUrlsPath;
        private System.Windows.Forms.Button btnPullSourceUrl;
        private System.Windows.Forms.TextBox txtDestBasePath;
        private System.Windows.Forms.Button btnSelectUrlsFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialogGit;
        private System.Windows.Forms.Label label4;
    }
}