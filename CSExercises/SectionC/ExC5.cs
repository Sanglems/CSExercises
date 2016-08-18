using System;

namespace CSExercises
{
    //Given a three-digit integer as input write a C# program 
    //to determine whether the number is an Armstrong number.
    //
    //An Armstrong number is one for which the sum of each digit 
    //raised to the power of number of digits results in the number itself.
    //
    //For a three digit number 153 =  13 + 53 + 33  
    //
    //Confine the input to 3 digit examples only ie., number values 100…999.


    public class ExC5
    {
        public static void Main(string[] args)
        {
            bool result;
            Console.WriteLine("Enter the 3-digit number");
            int number = Convert.ToInt32(Console.ReadLine());
            if((number < 100) || (number > 999))
            { Console.WriteLine("Input is not three digit number");
            }
            else
            {
                result = IsArmstrongNumber(number);
                Console.WriteLine("{0} is Armstrong number is {1} statement", number, result);

            }
        }


        public static bool IsArmstrongNumber(int n)
        {
        
            int a, b, c;
            a = n % 10;
            b = ((n % 100) - a) / 10;
            c = n / 100;
            if((a*a*a+b*b*b+c*c*c) == n)
            { return true;
            }
            else
            { return false;
            }


        }
    }
}