using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace FirstGraphics
{
    public partial class Main_form : Form
    {
        #region Properties

        NewImage_form form2 = new NewImage_form();
        Pen pen = new Pen(Color.Black);
        Point startPt;
        int indexOfRadioButton;
        Point movePt;
        Point nullPt = new Point(int.MaxValue, 0);
        SolidBrush brush = new SolidBrush(Color.White);
        int figureMode;
        bool equalSize;
        Bitmap oldImage;
        Font font;

        #endregion

        public Main_form()
        {
            InitializeComponent();

            AddOwnedForm(form2);
            openFileDialog1.InitialDirectory = saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            form2.numericUpDown1.Value = panel1.ClientSize.Width;
            form2.numericUpDown2.Value = panel1.ClientSize.Height;
            form2.button1_Click(this, null);
            pen.StartCap = pen.EndCap = LineCap.Round;
            pen.Alignment = PenAlignment.Inset;
            oldImage = new Bitmap(draw_area.Image);
            font = Font.Clone() as Font;
            type_line_comboBox.SelectedIndex = 0;
            this.DoubleBuffered = true;
            EnableDoubleBuffering();
        }

        #region Painting

        private void ReversibleDraw()
        {

            Point p1 = draw_area.PointToScreen(startPt),
                p2 = draw_area.PointToScreen(movePt);
            //p2 = pt;
            if (indexOfRadioButton == 1)
            {
                //Graphics g = Graphics.FromImage(draw_area.Image);
                //Pen pen = new Pen(Color.Black);
                //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //g.DrawLine(pen, p1, p2);
                //draw_area.Refresh();
                //pen.Dispose();
                //g.Dispose();
                ControlPaint.DrawReversibleLine(p1, p2, Color.Black);
            }
            else
                ControlPaint.DrawReversibleFrame(PtToRect(p1, p2), Color.Black, (FrameStyle)((figureMode + 1) % 2));
        }

        private void DrawFigure(Rectangle r, Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            switch (figureMode)
            {
                case 0:
                    if (!transparent_mode.Checked)
                        g.FillRectangle(brush, r);
                    g.DrawRectangle(pen, r);
                    break;
                case 1:
                    if (!transparent_mode.Checked)
                        g.FillEllipse(brush, r);
                    g.DrawEllipse(pen, r);
                    break;
            }

        }

        private Rectangle PtToRect(Point p1, Point p2)
        {
            if (equalSize)
            {
                int dx = p2.X - p1.X, dy = p2.Y - p1.Y;
                if (Math.Abs(dx) > Math.Abs(dy))
                    p2.X = p1.X + Math.Sign(dx) * Math.Abs(dy);
                else
                    p2.Y = p1.Y + Math.Sign(dy) * Math.Abs(dx);
            }
            int x = Math.Min(p1.X, p2.X),
                y = Math.Min(p1.Y, p2.Y),
                w = Math.Abs(p2.X - p1.X),
                h = Math.Abs(p2.Y - p1.Y);
            return new Rectangle(x, y, w, h);

        }

        private void UpdateOldImage()
        {
            oldImage.Dispose();
            oldImage = new Bitmap(draw_area.Image);
        }

        private void draw_area_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = string.Format("X,Y:{0},{1}", e.X, e.Y);
            if (startPt == nullPt)
                return;
            if (e.Button == MouseButtons.Left)
                switch (indexOfRadioButton)
                {
                    case 0:
                        Graphics g = Graphics.FromImage(draw_area.Image);
                        g.DrawLine(pen, startPt, e.Location);
                        g.Dispose();
                        startPt = e.Location;
                        draw_area.Invalidate();
                        break;
                    case 1:
                    //ReversibleDraw();
                    //movePt = e.Location;
                    //ReversibleDraw();
                    //break;
                    case 2:
                        //EnableDoubleBuffering();
                        ReversibleDraw();
                        //draw_area.Refresh();

                        movePt = e.Location;
                        //movePt = new Point(e.X, e.Y);
                        equalSize = Control.ModifierKeys == Keys.Control;
                        ReversibleDraw();
                        //draw_area.Invalidate();
                        //draw_area.Refresh();
                        break;
                }
        }

        private void draw_area_MouseDown(object sender, MouseEventArgs e)
        {
            movePt = startPt = e.Location;
            UpdateOldImage();
            if (Control.ModifierKeys == Keys.Alt)
            {
                Color c = (draw_area.Image as Bitmap).GetPixel(e.X, e.Y);
                if (e.Button == MouseButtons.Left)
                    line_color.BackColor = c;
                else
                    fill_color.BackColor = c;
            }
            else
                if (indexOfRadioButton == 3)
                {
                    Graphics g = Graphics.FromImage(draw_area.Image);
                    using (SolidBrush b = new SolidBrush(pen.Color))
                        g.DrawString(text_to_draw.Text, font, b, e.Location);
                    g.Dispose();
                    draw_area.Invalidate();
                }
        }

        private void draw_area_MouseUp(object sender, MouseEventArgs e)
        {
            if (startPt == nullPt)
                return;
            if (indexOfRadioButton >= 1)
            {
                Graphics g = Graphics.FromImage(draw_area.Image);
                switch (indexOfRadioButton)
                {
                    case 1:
                        g.DrawLine(pen, startPt, movePt);
                        break;
                    case 2:
                        DrawFigure(PtToRect(startPt, movePt), g);
                        break;
                }
                g.Dispose();
                draw_area.Invalidate();
            }
        }

        #endregion

        #region Acts with picture

        private void button_new_Click(object sender, EventArgs e)
        {
            form2.ActiveControl = form2.numericUpDown1;
            if (form2.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog1.FileName = "";
                Text = "Image Editor";
            }
            UpdateOldImage();
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string s = openFileDialog1.FileName;
                try
                {
                    Image im = new Bitmap(s);
                    Graphics g = Graphics.FromImage(im);
                    g.Dispose();
                    if (draw_area.Image != null)
                        draw_area.Image.Dispose();
                    draw_area.Image = im;
                    UpdateOldImage();
                }
                catch (Exception)
                {

                    MessageBox.Show("File " + s + " has a wrong format", "Error");
                    return;
                }
                Text = "Image Editor - " + s;
                saveFileDialog1.FileName = Path.ChangeExtension(s, "png");
                openFileDialog1.FileName = "";
            }

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string s0 = saveFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string s = saveFileDialog1.FileName;
                if (s.ToUpper() == s0.ToUpper())
                {
                    s0 = Path.GetDirectoryName(s0) + "\\($$##$$).png";
                    draw_area.Image.Save(s0);
                    draw_area.Image.Dispose();
                    File.Delete(s);
                    File.Move(s0, s);
                    draw_area.Image = new Bitmap(s);
                }
                else
                {
                    draw_area.Image.Save(s);
                    Text = "Image Editor - " + s;
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            UpdateOldImage();
            using (Graphics g = Graphics.FromImage(draw_area.Image))
                g.Clear(brush.Color);
            draw_area.Invalidate();
        }

        #endregion

        #region ColorSelecting

        private void line_color_Click(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            colorDialog1.Color = lb.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                lb.BackColor = colorDialog1.Color;
        }

        private void line_color_BackColorChanged(object sender, EventArgs e)
        {
            pen.Color = line_color.BackColor;
            figure_mode.Invalidate();
        }

        private void fill_color_BackColorChanged(object sender, EventArgs e)
        {
            brush.Color = fill_color.BackColor;
            figure_mode.Invalidate();
        }

        #endregion

        #region Drawing settings

        private void line_thickness_UpDown_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = (int)line_thickness_UpDown.Value;
            figure_mode.Invalidate();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (!rb.Checked)
                return;
            indexOfRadioButton = rb.TabIndex;
        }

        private void figure_mode_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = figure_mode.ClientRectangle;
            r.Width--; r.Height--;
            DrawFigure(r, g);
        }

        private void figure_mode_MouseDown(object sender, MouseEventArgs e)
        {
            radioButton3.Checked = true;
            figureMode = (figureMode + 1) % 2;
            figure_mode.Invalidate();
        }

        private void transparent_mode_CheckedChanged(object sender, EventArgs e)
        {
            figure_mode.Invalidate();
        }

        private void Main_form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                draw_area.Image.Dispose();
                draw_area.Image = new Bitmap(oldImage);
            }
        }

        private void text_to_draw_Enter(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
        }

        private void button_font_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                text_to_draw.Font = font = fontDialog1.Font;
            }
        }

        private void type_line_comboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            using (Pen p = new Pen(e.ForeColor, 2))
            {
                p.DashStyle = (DashStyle)e.Index;
                int y = (e.Bounds.Top + e.Bounds.Bottom) / 2;
                e.Graphics.DrawLine(p, e.Bounds.Left, y, e.Bounds.Right, y);
            }
            e.DrawFocusRectangle();

        }

        private void type_line_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen.DashStyle = (DashStyle)type_line_comboBox.SelectedIndex;
            figure_mode.Invalidate();
        }

        #endregion

        #region Misc

        public void EnableDoubleBuffering()
        {
            // Set the value of the double-buffering style bits to true.
            this.SetStyle(
               ControlStyles.DoubleBuffer |
               ControlStyles.UserPaint |
               ControlStyles.AllPaintingInWmPaint |
               ControlStyles.OptimizedDoubleBuffer |
               ControlStyles.ResizeRedraw,
               true);
            this.UpdateStyles();
        }

        Color InvertMeAColour(Color ColourToInvert)
        {
            const int RGBMAX = 255;

            return Color.FromArgb(RGBMAX - ColourToInvert.R,
              RGBMAX - ColourToInvert.G, RGBMAX - ColourToInvert.B);
        }

        #endregion

    }
}
