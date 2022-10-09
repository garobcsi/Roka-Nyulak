using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_game_of_life
{
    class NextStep
    {
        Animal[,] animal; 
        Grass[,] grass;

        void Next()
        {
            
        }
        void ContinouosNext()
        {
            Task.Delay(1000).ContinueWith(t => Next()); //1 second
        }
        public NextStep()
        {
            animal = new Animal[80,37];
            grass = new Grass[80,37];
        } 
    }
}
