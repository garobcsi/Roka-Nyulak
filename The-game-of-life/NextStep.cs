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
            #region info
            //#region CSAK EGY PÉLDA !
            //try // az elötte lévöt törli
            //{
            //    animal[i - 1, 0] = new Animal(); 
            //}
            //catch (Exception)
            //{


            //}
            //try
            //{
            //    animal[i, 0] = new Animal(1,10,new Point(i+1,1));

            //}
            //catch (Exception)
            //{

            //    throw new IndexOutOfRangeException(); // index határain kivül van !
            //}
            //i++;
            //#endregion
            //animal[0, 0].Type  //
            //animal[0, 0].Hunger//
            //animal[0, 0].Cords //
            // Igy lehet az iformációkat lekérdezni INDEXEL
            //grass[0, 0].Type   //
            //grass[0, 0].Cords  //

            // animal[0, 0] = new Animal(1, 10, new Point(1, 1)); // igy lehet majd megandi az információt (Type,Hunger = starting hunger,és Pozició)  !!(! A pozició elvan tolva egyel !) A 0,0 Pozició az INVALID !! (Mátrixnál 0,0 valós index)
            // grass[1, 0] = new Grass(1, new Point(2, 1)); // (Type,Pozicó) | A tipusokat majd a classok ba lehet látni az enumba

            //animal[0, 0] = new Animal(); // igy lehet visza állitani alapokra az infot //PL: ez azért fontos mer 2 mátrixal dolgozunk és ha nyuszi megeszi a füvet. A fü allata visza áll az alapértékre
            // grass[0, 0] = new Grass(); // ugyan ez az állatnál //PL: nyuszi meghal (Hunger == 0) akkor visza áll az alapra

            //a user nek a mátrix kiirása már kész igy azt nem kell megirnotok
            //A ContinouosNext() már kész !
            #endregion
            
            Iteration++;
            Animal[,] animal_temp = animal;
            Grass[,] grass_temp = grass;
            Random rnd = new Random(); //Random irány generálása 1-től 8-ig
            for (int i = 0; i < MatrixSize.Width; i++)
            {
                for (int j = 0; j < MatrixSize.Height; j++)
                {
                    //Fűnövekedés
                    if (grass[i,j].Type == 0 && animal[i,j].Type==0)
                    {
                        grass_temp[i, j] = new Grass(1);
                    }
                    else if (grass[i, j].Type == 1 && animal[i, j].Type == 0)
                    {
                        grass_temp[i, j] = new Grass(2);
                    }

                    //Nyuszi
                    if (animal[i, j].Type==2) 
                    {
                        //Éhség és halál
                        int h = animal[i, j].Hunger;
                        //animal_temp[i,j] = new Animal(2, h - 1);
                        if (animal[i, j].Hunger == 0)
                        {
                            animal_temp[i, j] = new Animal();
                        }

                        //Evés
                        if (grass[i, j].Type != 0)
                        {
                            int a = grass[i, j].Type - 1;
                            grass_temp[i, j] = new Grass(a);
                            if (animal[i, j].Hunger < 4 && grass[i, j].Type == 2)
                            {
                                animal_temp[i, j].Hunger = animal_temp[i, j].Hunger + 2;
                            }
                            else if (animal[i, j].Hunger < 5 && grass[i, j].Type == 1)
                            {
                                animal_temp[i, j].Hunger++;
                            }
                        }
                        //Mozgás
                        else
                        {
                            /*int random = 0;
                            if (animal_temp[i - 1, j - 1].Type != 0)
                            {
                                random = rnd.Next(2, 8 + 1);
                            }
                            else if (animal_temp[i, j - 1].Type != 0)
                            {
                                random = rnd.Next(1, 8 + 1);
                                if (random == 2)
                                {
                                    random++;
                                }
                            }
                            else if (animal_temp[i + 1, j + 1].Type != 0)
                            {
                                random = rnd.Next(1, 8 + 1);
                                if (random == 3)
                                {
                                    random++;
                                }
                            }
                            else if (animal_temp[i - 1, j].Type != 0)
                            {
                                random = rnd.Next(1, 8 + 1);
                                if (random == 4)
                                {
                                    random++;
                                }
                            }
                            else if (animal_temp[i + 1, j].Type != 0)
                            {
                                random = rnd.Next(1, 8 + 1);
                                if (random == 5)
                                {
                                    random++;
                                }
                            }
                            else if (animal_temp[i - 1, j + 1].Type != 0)
                            {
                                random = rnd.Next(1, 8 + 1);
                                if (random == 6)
                                {
                                    random++;
                                }
                            }
                            else if (animal_temp[i, j + 1].Type != 0)
                            {
                                random = rnd.Next(1, 8 + 1);
                                if (random == 7)
                                {
                                    random++;
                                }
                            }
                            else if (animal_temp[i + 1, j + 1].Type != 0)
                            {
                                random = rnd.Next(1, 7 + 1);
                            }*/

                            try
                            { 
                                switch (rnd.Next(1, 8 + 1)) //Irányok: 1=balfel, 2=fel, 3=jobbfel, 4=bal, 5=jobb, 6=balle, 7=le, 8=jobble
                                {
                                    case 1:
                                        animal_temp[i - 1, j - 1] = new Animal(2, h - 1);
                                        break;
                                    case 2:
                                        animal_temp[i, j - 1] = new Animal(2, h - 1);
                                        break;
                                    case 3:
                                        animal_temp[i + 1, j + 1] = new Animal(2, h - 1);
                                        break;
                                    case 4:
                                        animal_temp[i - 1, j] = new Animal(2, h - 1);
                                        break;
                                    case 5:
                                        animal_temp[i + 1, j] = new Animal(2, h - 1);
                                        break;
                                    case 6:
                                        animal_temp[i - 1, j + 1] = new Animal(2, h - 1);
                                        break;
                                    case 7:
                                        animal_temp[i, j + 1] = new Animal(2, h - 1);
                                        break;
                                    case 8:
                                        animal_temp[i + 1, j + 1] = new Animal(2, h - 1);
                                        break;
                                }
                            }
                            catch (Exception)
                            {
                                    
                            }
                            animal_temp[i, j] = new Animal(); //Alapról eltűntetés
                        }
                    }

                    //Róka
                    if (animal[i,j].Type==1) 
                    {
                        int h = animal[i, j].Hunger;
                        animal_temp[i,j] = new Animal(1, h - 1);
                        if (animal[i,j].Hunger==0)
                        {
                            animal_temp[i, j] = new Animal();
                        }
                    }
                }
            }

            animal = animal_temp;
            grass = grass_temp;
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
