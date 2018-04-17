using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Prog2ProjectTravelingSaleman
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TestSolution anArray = new TestSolution();
            char[] points = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
            Console.WriteLine(points);
            Console.ReadLine();
            Console.WriteLine(anArray.Shuffle(points));
            Console.WriteLine(anArray.Distance(points));
            


            Console.ReadLine();





        }
    }
}
