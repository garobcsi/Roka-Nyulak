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
        public enum Types : int
        {
            NoAnimal = 0,
            Fox = 1,
            Bunny = 2
        }
        private int type = 0;
        public int Type
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
        public List<int> Hungers { get; set; } = new List<int>(); // csak akkor ha több van egy helyen
        private int hunger = 0;
        public int Hunger
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
        public int Db { get; set; } = 0; // hany db egy cellán
        public Animal()
        {
            this.Type = 0;
            this.Hunger = 0;
            this.Db = 0;
            Hungers = new List<int>();
        }
        public Animal (int type,int hunger,int db)
        {
            this.Type = type;
            this.Hunger = hunger;
            this.Db = db;
        }
    }
}
