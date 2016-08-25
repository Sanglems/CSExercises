using System;

namespace CSExercises
{
    //Write a program for the following:
    //a.Declare an array of dimension 10 (index 0… 9). 
    //b.Generate 50 Random integers in the range 0 … 9.
    //c.Store the number of occurrences(count) in the array appropriately.
    //d.Print a table that would list the numbers and the number of occurrences.

    //Addition:
    //-	Try to print an histogram for the above
    //-	How would the program be affected if the range of numbers randomly generated is between -5 and +5?

    // Sample Output
    // Number Count
    //  0		  4
    //  1		  2
    //  2		  8
    //  3		  6
    //  4		  5
    //  5		  5
    //  6		 11
    //  7		  0
    //  8		  3
    //  9		  6

    //Number	
    //  0	****  
    //  1	**
    //  2	********
    //  3	******
    //  4	*****
    //  5	*****
    //  6	***********
    //  7	
    //  8	***
    //  9	******

    public class ExI2
    {
        public static void Main(string[] args)
        {
            int i;
          int[] baseArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] sampleArray = new int[] { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 ,
                                            2, 1, 2, 3, 4, 5, 6, 7, 8, 9,
                                            3, 1, 2, 3, 4, 5, 6, 7, 8, 9,
                                            4, 1, 2, 3, 4, 5, 6, 7, 8, 9,
                                            5, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Number\t\t\tCount\t\t\tHistogram");
            Console.WriteLine("-----------------------------------------------------------");
            for(i = 0; i< baseArray.Length; i++)
            {
                int count = 0;
                for (int k = 0; k < sampleArray.Length; k++)
                {
                    if (baseArray[i] == sampleArray[k])
                    {
                        count++;
                    }
                }
                    Console.Write("{0}\t\t\t{1}\t\t\t",i, count);
                        for(int l=0; l<count; l++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

        }
    }

