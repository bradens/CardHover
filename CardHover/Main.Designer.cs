/*
 * CardHover
 * Author: Braden Simpson
 * Description: A simple application to display HQ scans while
 *      playing NetDraft or any other application.
 * License: You are free to use, reference, or steal my code all
 *      you want, as long as I get credit.
 *
 * Main.Designer.cs
 */

namespace CardHover
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.debugBox = new System.Windows.Forms.TextBox();
            this.mouseTimer = new System.Windows.Forms.Timer(this.components);
            this.debugBox2 = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTempFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.minimizeTrayContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.minimizeTrayContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.startBtn.Location = new System.Drawing.Point(150, 80);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(111, 23);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start CardHover";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.stopBtn.Location = new System.Drawing.Point(268, 80);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(111, 23);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Stop CardHover";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // debugBox
            // 
            this.debugBox.Location = new System.Drawing.Point(12, 135);
            this.debugBox.Name = "debugBox";
            this.debugBox.Size = new System.Drawing.Size(367, 20);
            this.debugBox.TabIndex = 3;
            this.debugBox.Text = "MousePos: (X, Y) CardName: ";
            // 
            // mouseTimer
            // 
            this.mouseTimer.Interval = 10;
            this.mouseTimer.Tick += new System.EventHandler(this.mouseTimer_tick);
            // 
            // debugBox2
            // 
            this.debugBox2.Location = new System.Drawing.Point(12, 161);
            this.debugBox2.Name = "debugBox2";
            this.debugBox2.Size = new System.Drawing.Size(367, 20);
            this.debugBox2.TabIndex = 4;
            this.debugBox2.Text = "MousePos: (X, Y) CardID: ";
            // 
            // searchBox
            // 
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchBox.Location = new System.Drawing.Point(56, 109);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(323, 20);
            this.searchBox.TabIndex = 5;
            this.searchBox.Text = "Search for card";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            this.searchBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.searchBox_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(391, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.deleteTempFilesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // deleteTempFilesToolStripMenuItem
            // 
            this.deleteTempFilesToolStripMenuItem.Name = "deleteTempFilesToolStripMenuItem";
            this.deleteTempFilesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.deleteTempFilesToolStripMenuItem.Text = "Delete Temp Files";
            this.deleteTempFilesToolStripMenuItem.Click += new System.EventHandler(this.deleteTempFilesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // minimizeToTrayIcon
            // 
            this.minimizeToTrayIcon.ContextMenuStrip = this.minimizeTrayContext;
            this.minimizeToTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("minimizeToTrayIcon.Icon")));
            this.minimizeToTrayIcon.Text = "CardHover";
            this.minimizeToTrayIcon.Visible = true;
            this.minimizeToTrayIcon.DoubleClick += new System.EventHandler(this.minimizeToTrayIcon_DoubleClick);
            // 
            // minimizeTrayContext
            // 
            this.minimizeTrayContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.cloToolStripMenuItem});
            this.minimizeTrayContext.Name = "contextMenuStrip1";
            this.minimizeTrayContext.Size = new System.Drawing.Size(164, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openToolStripMenuItem.Text = "Open CardHover";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // cloToolStripMenuItem
            // 
            this.cloToolStripMenuItem.Name = "cloToolStripMenuItem";
            this.cloToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cloToolStripMenuItem.Text = "Exit";
            this.cloToolStripMenuItem.Click += new System.EventHandler(this.cloToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem1.Text = "How To";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.startBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.stopBtn;
            this.ClientSize = new System.Drawing.Size(391, 184);
            this.Controls.Add(this.debugBox2);
            this.Controls.Add(this.debugBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.searchBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CardHover";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Leave += new System.EventHandler(this.Main_Leave);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.minimizeTrayContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.TextBox debugBox;
        private System.Windows.Forms.Timer mouseTimer;
        private System.Windows.Forms.TextBox debugBox2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTempFilesToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon minimizeToTrayIcon;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip minimizeTrayContext;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
    }
}

