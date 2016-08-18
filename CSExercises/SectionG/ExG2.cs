using System;

namespace CSExercises
{
    //Write a C# program to determine if a given string is a palindrome.
    //    a.Your program should take a string from the console and test if the word is a palindrome or not using the approach explained by your instructor(you are expected to follow the steps given by the instructor)
    //–	A palindrome is a word/phrase that reads the same forwards or backwards.
    //–	Examples: ABBA, 747, radar, madam

    //b.	Modify the above program to accommodate sentences which may have upper case letters, punctuation or space that may need to be ignored while doing the test.
    //–	Examples:
    //A Santa at NASA
    //Mr.Owl ate my metal worm

    public class ExG2
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();
            bool result = IsPalindrome(phrase);

            if (result)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }

        public static bool IsPalindrome(string phrase)
        {
            string newPhrase = null;
            int n = phrase.Length;
            string phrase1 = phrase.ToLower();
            char[] c = new char[] { '.', ' ' };
            string[] s = phrase1.Split(c);
            for(int i= 0;i<s.Length;i++)
            {
              newPhrase = newPhrase + s[i] ;
            }
            char[] charArray = newPhrase.ToCharArray();
            Array.Reverse(charArray);
            string revPhrase = new string(charArray);


            if (newPhrase.Equals(revPhrase))
            {
                return true;
            }
            else
            {
                return false;
            }






        }
    }
}

