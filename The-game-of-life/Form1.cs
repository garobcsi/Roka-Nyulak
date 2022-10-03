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
            InitPictureBox();
            DrawPictureBox();
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            btRun.BackColor = btRun.BackColor == Color.Green ? Color.Red : Color.Green;
            btRun.Text = btRun.Text == "START" ? "STOP" : "START";
            btStep.Enabled = btRun.BackColor == Color.Green ? true : false;
            btReset.Enabled = btRun.BackColor == Color.Green ? true : false;
            btDraw.Enabled = btRun.BackColor == Color.Green ? true : false;
        }
        #region PictureBox
        public Bitmap bmp;
        public Graphics g;
        public SolidBrush sb;
        void InitPictureBox()
        {
            bmp = new Bitmap(pbGrid.Width, pbGrid.Height);
            g = Graphics.FromImage(bmp);
        }
        void DrawPictureBox() {
            g.Clear(Color.White);
            pbGrid.Image = (Bitmap)bmp.Clone();
        }
        #endregion
        #region Draw
        private Point? _Previous = null;
        private void pbGrid_MouseDown(object sender, MouseEventArgs e)
        {
            sb = new SolidBrush(Color.Black);
            _Previous = e.Location;
            pbGrid_MouseMove(sender, e);
        }

        private void pbGrid_MouseMove(object sender, MouseEventArgs e)
        {
            if (_Previous != null)
            {
                int index_x = (int)Math.Ceiling((double)e.X / (double)16);
                int index_y = (int)Math.Ceiling((double)e.Y / (double)16);
                int x = index_x * 16 - 16;
                int y = index_y * 16 - 16;
                
                if (!(x < 0 || y <0 || x > pbGrid.Width || y > pbGrid.Height)) // if not outside of canvas
                {
                    g.FillRectangle(sb, new Rectangle(x,y, 15, 15));
                    pbGrid.Image = (Bitmap)bmp.Clone();
                }
                pbGrid.Invalidate();
                _Previous = e.Location;
            }
        }

        private void pbGrid_MouseUp(object sender, MouseEventArgs e)
        {
            _Previous = null;
        }
        #endregion
    }
}
