﻿namespace ultrawide_me
{
    partial class Form1
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "gameFile";
            this.openFileDialog.Filter = "EXE Files|*.exe";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ProcessFile);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(57, 356);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(150, 60);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open File";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "EXE Files|*.exe";
            // 
            // openFileNameLabel
            // 
            this.openFileNameLabel.AutoSize = true;
            this.openFileNameLabel.Location = new System.Drawing.Point(54, 340);
            this.openFileNameLabel.Name = "openFileNameLabel";
            this.openFileNameLabel.Size = new System.Drawing.Size(80, 13);
            this.openFileNameLabel.TabIndex = 1;
            this.openFileNameLabel.Text = "No file selected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openFileNameLabel);
            this.Controls.Add(this.openButton);
            this.Name = "Form1";
            this.Text = "Ultrawide Me!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label openFileNameLabel;
    }
}

