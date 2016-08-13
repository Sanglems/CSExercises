using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company example before, 
    //print the output so that the fare is the 
    //output is printed always rounded to nearest 10 cents 
    //and printed to two decimal places.

    public class ExB8
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance travelled in Km");
            string input = Console.ReadLine();
            double distanceTravelled = Convert.ToDouble(input);
            double fare = CalculateFare(distanceTravelled);
            Console.WriteLine("The total fare is$ {0:0.0}", fare);
        }

        public static double CalculateFare(double distance)
        {
            double fare = 2.40 + distance * 0.4;
            return fare;

        }
    }
}
