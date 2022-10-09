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
        public int[,] AnimalMatrix { get; set; }
        enum AnimalType
        {
            Fox,
            Bunny
        }
        public Point AnimalCords { get; set; } = new Point();
    }
}
