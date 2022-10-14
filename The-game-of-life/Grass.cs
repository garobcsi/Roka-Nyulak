using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace The_game_of_life
{
    public class Grass
    {
        public enum Types : int //Tápérték szintje a füveknek
        {
            GrassStart = 0,
            GrassMid = 1,
            GrassEnd = 2
        }
        private int type = 0;  
        public int Type { 
            get {
                return type;
            }

            set {
                if (Enum.IsDefined(typeof(Types),value))
                {
                    type = value;
                }
                else
                {
                    type = 0;
                }
            }
        }
        public Point Cords { get; set; } = new Point();
        public Grass()
        {
            this.Type = 0;
            this.Cords = new Point();
        }
        public Grass (int type, Point cords)
        {
            this.Type = type;
            this.Cords = cords;
        }
    }
}
