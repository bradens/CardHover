/*
 * CardHover
 * Author: Braden Simpson
 * Description: A simple application to display HQ scans while
 *      playing NetDraft or any other application.
 * License: You are free to use, reference, or steal my code all
 *      you want, as long as I get credit.
 *
 * PictureBox.Designer.cs
 */

namespace CardHover
{
    partial class pictureBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pictureBox));
            this.picInner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picInner)).BeginInit();
            this.SuspendLayout();
            // 
            // picInner
            // 
            this.picInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picInner.Image = ((System.Drawing.Image)(resources.GetObject("picInner.Image")));
            this.picInner.InitialImage = null;
            this.picInner.Location = new System.Drawing.Point(0, 0);
            this.picInner.Name = "picInner";
            this.picInner.Size = new System.Drawing.Size(230, 330);
            this.picInner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInner.TabIndex = 0;
            this.picInner.TabStop = false;
            // 
            // pictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(230, 330);
            this.ControlBox = false;
            this.Controls.Add(this.picInner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pictureBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.picInner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picInner;

    }
}