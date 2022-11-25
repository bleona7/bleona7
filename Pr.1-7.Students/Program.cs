using System;
using System.Collections.Generic;
using System.Text;

namespace Pr._1_7.Students
{
   
    class Program
    {
        static List<Student> students = new List<Student>();
        static StringBuilder result = new StringBuilder();
        static void Main(string[] args)
        {
            StartTesting();
            PrintOutput();
        }

        static void StartTesting()
        {

            string line = Console.ReadLine();
            while (line != "End.")
            {
                string[] separators = { ",", "(", ")" };
                string[] expectedComand = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < expectedComand.Length; i++)
                {
                    expectedComand[i] = expectedComand[i].Trim();
                }
                ComandExecutes(expectedComand);
                line = Console.ReadLine();
            }
        }

        private static void ComandExecutes(string[] expectedComand)
        {
            switch (expectedComand[0])
            {
                case "AddStudent":
                    {
                        if (expectedComand.Length == 3)
                        {
                            students.Add(new Student(expectedComand[1], expectedComand[2]));
                            result.Append("Student added." + System.Environment.NewLine);
                        }
                        if (expectedComand.Length == 4)
                        {
                            students.Add(new Student(expectedComand[1], expectedComand[2], expectedComand[3]));
                            result.Append("Student added." + System.Environment.NewLine);
                        }
                        if (expectedComand.Length == 10)
                        {
                            students.Add(new Student(expectedComand[1], expectedComand[2], expectedComand[3],
                                int.Parse(expectedComand[4]), expectedComand[5],
                                expectedComand[6], expectedComand[7], expectedComand[8]));
                            result.Append("Student added." + System.Environment.NewLine);
                        }
                        break;
                    }
                case "PrintNumberOfStudents":
                    {
                        result.Append(Student.NumberOfStudents + System.Environment.NewLine);
                        break;
                    }
                case "PrintStudentsInfo":
                    {
                        foreach (var item in students)
                        {
                            result.Append(item.ToString() + System.Environment.NewLine);
                        }
                        break;
                    }
                default:
                    {
                        result.Append("Invalid Comand.");
                        break;
                    }

            }
        }

        static void ReadInput()
        {
            string line = Console.ReadLine();
            while (line != "End.")
            {
                string[] separators = { ",", "(", ")" };
                string[] expectedComand = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);


                line = Console.ReadLine();
            }
        }

        static void PrintOutput()
        {
            Console.WriteLine(result);
        }
    }
}
