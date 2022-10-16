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
            GrassStart = 0, // fűkezdemény
            GrassMid = 1, // zsenge fű
            GrassEnd = 2 // kifejlett fűcsomó
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
        public Grass()
        {
            this.Type = 0;
        }
        public Grass (int type)
        {
            this.Type = type;
        }
    }
}
