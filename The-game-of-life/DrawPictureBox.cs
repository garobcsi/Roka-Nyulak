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
            SetSBColor(Color.White);
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
        public void DrawRectangle(ref PictureBox pbGrid,Point Cords)
        {
            g.FillRectangle(sb, new Rectangle(Cords.X, Cords.Y, 15, 15));
            pbGrid.Image = (Bitmap)bmp;
        }
        public void SetSBColor(Color SolidBrushColor)
        {
            sb = new SolidBrush(SolidBrushColor);
        }
        public void DrawMatrix(ref PictureBox pbGrid)
        {

        }
        public DrawPictureBox(PictureBox pbGrid) //init
        {
            bmp = new Bitmap(pbGrid.Width, pbGrid.Height);
            g = Graphics.FromImage(bmp);
        }
    }
}
