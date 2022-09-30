using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_game_of_life
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            TestPictureBox();
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            btRun.BackColor = btRun.BackColor == Color.Green ? Color.Red : Color.Green;
            btRun.Text = btRun.Text == "START" ? "STOP" : "START";
        }

        void TestPictureBox()
        {
            #region simple test
            //width 1279 (width) by 15 seps w/ one plus added for gap
            //width 591 (height) by 15 seps w/ one plus added for gap
            Bitmap bmp = new Bitmap(pbGrid.Width, pbGrid.Height);
            Graphics g = Graphics.FromImage(bmp);
            SolidBrush sb = new SolidBrush(Color.White);
            g.Clear(Color.Black);
            for (int i = 0; i < pbGrid.Width; i += 15)
            {
                for (int j = 0; j < pbGrid.Height; j += 15)
                {

                    if (i >= pbGrid.Width - 15 && j >= pbGrid.Height - 15) // test last pice -15 from height and width
                    {
                        SolidBrush sb1 = new SolidBrush(Color.OrangeRed);
                        g.FillRectangle(sb1, new Rectangle(i, j, 15, 15));
                    }
                    else
                    {
                        g.FillRectangle(sb, new Rectangle(i, j, 15, 15));

                    }
                    j++; // separator
                }
                i++; // separator
            }
            pbGrid.Image = (Bitmap)bmp.Clone();
            #endregion
        }
    }
}
