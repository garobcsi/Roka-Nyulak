using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace The_game_of_life
{
    class PointIndex
    {
        public Point point { get; set; }
        public int index { get; set; }
        public PointIndex (Point point,int index)
        {
            this.point = point;
            this.index = index;
        }
    }
}
