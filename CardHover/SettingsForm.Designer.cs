/*
 * CardHover
 * Author: Braden Simpson
 * Description: A simple application to display HQ scans while
 *      playing NetDraft or any other application.
 * License: You are free to use, reference, or steal my code all
 *      you want, as long as I get credit.
 *
 * SettingsForm.Designer.cs
 */

namespace CardHover
{
    partial class SettingsForm
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
            this.settingsWelcomeLbl = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.pathLbl = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.dontWorryLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // settingsWelcomeLbl
            // 
            this.settingsWelcomeLbl.AutoSize = true;
            this.settingsWelcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsWelcomeLbl.Location = new System.Drawing.Point(-1, 9);
            this.settingsWelcomeLbl.Name = "settingsWelcomeLbl";
            this.settingsWelcomeLbl.Size = new System.Drawing.Size(205, 25);
            this.settingsWelcomeLbl.TabIndex = 0;
            this.settingsWelcomeLbl.Text = "CardHover Settings.";
            // 
            // pathBox
            // 
            this.pathBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pathBox.Location = new System.Drawing.Point(4, 100);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(432, 20);
            this.pathBox.TabIndex = 1;
            this.pathBox.Text = "C:\\Program Files (x86)\\Magic Workstation\\pics\\";
            // 
            // pathLbl
            // 
            this.pathLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pathLbl.AutoSize = true;
            this.pathLbl.Location = new System.Drawing.Point(1, 74);
            this.pathLbl.Name = "pathLbl";
            this.pathLbl.Size = new System.Drawing.Size(173, 13);
            this.pathLbl.TabIndex = 2;
            this.pathLbl.Text = "Enter the path to your \"pics\" folder.";
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okBtn.Location = new System.Drawing.Point(313, 126);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(123, 21);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // dontWorryLbl
            // 
            this.dontWorryLbl.AutoSize = true;
            this.dontWorryLbl.Location = new System.Drawing.Point(1, 51);
            this.dontWorryLbl.Name = "dontWorryLbl";
            this.dontWorryLbl.Size = new System.Drawing.Size(208, 13);
            this.dontWorryLbl.TabIndex = 4;
            this.dontWorryLbl.Text = "Don\'t worry, you only have to do this once.";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 159);
            this.Controls.Add(this.dontWorryLbl);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.pathLbl);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.settingsWelcomeLbl);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label settingsWelcomeLbl;
        private System.Windows.Forms.Label pathLbl;
        private System.Windows.Forms.Button okBtn;
        public System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Label dontWorryLbl;
    }
}