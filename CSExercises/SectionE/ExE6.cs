using System;

namespace CSExercises
{
    //Modify the Perfect Number C# program to print out 
    //all the perfect numbers from 1 to 1000.

    public class ExE6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            //Hint: you can use ExE4.IsPerfectNumber() method here
            for (int k=1; k<=1000; k++)
            {
                bool result = ExE4.IsPerfectNumber(k);
                if (result==true)
                {
                    Console.WriteLine(k);
                }

            }


        }
    }
}
