using System;
using System.Collections.Generic;

namespace Homeworks
{
    internal class Program
    {
        /// <summary>
        /// Створити структуру Студент з прізвищем студента та номером його групи.  
        /// Сформувати і вивести масив з прізвищ студентів заданої групи, що починаються на задану букву.  
        /// Прізвище та номер групи вводяться з консолі.
        /// </summary>

        struct Student
        {
            public string lastname;
            public int group;
        }
        private static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {

            ShowMenu();

           
        }

        private static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("0 - Add Student.");
            Console.WriteLine("1 - Show Students.");
            Console.WriteLine("Students added: {0}", students.Count);
            var input = Console.ReadKey();
            Console.WriteLine("");
            switch (input.KeyChar)
            {
                case '0':
                    AddStudent();
                    break;
                case '1':
                    ShowStudents();
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    ShowMenu();
                    break;
            }
        }
        private static void AddStudent()
        {
            Console.WriteLine("Please enter Last Name");
            string lastname=Console.ReadLine();
            if (!String.IsNullOrEmpty(lastname))
            {
                Console.WriteLine("Please enter Group Number");
                if (Int32.TryParse(Console.ReadLine(), out int group))
                {
                    Student student;
                    student.lastname = lastname;
                    student.group = group;

                    students.Add(student);
                    ShowMenu();
                }
                else
                {
                    Console.WriteLine("Wrong group number. Should be numeric");
                    ShowMenu();
                }
            }
            else
            {
                Console.WriteLine("Please enter Last Name");
                ShowMenu();
            }
        }

        private static void ShowStudents()
        {
            string[] studentsfiltered = SearchStudents();
            if(studentsfiltered != null)
            {
                Console.WriteLine("****STUDENTS*****");
                foreach (string student in studentsfiltered)
                {
                    Console.WriteLine(student);
                }
                Console.WriteLine("*****************");
            }
            ShowMenu();
        }

        private static string[] SearchStudents()
        {
            Console.WriteLine("Please enter first letter of Last Name");
            string lastname = Console.ReadLine();
            if (!String.IsNullOrEmpty(lastname))
            {
                Console.WriteLine("Please enter Group Number");
                if (Int32.TryParse(Console.ReadLine(), out int group))
                {
                    List<Student> studentsfiltered = students.FindAll(x => x.lastname.ToLower().Substring(0, 1) == lastname.ToLower() && x.group == group);
                    if(studentsfiltered.Count > 0)
                    {
                        string[] os=new string[studentsfiltered.Count];
                        for(int i=0;i<os.Length;i++)
                        {
                            os[i] = studentsfiltered[i].lastname;
                        }
                        return os;
                    }
                    else
                    {
                        Console.WriteLine("Not found");
                        return null;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong group number. Should be numeric");
                    return null;
                }
            }
            else
            {
                Console.WriteLine("Please enter Last Name");
                return null;
            }
        }



    }
}
