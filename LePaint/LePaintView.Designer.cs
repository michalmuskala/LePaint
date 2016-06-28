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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LePaintView));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorPicker = new System.Windows.Forms.Label();
            this.penWidth = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sprayBrush = new System.Windows.Forms.PictureBox();
            this.polygonBrush = new System.Windows.Forms.PictureBox();
            this.options = new System.Windows.Forms.ComboBox();
            this.imageBrush = new System.Windows.Forms.PictureBox();
            this.elipsisBrush = new System.Windows.Forms.PictureBox();
            this.lineBrush = new System.Windows.Forms.PictureBox();
            this.rectangle = new System.Windows.Forms.PictureBox();
            this.rubberBrush = new System.Windows.Forms.PictureBox();
            this.gumka = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotno1 = new LePaint.Plotno();
            this.gradientBrush = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sprayBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polygonBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elipsisBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubberBrush)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientBrush)).BeginInit();
            this.SuspendLayout();
            // 
            // colorPicker
            // 
            this.colorPicker.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorPicker.Location = new System.Drawing.Point(1, 59);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(20, 20);
            this.colorPicker.TabIndex = 1;
            this.colorPicker.Click += new System.EventHandler(this.colorPicker_Click);
            // 
            // penWidth
            // 
            this.penWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.penWidth.Location = new System.Drawing.Point(1, 30);
            this.penWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.penWidth.Name = "penWidth";
            this.penWidth.Size = new System.Drawing.Size(68, 24);
            this.penWidth.TabIndex = 3;
            this.penWidth.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(13, 31);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gradientBrush);
            this.splitContainer1.Panel1.Controls.Add(this.sprayBrush);
            this.splitContainer1.Panel1.Controls.Add(this.polygonBrush);
            this.splitContainer1.Panel1.Controls.Add(this.options);
            this.splitContainer1.Panel1.Controls.Add(this.imageBrush);
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
            this.splitContainer1.Size = new System.Drawing.Size(608, 528);
            this.splitContainer1.SplitterDistance = 90;
            this.splitContainer1.TabIndex = 4;
            // 
            // sprayBrush
            // 
            this.sprayBrush.Image = global::LePaint.Properties.Resources.Bottle_01_128;
            this.sprayBrush.Location = new System.Drawing.Point(1, 226);
            this.sprayBrush.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sprayBrush.Name = "sprayBrush";
            this.sprayBrush.Size = new System.Drawing.Size(39, 34);
            this.sprayBrush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sprayBrush.TabIndex = 13;
            this.sprayBrush.TabStop = false;
            this.sprayBrush.Click += new System.EventHandler(this.brush_Click);
            // 
            // polygonBrush
            // 
            this.polygonBrush.Image = global::LePaint.Properties.Resources.Free_Hand_Selection_128;
            this.polygonBrush.Location = new System.Drawing.Point(51, 186);
            this.polygonBrush.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.polygonBrush.Name = "polygonBrush";
            this.polygonBrush.Size = new System.Drawing.Size(39, 36);
            this.polygonBrush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.polygonBrush.TabIndex = 15;
            this.polygonBrush.TabStop = false;
            this.polygonBrush.Click += new System.EventHandler(this.brush_Click);
            // 
            // options
            // 
            this.options.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.options.FormattingEnabled = true;
            this.options.Items.AddRange(new object[] {
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
            this.options.Location = new System.Drawing.Point(1, 4);
            this.options.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(87, 24);
            this.options.TabIndex = 14;
            this.options.SelectedIndexChanged += new System.EventHandler(this.options_SelectedIndexChanged);
            // 
            // imageBrush
            // 
            this.imageBrush.Image = global::LePaint.Properties.Resources.Images_128;
            this.imageBrush.Location = new System.Drawing.Point(3, 186);
            this.imageBrush.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageBrush.Name = "imageBrush";
            this.imageBrush.Size = new System.Drawing.Size(37, 36);
            this.imageBrush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBrush.TabIndex = 13;
            this.imageBrush.TabStop = false;
            this.imageBrush.Click += new System.EventHandler(this.brush_Click);
            // 
            // elipsisBrush
            // 
            this.elipsisBrush.Image = global::LePaint.Properties.Resources.Shape_Circle_128;
            this.elipsisBrush.Location = new System.Drawing.Point(51, 146);
            this.elipsisBrush.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elipsisBrush.Name = "elipsisBrush";
            this.elipsisBrush.Size = new System.Drawing.Size(39, 34);
            this.elipsisBrush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.elipsisBrush.TabIndex = 12;
            this.elipsisBrush.TabStop = false;
            this.elipsisBrush.Click += new System.EventHandler(this.brush_Click);
            // 
            // lineBrush
            // 
            this.lineBrush.Image = global::LePaint.Properties.Resources.Pencil_128;
            this.lineBrush.Location = new System.Drawing.Point(1, 146);
            this.lineBrush.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineBrush.Name = "lineBrush";
            this.lineBrush.Size = new System.Drawing.Size(39, 34);
            this.lineBrush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lineBrush.TabIndex = 11;
            this.lineBrush.TabStop = false;
            this.lineBrush.Click += new System.EventHandler(this.brush_Click);
            // 
            // rectangle
            // 
            this.rectangle.Image = ((System.Drawing.Image)(resources.GetObject("rectangle.Image")));
            this.rectangle.Location = new System.Drawing.Point(51, 107);
            this.rectangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(39, 34);
            this.rectangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rectangle.TabIndex = 10;
            this.rectangle.TabStop = false;
            this.rectangle.Click += new System.EventHandler(this.brush_Click);
            // 
            // rubberBrush
            // 
            this.rubberBrush.Image = ((System.Drawing.Image)(resources.GetObject("rubberBrush.Image")));
            this.rubberBrush.Location = new System.Drawing.Point(1, 107);
            this.rubberBrush.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rubberBrush.Name = "rubberBrush";
            this.rubberBrush.Size = new System.Drawing.Size(39, 34);
            this.rubberBrush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rubberBrush.TabIndex = 9;
            this.rubberBrush.TabStop = false;
            this.rubberBrush.Click += new System.EventHandler(this.brush_Click);
            // 
            // gumka
            // 
            this.gumka.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gumka.Location = new System.Drawing.Point(21, 59);
            this.gumka.Name = "gumka";
            this.gumka.Size = new System.Drawing.Size(20, 20);
            this.gumka.TabIndex = 8;
            this.gumka.Text = "GUMKa";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1, 86);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Filled";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(633, 28);
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
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click_1);
            // 
            // plotno1
            // 
            this.plotno1.AutoScroll = true;
            this.plotno1.AutoSize = true;
            this.plotno1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plotno1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.plotno1.Location = new System.Drawing.Point(4, 4);
            this.plotno1.Margin = new System.Windows.Forms.Padding(40, 2, 3, 2);
            this.plotno1.MaximumSize = new System.Drawing.Size(1600, 800);
            this.plotno1.MinimumSize = new System.Drawing.Size(1600, 800);
            this.plotno1.Name = "plotno1";
            this.plotno1.Size = new System.Drawing.Size(1600, 800);
            this.plotno1.TabIndex = 0;
            // 
            // gradientBrush
            // 
            this.gradientBrush.Image = global::LePaint.Properties.Resources.Bottle_01_128;
            this.gradientBrush.Location = new System.Drawing.Point(49, 226);
            this.gradientBrush.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientBrush.Name = "gradientBrush";
            this.gradientBrush.Size = new System.Drawing.Size(39, 34);
            this.gradientBrush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gradientBrush.TabIndex = 16;
            this.gradientBrush.TabStop = false;
            this.gradientBrush.Click += new System.EventHandler(this.brush_Click);
            // 
            // LePaintView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(633, 553);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(498, 495);
            this.Name = "LePaintView";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sprayBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polygonBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elipsisBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubberBrush)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientBrush)).EndInit();
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
        private System.Windows.Forms.PictureBox sprayBrush;
        private System.Windows.Forms.PictureBox imageBrush;
        private System.Windows.Forms.ComboBox options;
        private System.Windows.Forms.PictureBox polygonBrush;
        private System.Windows.Forms.PictureBox gradientBrush;
    }
}

