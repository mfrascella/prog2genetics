using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Prog2ProjectTravelingSaleman
{
    public class TestSolution
    {
        //array of chars
        private static Random rng = new Random();
        private char[] points = {'a', 'b', 'c', 'e', 'f', 'g', 'h', 'i', 'j'}; //ascii 97-106
        
        

        //values shuffle from housing
        public char[] Shuffle(char[] anArray)
        {
            int counter = anArray.Length - 1;

            while (counter > 2)
            {
                counter--;
                int index = rng.Next(1, counter);
                char value = anArray[index];
                anArray[index] = anArray[counter];
                anArray[counter] = value;
            }

            return anArray;
        }
        


        //reads the position of the array and subtracts the ascii character*
        //need to add it to the score somehow
        public double Distance(char[] points)
        {
            double score = 0; //total distanced traveled
            int counter = 0;
            double distance = 0;
           

            while (counter < points.Length - 1)
            {
                //Console.WriteLine(points[counter]);
                //Console.ReadLine();

                distance = Math.Abs(points[counter] - points[counter + 1]);
                score += distance;


                counter++;

            }


            return score;
        }
        





        //use ascii character vaules
        //randomize point generation
        //rank calculated point distances by smallest to greatest
        //start to mix up top points


        public TestSolution(int x)
        {

        }

        
        public TestSolution()
        {
            this.points = this.Shuffle(points);
            
        }






















    }
}
