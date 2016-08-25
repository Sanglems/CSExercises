using System;



namespace CSExercises
{
    class ExH1
    {
        public static void Main()
        {
            Console.WriteLine("Enter the first string");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter the second string");
            string s2 = Console.ReadLine();
            Console.WriteLine(InString(s1, s2));
        }

        public static bool InString(string s1, string s2)
        {
            //YOUR CODE HERE
            int n1 = s1.Length;
            int n2 = s2.Length;
            string s1Lower = s1.ToLower();
            string s2Lower = s2.ToLower();

            //string wOSpace = null;
            bool result = false;
            if (n1 > n2)
            {
                //string[] newString = s1.Split(' ');
                //for (int i = 0; i < newString.Length; i++)
                //{
                //    wOSpace = wOSpace + newString[i];
                //}

                string[] wordsOfS2Length = new string[n1 - n2 + 1];

                {
                    for (int k = 0; k < n1 - n2 + 1; k++)
                    {
                        wordsOfS2Length[k] = s1Lower.Substring(k, n2);
                        if (wordsOfS2Length[k] == s2Lower)
                        {
                            result = true;
                            break;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                }
            }
            return result;
        }
    }
}
