using System;

namespace CSExercises
{
    //The marks obtained by five students in Programming course are as below:
    //  Name        Mark
    //  John	    63
    //  Venkat	    29
    //  Mary	    75
    //  Victor	    82
    //  Betty	    55

    //Write a program that would take store the above information in two arrays(one for Name and one for Marks.The program would then print two reports:

    //c.First report sorted in descending order of the Marks (i.e.student rank)
    //d.Second report sorted on student names alphabetically.

    public class ExG4
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            string[] name = new string[] { "john", "Venkat", "Mary", "Victor", "Betty" };
            int[] marks = new int[] { 63, 29, 75, 82, 55 };

            //string[] newName = new string[name.Length];
            //int[] newMarks = new int[marks.Length];
            PrintReportAsMarksDescendingOrder(name, marks);
            //Console.WriteLine("The report sorted in descending order of marks:");
            //Console.WriteLine("Name\t\tMarks");
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(newName[i] + "\t\t" + newMarks[i]);
            //}

            
            PrintReportInAlphabeticalOrder(name, marks );






        }

        public static void PrintReportAsMarksDescendingOrder(string[] name, int[] marks) /* out string[] newName, out int[] newMarks*/
        {
            for (int i = 0; i < marks.Length - 1; i++)
            {
                for (int k = i + 1; k < marks.Length; k++)
                {
                    if (marks[k] > marks[i])
                    {
                        int temp = marks[i];
                        marks[i] = marks[k];
                        marks[k] = temp;
                        string temp1 = name[i];
                        name[i] = name[k];
                        name[k] = temp1;
                    }
                }
            }
            string[] newName = name;
            int[] newMarks = marks;
            Console.WriteLine("The report sorted in descending order of marks:");
            Console.WriteLine("Name\t\tMarks");
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(newName[i] + "\t\t" + newMarks[i]);
            }

        }

        public static void PrintReportInAlphabeticalOrder(string[]name, int[]marks )
        {
            for (int i = 0; i < marks.Length - 1; i++)
            {
                for (int k = i + 1; k < marks.Length; k++)
                {
                    if (name[k].CompareTo(name[i])<0)
                    {
                        string temp1 = name[i];
                        name[i] = name[k];
                        name[k] = temp1;
                        int temp = marks[i];
                        marks[i] = marks[k];
                        marks[k] = temp;
                        
                    }
                }
            }
            string[] newName = name;
            int[] newMarks = marks;
            Console.WriteLine("The report sorted in alphabetical order of names:");
            Console.WriteLine("Name\t\tMarks");
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(newName[i] + "\t\t" + newMarks[i]);
            }

        }
    }
}

        