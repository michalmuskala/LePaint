﻿namespace LePaint
{
    partial class Plotno
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Plotno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.MaximumSize = new System.Drawing.Size(700, 700);
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "Plotno";
            this.Size = new System.Drawing.Size(700, 700);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Plotno_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Plotno_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Plotno_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}