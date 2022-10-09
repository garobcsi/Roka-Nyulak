using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace The_game_of_life
{
    class Animal
    {
        //public int[,] AnimalMatrix { get; set; }
        enum Type: byte //Tápérték szintje az állatoknak
        {
            Fox = 0,
            Bunny = 3
        }
        public Point Cords { get; set; } = new Point();
    }
}
