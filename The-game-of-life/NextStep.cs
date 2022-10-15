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
        Point[] spacesNy =  {
            new Point(-1, 0),
            new Point(-1, +1),
            new Point(0, +1),
            new Point(+1, +1),
            new Point(+1, 0),
            new Point(+1, -1),
            new Point(0, -1),
            new Point(-1, -1)
        };
        Point movedToNy = new Point();
        public void Next()
        {
            Random rnd = new Random();
            for (int i = 0; i < MatrixSize.Width; i++)
            {
                for (int j = 0; j < MatrixSize.Height; j++)
                {
                    if (animal[i,j].Type !=2) // Ha nincs rajta nyul
                    {
                        if (grass[i, j].Type !=2) //Csak max fű ig nő
                        {
                            grass[i, j].Type++;

                        }
                    }

                    if (animal[i, j].Type == 2 && animal[i,j].itMoved == false) // Nyuszi és ha nem volt köre
                    {
                        if (grass[i, j].Type != 0) // legkisebnél már nem tud enni
                        {
                            if (grass[i, j].Type == 1) // zsenge fű eszik
                            {
                                if (animal[i, j].Hunger + 1 <= 5) // megtudja enni ? 
                                {
                                    grass[i, j].Type--;
                                    animal[i, j].Hunger += 1; // Hunger + 1
                                }
                            }
                            else if (grass[i, j].Type == 2) // kifejlett fűcsomó eszik
                            {
                                if (animal[i, j].Hunger + 2 <= 5) // megtudja enni ? 
                                {
                                    grass[i, j].Type--;
                                    animal[i, j].Hunger += 2; // Hunger + 2
                                }
                            }
                        }
                        //if () // Szaporodás
                        //{

                        //}
                        movedToNy = new Point(i, j);
                        if (grass[i, j].Type == 0) //ha nincs táplálék a kockán | akkor mozogjon
                        {
                            bool vanE = false; // kifejlett fü csomo van e;
                            List<PointIndex> uresT = new List<PointIndex>();
                            List<PointIndex> grassT2 = new List<PointIndex>();
                            for (int e = 0; e < spacesNy.Length; e++)
                            {
                                try
                                {
                                    if (animal[i + spacesNy[e].X, j + spacesNy[e].Y].Type == 0) // üres 
                                    {
                                        uresT.Add(new PointIndex(spacesNy[e], e));
                                    }
                                    if (grass[i + spacesNy[e].X, j + spacesNy[e].Y].Type == 2 && animal[i + spacesNy[e].X, j + spacesNy[e].Y].Type == 0)
                                    {
                                        vanE = true;
                                        grassT2.Add(new PointIndex(spacesNy[e], e));
                                    }
                                }
                                catch (Exception) { }
                            }
                            if (vanE) // oda mozognak ahol van jó fű Type: 2
                            {
                                List < PointIndex > a = grassT2.FindAll(x=>x.point != new Point()).ToList();
                                int index = a[rnd.Next(0, a.Count)].index;
                                movedToNy = new Point(i + spacesNy[index].X, j + spacesNy[index].Y);
                                MoveNy(new Point(i,j),movedToNy);
                            }
                            else
                            {
                                List<PointIndex> a = uresT.FindAll(x => x.point != new Point()).ToList();
                                Point index = new Point();
                                try
                                {
                                    index = a[rnd.Next(0, a.Count)].point;
                                }
                                catch (Exception)
                                {
                                    index = new Point(0,0);
                                    
                                }
                                movedToNy = new Point(i + index.X, j + index.Y);
                                MoveNy(new Point(i, j), movedToNy);
                            }
                        }
                        if (animal[movedToNy.X, movedToNy.Y].Hunger == 0) //ha 0 akkor meghal
                        {
                            animal[movedToNy.X, movedToNy.Y] = new Animal();
                        }
                        animal[movedToNy.X,movedToNy.Y].Hunger--;
                    }
                }
            }
            for (int i = 0; i < MatrixSize.Width; i++)
            {
                for (int j = 0; j < MatrixSize.Height; j++)
                {
                    if (animal[i, j].Type !=0) // ha állat | azért a animal mer ugyan az a cellára ne tudjanak mozogni
                    {
                        animal[i, j].itMoved = false; // a kör végén mindnkinek visza áll.
                    }
                }
            }
            Iteration++;
        }
        private void MoveNy(Point from, Point to)
        {
            try
            {
                if (animal[to.X, to.Y].Type == 0)
                {
                    (animal[from.X, from.Y], animal[to.X, to.Y]) = (animal[to.X, to.Y], animal[from.X, from.Y]);
                    animal[to.X, to.Y].itMoved = true; // mozgott
                }
            }
            catch (IndexOutOfRangeException) { animal[from.X, from.Y] = new Animal(); movedToNy = new Point(to.X, to.Y); }
            catch (Exception) { movedToNy = new Point(to.X,to.Y); }
        }
        //private bool CanItMove(Point from, Point to)
        //{
        //    var a = animal;
        //    try
        //    {
        //        if (a[to.X, to.Y].Type == 0)
        //        {
        //            (a[from.X, from.Y], a[to.X, to.Y]) = (a[to.X, to.Y], a[from.X, from.Y]);
        //            return true;
        //        }
        //    }
        //    catch (IndexOutOfRangeException) { return true; }
        //    return false;
        //}
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
