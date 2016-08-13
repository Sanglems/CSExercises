using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would take as input the 
    //value of x and calculate & output the value 
    //of y using the formula:
 	// y = 5 x2 – 4 x + 3

    public class ExB5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of x");
            string input = Console.ReadLine();
            double x = Convert.ToDouble(input);
            double y = CalculateY(x);
            Console.WriteLine("y = {0}", y);
        }

        public static double CalculateY(double x)
        {
            double y = 5 * x * x - 4 * x + 3;
            return y;
        }
    }
}
