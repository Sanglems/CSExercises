using System;

namespace CSExercises
{

    //Modify the Prime Number C# program to print out all 
    //the prime numbers from 5 to 10000.


    public class ExE5
    {
        public static void Main(string[] args)
        {
            int i = 0;
            for (int k = 5; k <= 10000; k++)
            {
                int mod = 0;
                for (i = 2; i < k; i++)
                {
                    mod = k % i;
                    if (mod == 0)
                    {
                        break;
                    }
                }
                if (mod !=0)
                {
                    Console.WriteLine(k);
                }
            
                   
                   

                }


            }
    }
}
