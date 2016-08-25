using System;

namespace CSExercises
{
    //Write a static method:  Substitute(string s, char c1, char c2) that would 
    //return a string. The method should find all occurrences of the character c1 
    //in the string s and substitute c1 with character c2.  The new word so formed would 
    //be the return value of this method.
    public class ExH4
    {
        public static void Main()
    {
        Console.WriteLine("enter the string");
        string s = Console.ReadLine();
        Console.WriteLine("enter the character to be replaced");
        char c1 = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("enter the character to be placed");
        char c2 = Convert.ToChar(Console.ReadLine());
        string outString = Substitute(s, c1, c2);
        Console.WriteLine(outString);

    }
    
        public static string Substitute(string s, char c1, char c2)
        {
            //YOUR CODE HERE
            char[] charStringArray = s.ToCharArray();
            for(int i = 0; i< s.Length; i++)
            {
                if(charStringArray[i]==c1)
                {
                    charStringArray[i] = c2;
                }
            }
            string outString = new string (charStringArray);
            return outString;
        }
    }
}
