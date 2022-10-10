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
        public enum Types : byte //Tápérték szintje a füveknek
        {
            GrassStart = 0,
            GrassMid = 1,
            GrassEnd = 2
        }
        private byte type = 0;  
        public byte Type { 
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
        public Grass (byte type, Point cords)
        {
            this.Type = type;
            this.Cords = cords;
        }
    }
}
