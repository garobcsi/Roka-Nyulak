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
        enum Type: byte //Tápérték szintje a füveknek
        {
            GrassStart = 0,
            GrassMid = 1,
            GrassEnd = 2
        }
        public Point Cords { get; set; } = new Point();
    }
}
