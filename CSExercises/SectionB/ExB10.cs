using System;

namespace CSExercises
{
    public class ExB10
    {
        //Consider the simple Geometric example of determining 
        //the area of a triangle, given the lengths of 
        //    its three sides a, b and c.
        //
        //Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)]
        //                     where s = (a+b+c) / 2
        //
        //Does your program always work? If not 
        //alter it to consider situations fro which 
        //it fails.You can return a special value like -1 to 
        //indicate that you cannot calculate the area.


        public static void Main(string[] args)
        {
            Console.WriteLine("Enter firts side of triange");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second side of triange");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third side of triange");
            double c = Convert.ToDouble(Console.ReadLine());
            double Area = CalculateArea(a, b, c);
            if (Area== -1)
               {
                Console.WriteLine("Sides enterd do not represent a triangle");
                }
            else
               {
                Console.WriteLine("Area of triangle is {0}", Area);
               }

        }

        public static double CalculateArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double y = s * (s - a) * (s - b) * (s - c);

            if (y < 0)
                return -1;
            else
            {
                double area = Math.Sqrt(y);
                return area;
            }
        }
    }
}