using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace The_game_of_life
{
    public class NextStep
    {
        public int Iteration {get; set;} = 0;
        public Animal[,] animal;
        public Grass[,] grass;
        public void Next()
        {
            
            Animal[,] animal_temp = this.animal;
            Grass[,] grass_temp = this.grass;
            Random rnd = new Random();
            for (int i = 0; i < MatrixSize.Width; i++)
            {
                for (int j = 0; j < MatrixSize.Height; j++)
                {
                    if (animal[i,j].Type !=2) // Ha nincs rajta nyul
                    {
                        if (grass[i, j].Type !=2) //Csak max fű ig nő
                        {
                            grass_temp[i, j].Type++;

                        }
                    }

                    if (animal[i, j].Type == 2) // Nyuszi
                    {
                        if (animal[i, j].Db == 1) //Egy kockán csak egy van
                        {
                            if (grass[i, j].Type != 0) // legkisebnél már nem tud enni
                            {
                                if (grass[i, j].Type == 1) // zsenge fű eszik
                                {
                                    if (animal[i, j].Hunger+1<=5) // megtudja enni ? 
                                    {
                                        grass_temp[i, j].Type--;
                                        animal_temp[i, j].Hunger += 1; // Hunger + 1
                                    }
                                }
                                if (grass[i, j].Type == 2) // kifejlett fűcsomó eszik
                                {
                                    if (animal[i, j].Hunger + 2 <= 5) // megtudja enni ? 
                                    {
                                        grass_temp[i, j].Type--;
                                        animal_temp[i, j].Hunger += 2; // Hunger + 2
                                    }
                                }
                            }
                        }
                    }
                }
            }
            this.animal = animal_temp;
            this.grass = grass_temp;
            Iteration++;
        }
        public NextStep() //init
        {
            animal = new Animal[MatrixSize.Width, MatrixSize.Height];
            grass = new Grass[MatrixSize.Width, MatrixSize.Height];
            for (int i = 0; i < MatrixSize.Width; i++)
            {
                for (int j = 0; j < MatrixSize.Height; j++)
                {
                    animal[i, j] = new Animal();
                    grass[i, j] = new Grass();
                }
            }
        }        
    }
}
