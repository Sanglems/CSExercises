using System;

namespace CSExercises
{
    //A company records its monthly sales information in an array 
    //of size 12; where Sales[0] represents January sales, Sales[1] is 
    //February sales etc.  After entering the data the company wants to 
    //perform some queries on the data.  Write a program that would do the following:

    //a.Take in the sales for the 12 months.
    //  Note: You may use the array initialisation inside the program for storing these.
    //b.Print the month when Maximum Sales is recorded.
    //  Note: You may just print 0, 1 etc.  for Jan Feb etc… 
    //c.Print the month where Minimum Sales is recorded.
    //d.Print the average monthly sales for the year.

    //There are at least two ways to implement this:
    //1. Implement one method that calculate all the required info in one pass
    //2. Implement 3 methods each calculating different thing

    public class ExF1
    {
        public static void Main(string[] args)
        {
            int[] sales = new int[13];
            for (int n = 0; n < 12; n++)
            {
                Console.Write("Enter sales for month {0}: " , n+1);
                sales[n] = Convert.ToInt32(Console.ReadLine());
            }
            
            int max = 0;
            int min = 0;
            double avg = 0;

            CalculateMinMaxAvg(sales, ref min, ref max, ref avg);

            Console.WriteLine("Maximum Sales: " + max);
            Console.WriteLine("Minimum Sales: " + min);
            Console.WriteLine("Average Sales: " + avg);
            Console.WriteLine("Minimum sale occured in {0}th month", CalculateMinMonth(sales));
            Console.WriteLine("Maximumm sale occured in {0}th month", CalculateMaxMonth(sales));
        }

        public static void CalculateMinMaxAvg(int[] sales, ref int minSales, ref int maxSales, ref double avg)
        {
            //YOUR CODE HERE
            //Assign the result to minMonth, maxMonth and avg variable/parameter accordingly
            int minValue = sales[0];
            int maxValue = sales[0];
            double totalValue = 0;

            for(int i = 0; i<12; i++)
            {
                minValue = Math.Min( minValue, sales[i]);

            }
            minSales = minValue;

            for (int i = 0; i <= 12; i++)
            {
                maxValue = Math.Max(maxValue, sales[i]);
            }
            maxSales = maxValue;

            for (int i = 0; i <= 12; i++)
            {
                totalValue = totalValue + sales[i];
            }
            avg = totalValue/12;


        }

        public static int CalculateMinMonth(int[] sales)
        {
            //YOUR CODE HERE
            int k;
            int minValue = sales[0];
            for (int i = 0; i < 12; i++)
            {
                minValue = Math.Min(minValue, sales[i]);

            }

            for(k = 0; k<12; k++)
            {
                if (minValue == sales[k])
                    break;
            }
                return k+1;

        }

        public static int CalculateMaxMonth(int[] sales)
        {
            int k;
            int maxValue = sales[0];
            for (int i = 0; i <= 12; i++)
            {
                maxValue = Math.Max(maxValue, sales[i]);
            }

            for (k = 0; k < 12; k++)
            {
                if (maxValue == sales[k])
                    break;
            }
            return k+1; 
            
        }

        public static double CalculateAvgSales(int[] sales)
        {
            //YOUR CODE HERE
            return 0;

        }


    }
}
