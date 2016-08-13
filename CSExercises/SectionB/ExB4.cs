using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would convert temperature given in Centigrade 
    //scale to Fahrenheit – the number can be integer or real.  Use the formula:
    //	F = 1.8C  + 32

    public class ExB4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in Centigrade");
            string input = Console.ReadLine();
            double inputInCentigrade = Convert.ToDouble(input);
            double outputInFarehneit = ConvertToFahrenheit(inputInCentigrade);
            Console.WriteLine("{0} degree on Centigrade scale is equal to {1} on Farehneit scale",inputInCentigrade,outputInFarehneit);

        }

        public static double ConvertToFahrenheit(double c)
        {
            double f = 1.8 * c + 32;
            return f;

        }
    }
}
