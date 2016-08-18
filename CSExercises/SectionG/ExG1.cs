using System;
using System.Linq;

namespace CSExercises
{
    //Program to count the number of vowels in a given phrase and print out 
    //the number of each vowel. (a, e, i, o & u are vowels)
    //a.Write a program to read a phrase from the console and count the number 
    //of vowels there are in the phrase.You should substring one character at a time and 
    //match it to the vowels and increment the counter.
    //b.Make your program explicitly count the number of occurrences of each vowel 
    //ie: number of a’s, number of e’s etc.)

    public class ExG1
    {
        static string[] vowels = { "a", "e", "i", "o", "u" };

        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();
            int CounterVowels1 = CountVowels(phrase);

            Console.WriteLine("Total number of vowels: " + CounterVowels1);

            int[] vowelCount = CountIndividualVowels(phrase);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Number of {0}: {1}", vowels[i], vowelCount[i]);
            }
        }

        public static int CountVowels(string phrase)
        {
            int n = phrase.Length;
            string phrase1 = phrase.ToLower();
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                string r = phrase1.Substring(i, 1);

                if ((r.Equals("a")) || (r.Equals("e")) || (r.Equals("i")) || (r.Equals("o")) || (r.Equals("u")))
                {
                    counter++;
                }

            }
            return counter;


        }

        public static int[] CountIndividualVowels(string phrase)
        {
            int[] vowelCount = new int[5];
            vowelCount[0] = 0;
            vowelCount[1] = 0;
            vowelCount[2] = 0;
            vowelCount[3] = 0;
            vowelCount[4] = 0;

            int n = phrase.Length;
            string phrase1 = phrase.ToLower();

            for (int k = 0; k < 5; k++)
            {

                for (int i = 0; i < n; i++)
                {
                    string r = phrase1.Substring(i, 1);

                    if (r.Equals(vowels[k]))
                    {
                        vowelCount[k]++;
                    }
                }
                    
                }
            return vowelCount;
        }
        }
    }
