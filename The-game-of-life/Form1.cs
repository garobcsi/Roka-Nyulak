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
        public NextStep ns;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pb = new DrawPictureBox(pbGrid); //init
            ns = new NextStep();
            btAnimal.BackColor = ColorsAnimal.Fox;
            btGrass.BackColor = ColorsGrass.Start;
            pb.DrawGrid(ref pbGrid);
        }
        #region FormElements
        private void btRun_Click(object sender, EventArgs e)
        {
            if (btDraw.Enabled)
            {
                btRun.BackColor = Color.Red;
                btRun.Text = "STOP";
                btStep.Enabled = false;
                btReset.Enabled = false;
                btDraw.Enabled = false;
                btAnimalOrGrass.Enabled = false;
                btAnimal.Enabled = false;
                btGrass.Enabled = false;
            }
            else
            {
                btRun.BackColor = Color.Green;
                btRun.Text = "START";
                btStep.Enabled = true;
                btReset.Enabled = true;
                btDraw.Enabled = true;
                btAnimalOrGrass.Enabled = true;
                btAnimal.Enabled = true;
                btGrass.Enabled = true;
            }
        }
        private void btStep_Click(object sender, EventArgs e)
        {
            ns.Next();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            pb.DrawGrid(ref pbGrid);
            ns = new NextStep();
        }
        private bool btDrawState = false;
        private bool[] btDrawKeepState = { true, false };
        private void btDraw_Click(object sender, EventArgs e)
        {
            if (btDrawState == false)
            {
                btRun.Enabled = false;
                btRun.Font = new Font(btRun.Font, FontStyle.Regular);
                btStep.Enabled = false;
                btReset.Enabled = false;

                //Animal and Grass
                btAnimalOrGrass.Visible = true;
                laAnimalOrGrass.Visible = true;
                btAnimal.Visible = btDrawKeepState[0];
                laAnimal.Visible = btDrawKeepState[0];
                btGrass.Visible = btDrawKeepState[1];
                laGrass.Visible = btDrawKeepState[1];

                btDrawState = true;
            }
            else
            {
                btRun.Enabled = true;
                btRun.Font = new Font(btRun.Font, FontStyle.Bold);
                btStep.Enabled = true;
                btReset.Enabled = true;

                //Animal and Grass
                btAnimalOrGrass.Visible = false;
                laAnimalOrGrass.Visible = false;
                btDrawKeepState = new bool [] {btAnimal.Visible,btGrass.Visible };
                btAnimal.Visible = false;
                laAnimal.Visible = false;
                btGrass.Visible = false;
                laGrass.Visible = false;

                btDrawState = false;
            }
        }
        private void btAnimalOrGrass_Click(object sender, EventArgs e)
        {
            (btAnimal.Visible,btGrass.Visible) = (btGrass.Visible,btAnimal.Visible);
            (laAnimal.Visible,laGrass.Visible) = (laGrass.Visible,laAnimal.Visible);
            btAnimalOrGrass.Text = btAnimalOrGrass.Text == "Animal" ? "Grass" : "Animal";
        }
        private void btAnimal_Click(object sender, EventArgs e)
        {
            btAnimal.BackColor = btAnimal.BackColor == ColorsAnimal.Fox ? ColorsAnimal.Bunny : ColorsAnimal.Fox;
            btAnimal.Text = btAnimal.Text == "Fox" ? "Bunny" : "Fox";
        }
        private void btGrass_Click(object sender, EventArgs e)
        {
            btGrass.BackColor = btGrass.BackColor == ColorsGrass.Mid ? ColorsGrass.End : btGrass.BackColor == ColorsGrass.End ? ColorsGrass.Start : ColorsGrass.Mid;
            btGrass.Text = btGrass.Text == "Zsenge fű" ? "Kifejlett fűcsomó" : btGrass.Text == "Kifejlett fűcsomó" ? "Fűkezdemnény" : "Zsenge fű";
        }
        #endregion
        #region DrawPictureBox
        private Point? _Previous = null;
        private void pbGrid_MouseDown(object sender, MouseEventArgs e)
        {
            pb.SetSBColor(btAnimalOrGrass.Text != "Animal"?btAnimal.BackColor:btGrass.BackColor);
            _Previous = e.Location;
            pbGrid_MouseMove(sender, e);
        }

        private void pbGrid_MouseMove(object sender, MouseEventArgs e)
        {
            if (!(_Previous != null && btDrawState))
            {
                return;
            }
            Point index = new Point((int)Math.Ceiling((double)e.X / (double)16), (int)Math.Ceiling((double)e.Y / (double)16)); //indexes for adding data to matrix
            int x = index.X * 16 - 16;
            int y = index.Y * 16 - 16;
            if ((x < 0 || y < 0 || x > pbGrid.Width || y > pbGrid.Height)) // if not outside of canvas
            {
                return;
            }
            //Drawing to PictureBox
            pb.DrawRectangleWrite(ref pbGrid,index);
            //Adding to matrixes
            if (btAnimalOrGrass.Text != "Animal") // Its Animal
            {
                if (btAnimal.Text == "Fox")
                {
                    ns.animal[index.X - 1, index.Y - 1] = new Animal(1,10,index);
                    ns.grass[index.X - 1, index.Y - 1] = new Grass();
                }
                else
                {
                    ns.animal[index.X - 1, index.Y - 1] = new Animal(2, 5, index);
                    ns.grass[index.X - 1, index.Y - 1] = new Grass();
                }
            }
            else // Its Grass
            {
                if (btGrass.Text == "Fűkezdemnény")
                {
                    ns.grass[index.X - 1, index.Y - 1] = new Grass(0, index);
                    ns.animal[index.X - 1, index.Y - 1] = new Animal();
                }
                else if (btGrass.Text == "Zsenge fű")
                {
                    ns.grass[index.X - 1, index.Y - 1] = new Grass(1, index);
                    ns.animal[index.X - 1, index.Y - 1] = new Animal();
                }
                else
                {
                    ns.grass[index.X - 1, index.Y - 1] = new Grass(2, index);
                    ns.animal[index.X - 1, index.Y - 1] = new Animal();
                }
            }
            pbGrid.Invalidate();
            _Previous = e.Location;
        }
        private void pbGrid_MouseUp(object sender, MouseEventArgs e)
        {
            _Previous = null;
        }
        #endregion
    }
}