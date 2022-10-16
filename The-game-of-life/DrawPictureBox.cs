using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace The_game_of_life
{
    public class DrawPictureBox
    {
        public Bitmap bmp { get; private set; }
        public Graphics g { get; private set; }
        public SolidBrush sb { get; private set; }
        public void DrawGrid(ref PictureBox pbGrid)
        {
            g.Clear(Color.Black);
            SetSBColor(ColorsGrass.Start);
            for (int i = 0; i < pbGrid.Width; i += 15)
            {
                for (int j = 0; j < pbGrid.Height; j += 15)
                {
                    g.FillRectangle(sb, new Rectangle(i, j, 15, 15));

                    j++; // separator
                }
                i++; // separator
            }
            pbGrid.Image = (Bitmap)bmp;
        }
        public void DrawRectangle(ref PictureBox pbGrid, Point Cords,int a_or_g)
        {
            int x = Cords.X * 16 - 16;
            int y = Cords.Y * 16 - 16;
            if (!(x < 0 || y < 0 || x > pbGrid.Width || y > pbGrid.Height)) // if not outside of canvas
            {
                if (Form1.btDebugBool != true)
                {
                    g.FillRectangle(sb, new Rectangle(x, y, 15, 15));

                }
                else //debug start
                {
                    if (a_or_g == 1)
                    {
                        g.FillRectangle(sb, new Rectangle(x, y, 15, 15));
                    }
                    else
                    {
                        g.FillRectangle(sb, new Rectangle(x, y, 8, 15));
                    }
                }//debug end
            }
        }
        public void SetSBColor(Color SolidBrushColor)
        {
            sb = new SolidBrush(SolidBrushColor);
        }
        public void DrawMatrix(ref PictureBox pbGrid,Animal[,] animal,Grass[,] grass)
        {
            for (int i = 0; i < MatrixSize.Width; i++)
            {
                for (int j = 0; j < MatrixSize.Height; j++)
                {
                    //Draw Grass
                    if (grass[i,j].Type == 0)
                    {
                        SetSBColor(ColorsGrass.Start);
                        DrawRectangle(ref pbGrid, new Point(i + 1, j + 1),1);
                    }
                    else if (grass[i, j].Type == 1)
                    {
                        SetSBColor(ColorsGrass.Mid);
                        DrawRectangle(ref pbGrid, new Point(i + 1, j + 1),1);
                    }
                    else if (grass[i, j].Type == 2)
                    {
                        SetSBColor(ColorsGrass.End);
                        DrawRectangle(ref pbGrid, new Point(i + 1, j + 1),1);
                    }
                    //Animal
                    if (animal[i,j].Type != 0)
                    {
                        if (animal[i, j].Type == 1)
                        {
                            SetSBColor(ColorsAnimal.Fox);
                            DrawRectangle(ref pbGrid, new Point(i + 1, j + 1),2);
                        }
                        else if (animal[i, j].Type == 2) 
                        {
                            SetSBColor(ColorsAnimal.Bunny);
                            DrawRectangle(ref pbGrid, new Point(i + 1, j + 1),2);
                        }
                    }
                }
            }
            pbGrid.Image = (Bitmap)bmp;
        }
        public DrawPictureBox(PictureBox pbGrid) //init
        {
            bmp = new Bitmap(pbGrid.Width, pbGrid.Height);
            g = Graphics.FromImage(bmp);
        }
    }
}
