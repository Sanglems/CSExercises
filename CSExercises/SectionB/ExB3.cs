using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //The ABC Company pays its employees salary plus benefits.  
    //The benefits are calculated as a percentage of the salary.  
    //The company pays every employee 10% housing allowance and 
    //3% transport allowance.  Write a program that takes the salary 
    //as input and prints the total income 
    //(salary + housing allowance + transport allowance) as output.  
    //Format the output in currency format.

    public class ExB3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the salary in dollsars");
            string input = Console.ReadLine();
            double salary = Convert.ToDouble(input);
            double income = CalculateIncome(salary);
            Console.WriteLine("The total income is {0:c}",income);



        }

        public static double CalculateIncome(double salaryStr)
        { 
            double income = 1.13 * salaryStr;
            return income;
        }
    }
}
