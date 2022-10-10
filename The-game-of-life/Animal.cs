using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace The_game_of_life
{
    public class Animal
    {
        public enum Types : byte
        {
            NoAnimal = 0,
            Fox = 1,
            Bunny = 2
        }
        private byte type = 0;
        public byte Type
        {
            get
            {
                return type;
            }

            set
            {
                if (Enum.IsDefined(typeof(Types), value))
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
        private byte hunger = 0;
        public byte Hunger
        {
            get
            {
                return hunger;
            }

            set
            {
                if ((int)Types.Fox == Type)
                {
                    if (value <= 10 && 0 <= value)
                    {
                        hunger = value;
                    }
                    else
                    {
                        hunger = 0;
                    }
                }
                if ((int)Types.Bunny == Type)
                {
                    if (value <= 5 && 0 <= value)
                    {
                        hunger = value;
                    }
                    else 
                    {
                        hunger = 0;
                    }
                }
            }
        }
        public Animal (byte type,Point cords,byte hunger)
        {
            this.Type = type;
            this.Cords = cords;
            this.Hunger = hunger;

        }
    }
}
