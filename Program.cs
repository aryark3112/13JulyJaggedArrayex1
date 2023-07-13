using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13july
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conditional Operator (?true case :false case)
            //int num1, num2;
            //Console.WriteLine("Enter First Number");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second Number");
            //num2 = int.Parse(Console.ReadLine());
            //var result = num1 > num2 ? "First Number is greater" : "Second Number is greater";
            //Console.WriteLine(result);
            //Console.ReadKey();


            //Example of nested if
            //using System;
            //class Program
            //{
            //    static void Main()
            //    {
            //        Console.WriteLine("Enter marks in Pre:");
            //        int preMarks = Convert.ToInt32(Console.ReadLine());

            //        if (preMarks > 60)
            //        {
            //            Console.WriteLine("Enter marks in Final:");
            //            int finalMarks = Convert.ToInt32(Console.ReadLine());

            //            if (finalMarks > 55)
            //            {
            //                Console.WriteLine("Result: Selected");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Result: Fail in Final");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Result: Fail in Pre");
            //        }

            //        Console.ReadLine();
            //    }
            //}

            //Array (Single dimensional array)
            //int[] marks =new int[5];
            //Console.WriteLine("Enter Marks");
            //for(int i = 0; i < marks.Length; i++)
            //{
            //    Console.WriteLine("Enter marks in subject" + (i + 1));
            //    marks[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("*Marks List*");
            //for(int i=0; i<marks.Length;i++)
            //{
            //    Console.WriteLine($"Subject {i + 1} \t Marks:{marks[i]}");
            //}
            //Console.ReadKey();

            //another method
            //int[] marks = { 12, 24, 45, 67 };
            //Console.WriteLine("*Marks List*");
            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.WriteLine($"Subject {i + 1} \t Marks:{marks[i]}");
            //}
            //    Console.ReadKey();

            //for each loop
            //Console.WriteLine("Enter Number of Students");
            //int nos = int.Parse(Console.ReadLine());
            //string[] students = new string[nos];
            //for (int i=0;i<nos; i++)
            //{
            //    Console.WriteLine($"Enter Student{i+1}\'s name");
            //    students[i] = Console.ReadLine();
            //}
            //Console.WriteLine("List of Students");
            //foreach (string student in students)
            //{ Console.WriteLine(student); }
            //Console.ReadKey();

            //two dimensional array or rectangular array syntax
            //string[,] myRectArray = new string[4, 3];
            //for (int i = 0; i < myRectArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myRectArray.GetLength(1); j++)
            //    {
            //        myRectArray[i, j] = "[" + i + "," + j + "]";
            //    }
            //}
            //Console.WriteLine("Stored Values are:");
            //for (int i = 0; i < myRectArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myRectArray.GetLength(1); j++)
            //    {
            //        Console.WriteLine(myRectArray[i, j] + "\t");
            //    }
            //    Console.WriteLine("\n");
            //}
            //Console.ReadKey();

            //2 dimensional array example 2
            //int[,] marks = new int[4, 3];
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine($"Enter Student {i + 1} \'s Roll Number");
            //    marks[i, 0] = int.Parse(Console.ReadLine());
            //    for (int j = 1; j < 3; j++)
            //    {
            //        Console.WriteLine($"Enter marks of Student\'s {i + 1} in Sem {j}");
            //        marks[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Marks List as follovs");
            //Console.WriteLine("RollNo\t SemOne\t SemTwo");
            //for (int i = 0; 1 < 4; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(marks[i, j] + "\t");
            //    }
            //    Console.WriteLine("\n");
            //}
            //Console.ReadKey();

            //2 dimensional array example 3
            int[,] studMarks = new int[4, 5];

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter Roll No for student {0}: ", i + 1);
                studMarks[i, 0] = Convert.ToInt32(Console.ReadLine());

                for (int j = 1; j < 5; j++)
                {
                    Console.Write("Enter Sem{0} marks for student {1}: ", j, i + 1);
                    studMarks[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("RollNo\tSem1\tSem2\tSem3\tSem4\tTotal");
            for (int i = 0; i < 4; i++)
            {
                int totalMarks = 0;
                Console.Write(studMarks[i, 0] + "\t");

                for (int j = 1; j < 5; j++)
                {
                    Console.Write(studMarks[i, j] + "\t");
                    totalMarks += studMarks[i, j];
                }

                Console.WriteLine(totalMarks);
            }

            Console.ReadLine();



        }
    }
}
