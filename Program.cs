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
            //            //Conditional Operator (?true case :false case)
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
            int[] marks =new int[5];
            Console.WriteLine("Enter Marks");
            for(int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Enter marks in subject" + (i + 1));
                marks[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("*Marks List*");
            for(int i=0; i<marks.Length;i++)
            {
                Console.WriteLine($"Subject {i + 1} \t Marks:{marks[i]}");
            }
            Console.ReadKey();
        }
    }
}
