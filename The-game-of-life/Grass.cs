using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace The_game_of_life
{
    class Grass
    {
        //public int[,] GrassMatrix { get; set; }
        enum Type
        {
            GrassStart,
            GrassMid,
            GrassEnd
        }
        public Point Cords { get; set; } = new Point();
    }
}
