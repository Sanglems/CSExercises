using System;

namespace CSExercises
{
    //The C# language gives facilities for changing cases all to upper or lower - 
    //however, not to title case.  Write a program that would convert a given sentence/phrase to title case.
    //Example
    //“institute of systems science”   =>   “Institute Of System Science”

    public class ExG3
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            string newphrase = ToTitleCase(phrase);

            Console.WriteLine(newphrase);
        }

        public static string ToTitleCase(string phrase)
        {
            //YOUR CODE HERE
            string newPhrase = null;
            string[] s = phrase.Split(' ');
            for (int i = 0; i < s.Length; i++)
            {
                int n = s[i].Length;
                string a = s[i].Substring(0, 1);
                string b = s[i].Substring(1, n-1);

                newPhrase = newPhrase + a.ToUpper() + b + " ";
            }
            return newPhrase;


        }
    }
}
