using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace The_game_of_life
{
    class AnimalOrGrass
    {
        public bool DeadOrAlive { get; set; }
        public Point Cords { get; set; }
        public enum Animals
        {
            Fox,
            Bunny
        }
        public enum Grass
        {
            GrassStart,
            GrassMid,
            GrassEnd
        }
        public bool isAnimal { get; set; } //ha hamis akkor fű
        public byte Hunger { get; set; }
    }
}
