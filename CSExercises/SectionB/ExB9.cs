using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance travelled in Km");
            string input = Console.ReadLine();
            double distanceTravelled = Convert.ToDouble(input);
            double fare = CalculateFare(distanceTravelled);
            Console.WriteLine("The total fare is ${0:0.0}", fare);
        }

        public static double CalculateFare(double distance)
        {
            double output = 2.40 + distance * 0.4;
            double output1 = Math.Ceiling(10 * output);
            double fare = output1 / 10;
           
            return fare;

        }
    }
}
