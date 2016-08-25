using System;

namespace CSExercises
{
    //You are required to take as input an amount (dollar.cents).  
    //Assume that the amount is between 5 cents (inputted as 0.05) and 
    //3 dollars 50 cents (inputted as 3.50).  Further assume that we would 
    //always input nearest to 5 cents (i.e., values like 2.23 are not keyed in).  
    //The duty of your program is to dispense this amount (accurately!) using a combination of 
    //coins.  We have coins of denomination 100, 50, 20, 10 and 5 cents.  More than one coin of 
    //a denomination can be used.  
    //Yeah I know what you are thinking – simply issue all five cent coins; right?  
    //Cannot!- easy but no challenge.  
    //We are requesting the program to use the “minimum number of coins” principle.  
    //For example, if a request were made for 1.95 then the computer would issue one 100-cent coin, 
    //one 50-cent coin, two 20-cent coins and one 5-cent coin.  

    //The trick is to always start with the largest denomination and slowly go down.  
    //Try your luck – but don’t loose money!  

    public class ExI1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount between 0.05 to 3.50");
            double amount = Convert.ToDouble(Console.ReadLine());
            int amountInCents = Convert.ToInt16(100 * amount);
            int hundredCent = 0;
            int fiftyCent = 0;
            int twentyCent = 0;
            int tenCent = 0;
            int fiveCent = 0;
            if(amountInCents>=100)
            {
                hundredCent = amountInCents / 100;
                amountInCents = amountInCents % 100;
            }
            if (amountInCents >= 50)
            {
                fiftyCent = amountInCents / 50;
                amountInCents = amountInCents % 50;
            }
            if (amountInCents >= 20)
            {
                twentyCent = amountInCents / 20;
                amountInCents = amountInCents % 20;
            }
            if (amountInCents >= 10)
            {
                tenCent = amountInCents / 10;
                amountInCents = amountInCents % 10;
            }
            if (amountInCents >= 5)
            {
                fiveCent = amountInCents / 5;
                amountInCents = amountInCents % 5;
            }
            Console.WriteLine("{0:c} : {1} 100-cents, {2} 50-cents, {3} 20-cents, {4} 10-cents and {5} 5-cents ", amount, hundredCent, fiftyCent, twentyCent, tenCent, fiveCent);

        }
    }
}
