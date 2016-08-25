using System;


namespace CSExercises
{
    public class ExH2
    {
        public static void Main()
        {
            Console.WriteLine("Enter the first string");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter the second string");
            string s2 = Console.ReadLine();
            Console.WriteLine(FindWord(s1, s2));
        }
        //Write a static method: FindWord(string s1, string s2) that would return an integer.  
        //The method should find if the string s2 occurs in s1 and return an integer that would 
        //indicate the starting position of the word s2 in s1.  If the word does not occur 
        //the return value should be –1.

        public static int FindWord(string s1, string s2)
        {
            //YOUR CODE HERE
            int n1 = s1.Length;
            int n2 = s2.Length;
            string s1Lower = s1.ToLower();
            string s2Lower = s2.ToLower();
            int result = -1;
            if (n1 > n2)
            {
                string[] wordsOfS2Length = new string[n1 - n2 + 1];

                {
                    for (int k = 1; k <= (n1 - n2 + 1); k++)
                    {
                        wordsOfS2Length[k] = s1Lower.Substring(k, n2);
                        if (wordsOfS2Length[k] == s2Lower)
                        {
                            result=k;
                            break;
                        }
                       
                    }
                }
            }
            return result;
        }
    }
              
 }


