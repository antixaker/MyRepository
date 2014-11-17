namespace FirstGraphics
{
    partial class Main_form
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
            this.button_new = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.draw_area = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.line_color = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.line_thickness_UpDown = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.fill_color = new System.Windows.Forms.Label();
            this.figure_mode = new System.Windows.Forms.Label();
            this.transparent_mode = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_to_draw = new System.Windows.Forms.TextBox();
            this.button_font = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.type_line_comboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.draw_area)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_thickness_UpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_new
            // 
            this.button_new.Location = new System.Drawing.Point(12, 10);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(87, 23);
            this.button_new.TabIndex = 0;
            this.button_new.Text = "&New";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(12, 44);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(87, 23);
            this.button_open.TabIndex = 1;
            this.button_open.Text = "&Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(12, 80);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(87, 23);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "&Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.draw_area);
            this.panel1.Location = new System.Drawing.Point(115, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 259);
            this.panel1.TabIndex = 3;
            // 
            // draw_area
            // 
            this.draw_area.Location = new System.Drawing.Point(0, 0);
            this.draw_area.Name = "draw_area";
            this.draw_area.Size = new System.Drawing.Size(97, 78);
            this.draw_area.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.draw_area.TabIndex = 0;
            this.draw_area.TabStop = false;
            this.draw_area.MouseDown += new System.Windows.Forms.MouseEventHandler(this.draw_area_MouseDown);
            this.draw_area.MouseMove += new System.Windows.Forms.MouseEventHandler(this.draw_area_MouseMove);
            this.draw_area.MouseUp += new System.Windows.Forms.MouseEventHandler(this.draw_area_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "png";
            this.openFileDialog1.Filter = "Image files (*.bmp,*.jpg,*.png,*.gif) | *.bmp;*.jpg;*.png;*.gif";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.Filter = "PNG-files (*.png) | *.png";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(419, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "X,Y: 0,0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(12, 117);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(87, 23);
            this.button_clear.TabIndex = 5;
            this.button_clear.Text = "&Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // line_color
            // 
            this.line_color.BackColor = System.Drawing.Color.Black;
            this.line_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line_color.Location = new System.Drawing.Point(115, 279);
            this.line_color.Name = "line_color";
            this.line_color.Size = new System.Drawing.Size(40, 40);
            this.line_color.TabIndex = 6;
            this.line_color.BackColorChanged += new System.EventHandler(this.line_color_BackColorChanged);
            this.line_color.Click += new System.EventHandler(this.line_color_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Width:";
            // 
            // line_thickness_UpDown
            // 
            this.line_thickness_UpDown.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.line_thickness_UpDown.Location = new System.Drawing.Point(219, 281);
            this.line_thickness_UpDown.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.line_thickness_UpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.line_thickness_UpDown.Name = "line_thickness_UpDown";
            this.line_thickness_UpDown.Size = new System.Drawing.Size(100, 20);
            this.line_thickness_UpDown.TabIndex = 8;
            this.line_thickness_UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.line_thickness_UpDown.ValueChanged += new System.EventHandler(this.line_thickness_UpDown_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 126);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(12, 100);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(46, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "&Text";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(12, 75);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(54, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "&Figure";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "&Ruler";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "&Pen";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // fill_color
            // 
            this.fill_color.BackColor = System.Drawing.Color.White;
            this.fill_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fill_color.Location = new System.Drawing.Point(129, 292);
            this.fill_color.Name = "fill_color";
            this.fill_color.Size = new System.Drawing.Size(40, 40);
            this.fill_color.TabIndex = 10;
            this.fill_color.BackColorChanged += new System.EventHandler(this.fill_color_BackColorChanged);
            this.fill_color.Click += new System.EventHandler(this.line_color_Click);
            // 
            // figure_mode
            // 
            this.figure_mode.Location = new System.Drawing.Point(12, 279);
            this.figure_mode.Name = "figure_mode";
            this.figure_mode.Size = new System.Drawing.Size(87, 47);
            this.figure_mode.TabIndex = 11;
            this.figure_mode.Text = "Transp";
            this.figure_mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.figure_mode.Paint += new System.Windows.Forms.PaintEventHandler(this.figure_mode_Paint);
            this.figure_mode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.figure_mode_MouseDown);
            // 
            // transparent_mode
            // 
            this.transparent_mode.AutoSize = true;
            this.transparent_mode.Location = new System.Drawing.Point(325, 282);
            this.transparent_mode.Name = "transparent_mode";
            this.transparent_mode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transparent_mode.Size = new System.Drawing.Size(86, 17);
            this.transparent_mode.TabIndex = 12;
            this.transparent_mode.Text = ":Transparent";
            this.transparent_mode.UseVisualStyleBackColor = true;
            this.transparent_mode.CheckedChanged += new System.EventHandler(this.transparent_mode_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Text:";
            // 
            // text_to_draw
            // 
            this.text_to_draw.Location = new System.Drawing.Point(219, 307);
            this.text_to_draw.Name = "text_to_draw";
            this.text_to_draw.Size = new System.Drawing.Size(100, 20);
            this.text_to_draw.TabIndex = 14;
            this.text_to_draw.Text = "Example";
            this.text_to_draw.Enter += new System.EventHandler(this.text_to_draw_Enter);
            // 
            // button_font
            // 
            this.button_font.Location = new System.Drawing.Point(325, 304);
            this.button_font.Name = "button_font";
            this.button_font.Size = new System.Drawing.Size(85, 23);
            this.button_font.TabIndex = 15;
            this.button_font.Text = "Font";
            this.button_font.UseVisualStyleBackColor = true;
            this.button_font.Click += new System.EventHandler(this.button_font_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.MaxSize = 28;
            this.fontDialog1.MinSize = 8;
            this.fontDialog1.ShowColor = true;
            // 
            // type_line_comboBox
            // 
            this.type_line_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.type_line_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_line_comboBox.FormattingEnabled = true;
            this.type_line_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.type_line_comboBox.Location = new System.Drawing.Point(419, 279);
            this.type_line_comboBox.Name = "type_line_comboBox";
            this.type_line_comboBox.Size = new System.Drawing.Size(107, 21);
            this.type_line_comboBox.TabIndex = 16;
            this.type_line_comboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.type_line_comboBox_DrawItem);
            this.type_line_comboBox.SelectedIndexChanged += new System.EventHandler(this.type_line_comboBox_SelectedIndexChanged);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 337);
            this.Controls.Add(this.type_line_comboBox);
            this.Controls.Add(this.button_font);
            this.Controls.Add(this.text_to_draw);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.transparent_mode);
            this.Controls.Add(this.figure_mode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.line_thickness_UpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.line_color);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.fill_color);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Editor";
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_form_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.draw_area)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_thickness_UpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox draw_area;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label line_color;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown line_thickness_UpDown;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label fill_color;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label figure_mode;
        private System.Windows.Forms.CheckBox transparent_mode;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_to_draw;
        private System.Windows.Forms.Button button_font;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ComboBox type_line_comboBox;

    }
}

