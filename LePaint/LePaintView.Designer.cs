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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rectangle = new System.Windows.Forms.PictureBox();
            this.rubberBrush = new System.Windows.Forms.PictureBox();
            this.gumka = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.plotno1 = new LePaint.Plotno();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineBrush = new System.Windows.Forms.PictureBox();
            this.elipsisBrush = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubberBrush)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elipsisBrush)).BeginInit();
            this.SuspendLayout();
            // 
            // colorPicker
            // 
            this.colorPicker.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorPicker.Location = new System.Drawing.Point(2, 41);
            this.colorPicker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(15, 16);
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
            this.penWidth.Location = new System.Drawing.Point(2, 11);
            this.penWidth.Margin = new System.Windows.Forms.Padding(2);
            this.penWidth.Name = "penWidth";
            this.penWidth.Size = new System.Drawing.Size(52, 21);
            this.penWidth.TabIndex = 3;
            this.penWidth.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(10, 25);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.elipsisBrush);
            this.splitContainer1.Panel1.Controls.Add(this.lineBrush);
            this.splitContainer1.Panel1.Controls.Add(this.rectangle);
            this.splitContainer1.Panel1.Controls.Add(this.rubberBrush);
            this.splitContainer1.Panel1.Controls.Add(this.gumka);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel1.Controls.Add(this.colorPicker);
            this.splitContainer1.Panel1.Controls.Add(this.penWidth);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.plotno1);
            this.splitContainer1.Size = new System.Drawing.Size(456, 429);
            this.splitContainer1.SplitterDistance = 90;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 4;
            // 
            // rectangle
            // 
            this.rectangle.Image = global::LePaint.Properties.Resources.Rectangle_128;
            this.rectangle.Location = new System.Drawing.Point(35, 89);
            this.rectangle.Margin = new System.Windows.Forms.Padding(2);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(29, 28);
            this.rectangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rectangle.TabIndex = 10;
            this.rectangle.TabStop = false;
            this.rectangle.Click += new System.EventHandler(this.brush_Click);
            // 
            // rubberBrush
            // 
            this.rubberBrush.Image = global::LePaint.Properties.Resources.Data_Erase_128;
            this.rubberBrush.Location = new System.Drawing.Point(2, 89);
            this.rubberBrush.Margin = new System.Windows.Forms.Padding(2);
            this.rubberBrush.Name = "rubberBrush";
            this.rubberBrush.Size = new System.Drawing.Size(29, 28);
            this.rubberBrush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rubberBrush.TabIndex = 9;
            this.rubberBrush.TabStop = false;
            this.rubberBrush.Click += new System.EventHandler(this.brush_Click);
            // 
            // gumka
            // 
            this.gumka.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gumka.Location = new System.Drawing.Point(22, 41);
            this.gumka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gumka.Name = "gumka";
            this.gumka.Size = new System.Drawing.Size(15, 16);
            this.gumka.TabIndex = 8;
            this.gumka.Text = "GUMKa";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(2, 68);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Filled";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // plotno1
            // 
            this.plotno1.AutoScroll = true;
            this.plotno1.AutoSize = true;
            this.plotno1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plotno1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.plotno1.Location = new System.Drawing.Point(3, 3);
            this.plotno1.Margin = new System.Windows.Forms.Padding(30, 2, 2, 2);
            this.plotno1.MaximumSize = new System.Drawing.Size(1200, 650);
            this.plotno1.MinimumSize = new System.Drawing.Size(1200, 650);
            this.plotno1.Name = "plotno1";
            this.plotno1.Size = new System.Drawing.Size(1200, 650);
            this.plotno1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(475, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click_1);
            // 
            // lineBrush
            // 
            this.lineBrush.Image = global::LePaint.Properties.Resources.Outlined_Triangular_Left_Arrow_128;
            this.lineBrush.Location = new System.Drawing.Point(2, 121);
            this.lineBrush.Margin = new System.Windows.Forms.Padding(2);
            this.lineBrush.Name = "lineBrush";
            this.lineBrush.Size = new System.Drawing.Size(29, 28);
            this.lineBrush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lineBrush.TabIndex = 11;
            this.lineBrush.TabStop = false;
            this.lineBrush.Click += new System.EventHandler(this.brush_Click);
            // 
            // elipsisBrush
            // 
            this.elipsisBrush.Image = global::LePaint.Properties.Resources.Shape_Circle_128;
            this.elipsisBrush.Location = new System.Drawing.Point(35, 121);
            this.elipsisBrush.Margin = new System.Windows.Forms.Padding(2);
            this.elipsisBrush.Name = "elipsisBrush";
            this.elipsisBrush.Size = new System.Drawing.Size(29, 28);
            this.elipsisBrush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.elipsisBrush.TabIndex = 12;
            this.elipsisBrush.TabStop = false;
            this.elipsisBrush.Click += new System.EventHandler(this.brush_Click);
            // 
            // LePaintView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(475, 449);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(379, 413);
            this.Name = "LePaintView";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubberBrush)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elipsisBrush)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label colorPicker;
        private System.Windows.Forms.ComboBox penWidth;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Plotno plotno1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label gumka;
        private System.Windows.Forms.PictureBox rubberBrush;
        private System.Windows.Forms.PictureBox rectangle;
        private System.Windows.Forms.PictureBox lineBrush;
        private System.Windows.Forms.PictureBox elipsisBrush;
    }
}

