using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_game_of_life
{
    public class NextStep
    {
        public Animal[,] animal;
        public Grass[,] grass;
        public void Next()
        {
            
        }
        public void ContinouosNext()
        {
            //while (true)
            //{
            //    Thread.Sleep(1000);
            //    Next();
            //    if 
            //}
            //Task.Delay(1000).ContinueWith(t => Next()); //1 second
        }
        public NextStep() //init
        {
            animal = new Animal[80,37];
            grass = new Grass[80,37];
        } 
    }
}
