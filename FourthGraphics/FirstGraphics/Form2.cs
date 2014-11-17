using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstGraphics
{
    public partial class NewImage_form : Form
    {
        public NewImage_form()
        {
            InitializeComponent();
        }

        internal void button1_Click(object sender, EventArgs e)
        {
            int w = (int)numericUpDown1.Value,
                h = (int)numericUpDown2.Value;
            Image im = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(im);
            g.Clear(Color.White);
            g.Dispose();
            PictureBox p = Owner.Controls["panel1"].Controls["draw_area"] as PictureBox;
            if (p.Image != null)
                p.Image.Dispose();
            p.Image = im;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
