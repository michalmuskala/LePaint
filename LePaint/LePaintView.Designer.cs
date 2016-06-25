namespace LePaint
{
    partial class LePaintView
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorPicker = new System.Windows.Forms.Label();
            this.penWidth = new System.Windows.Forms.ComboBox();
            this.plotno1 = new LePaint.Plotno();
            this.SuspendLayout();
            // 
            // colorPicker
            // 
            this.colorPicker.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorPicker.Location = new System.Drawing.Point(13, 13);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(20, 20);
            this.colorPicker.TabIndex = 1;
            this.colorPicker.Click += new System.EventHandler(this.colorPicker_Click);
            // 
            // penWidth
            // 
            this.penWidth.FormattingEnabled = true;
            this.penWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.penWidth.Location = new System.Drawing.Point(16, 89);
            this.penWidth.Name = "penWidth";
            this.penWidth.Size = new System.Drawing.Size(68, 24);
            this.penWidth.TabIndex = 3;
            this.penWidth.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // plotno1
            // 
            this.plotno1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotno1.AutoScroll = true;
            this.plotno1.AutoSize = true;
            this.plotno1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.plotno1.Location = new System.Drawing.Point(123, 4);
            this.plotno1.Margin = new System.Windows.Forms.Padding(20, 100, 20, 20);
            this.plotno1.MaximumSize = new System.Drawing.Size(700, 700);
            this.plotno1.MinimumSize = new System.Drawing.Size(700, 700);
            this.plotno1.Name = "plotno1";
            this.plotno1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.plotno1.Size = new System.Drawing.Size(700, 700);
            this.plotno1.TabIndex = 0;
            // 
            // LePaintView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.penWidth);
            this.Controls.Add(this.colorPicker);
            this.Controls.Add(this.plotno1);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "LePaintView";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.LePaintView_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Plotno plotno1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label colorPicker;
        private System.Windows.Forms.ComboBox penWidth;

    }
}

