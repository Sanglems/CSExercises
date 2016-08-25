using System;

namespace CSExercises
{
    public class ExH3
    {
        //Write a function (static method) that would take in an integer and 
        //return the hexadecimal.  Print out the Hex of all numbers 1 to 100 and 
        //compare your answer with that of the built in function.

            public static void Main()
        {
            
            string hexValue;
            for(int i = 1; i<=100; i++)
            {
                hexValue = Hex(i);
                Console.WriteLine("{0} decimal is {1} Hexadecimal", i, hexValue);
            }
        }
        public static string Hex(int i)
        { string output=null;
          int digit;
            //YOUR CODE HERE
            do
            {
                digit = i % 16;
                i = i / 16;
                if (digit < 10)
                {
                    output = Convert.ToString(digit) + output;
                }
                else
                {
                    if (digit == 10) { output = 'A' + output; }
                    if (digit == 11) { output = 'B' + output; }
                    if (digit == 12) { output = 'C' + output; }
                    if (digit == 13) { output = 'D' + output; }
                    if (digit == 14) { output = 'E' + output; }
                    if (digit == 15) { output = 'F' + output; }
                }


            } while (i != 0);
            return output;






        }
    }
}
