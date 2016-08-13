using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Slight modification to above: Write a program that 
    //takes a double precision number as input and prints 
    //the square root of the number.  
    //The square root should be rounded to 3 decimal places.
    //Input	    Output
    //0	        0.000
    //25	    5
    //3	        1.732
    //300	    17.321

    public class ExB2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            string input = Console.ReadLine();
            double input1 = Convert.ToDouble(input);
            double result = SQRT(input1);
            Console.WriteLine("Square root of {0} is {1:0.000}", input1, result);
        }

        public static double SQRT(double x)
        {
            double result = Math.Sqrt(x);
            return result;

        }
    }
}
