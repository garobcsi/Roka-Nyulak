using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace The_game_of_life
{
    class ColorsAnimal
    {
        public static Color Fox { get; set; } = Color.FromArgb(183, 88, 0);
        public static Color Bunny { get; set; } = Color.Gray;
    }
    class ColorsGrass
    {
        public static Color Start { get; set; } = Color.FromArgb(185, 255, 174);
        public static Color Mid { get; set; } = Color.FromArgb(28, 217, 0);
        public static Color End { get; set; } = Color.Green;
    }
}
