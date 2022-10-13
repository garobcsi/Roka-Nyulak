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
        public Animal[,] animal;
        public Grass[,] grass;
        public int i = 0; // ha példát megnéztétek ezt a sort TÖRÖLNI !
        public void Next()
        {
            #region CSAK EGY PÉLDA !
            try // az elötte lévöt törli
            {
                animal[i - 1, 0] = new Animal(); 
            }
            catch (Exception)
            {

                
            }
            try
            {
                animal[i, 0] = new Animal(1,10,new Point(i+1,1));

            }
            catch (Exception)
            {

                throw new IndexOutOfRangeException(); // index határain kivül van !
            }
            i++;
            #endregion
            //animal[0,0].Type  //
            //animal[0,0].Hunger//
            //animal[0,0].Cords //
            // Igy lehet az iformációkat lekérdezni INDEXEL
            //grass[0,0].Type   //
            //grass[0,0].Cords  //

            //animal[0,0] = new Animal(1,10,new Point(1,1)); // igy lehet majd megandi az információt (Type,Hunger = starting hunger,és Pozició)  !!(! A pozició elvan tolva egyel !) A 0,0 Pozició az INVALID !! (Mátrixnál 0,0 valós index)
            //grass[1,0] = new Grass(1,new Point(2,1)); // (Type,Pozicó) | A tipusokat majd a classok ba lehet látni az enumba

            //animal[0,0] = new Animal(); // igy lehet visza állitani alapokra az infot //PL: ez azért fontos mer 2 mátrixal dolgozunk és ha nyuszi megeszi a füvet. A fü allata visza áll az alapértékre
            //grass[0,0] = new Grass(); // ugyan ez az állatnál //PL: nyuszi meghal (Hunger == 0) akkor visza áll az alapra

            //a user nek a mátrix kiirása már kész igy azt nem kell megirnotok
            //A ContinouosNext() már kész !
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
