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
        public DrawPictureBox pb;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pb = new DrawPictureBox(pbGrid); //init
            pb.DrawGrid(ref pbGrid);
        }
        #region FormElements
        private void btRun_Click(object sender, EventArgs e)
        {
            btRun.BackColor = btRun.BackColor == Color.Green ? Color.Red : Color.Green;
            btRun.Text = btRun.Text == "START" ? "STOP" : "START";
            btStep.Enabled = btRun.BackColor == Color.Green ? true : false;
            btReset.Enabled = btRun.BackColor == Color.Green ? true : false;
            btDraw.Enabled = btRun.BackColor == Color.Green ? true : false;
        }
        private bool btDrawState = false;
        private void btDraw_Click(object sender, EventArgs e)
        {
            btDrawState = btDrawState == false ? true : false;
            btColor.Visible = btDrawState == false ? false : true;
            laColor.Visible = btDrawState == false ? false : true;
            btRun.Enabled = btDrawState == false ? true : false;
            btRun.Font = btDrawState == false ? new Font(btRun.Font, FontStyle.Bold) : new Font(btRun.Font, FontStyle.Regular);
            btStep.Enabled = btDrawState == false ? true : false;
            btReset.Enabled = btDrawState == false ? true : false;
        }
        private void btColor_Click(object sender, EventArgs e)
        {
            btColor.BackColor = btColor.BackColor == Color.Black ? Color.White : Color.Black;
            btColor.ForeColor = btColor.ForeColor == Color.White ? Color.Black : Color.White;
            btColor.Text = btColor.Text == "Black" ? "White" : "Black";
        }
        private void btStep_Click(object sender, EventArgs e)
        {

        }

        private void btReset_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region DrawPictureBox
        private Point? _Previous = null;
        private void pbGrid_MouseDown(object sender, MouseEventArgs e)
        {
            pb.SetSBColor(btColor.BackColor);
            _Previous = e.Location;
            pbGrid_MouseMove(sender, e);
        }

        private void pbGrid_MouseMove(object sender, MouseEventArgs e)
        {
            if (_Previous != null && btDrawState)
            {
                int index_x = (int)Math.Ceiling((double)e.X / (double)16); //indexes for adding data to matrix
                int index_y = (int)Math.Ceiling((double)e.Y / (double)16);
                int x = index_x * 16 - 16;
                int y = index_y * 16 - 16;
                
                if (!(x < 0 || y <0 || x > pbGrid.Width || y > pbGrid.Height)) // if not outside of canvas
                {
                    pb.DrawRectangle(ref pbGrid,new Point(x,y));
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
