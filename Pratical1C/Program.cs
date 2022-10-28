using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratical1C
{
    struct Student
    {
        public int sid;
        public string sname;
        public string cname;
        public int dd,mm,yy;
        public void Display()
        {
            Console.WriteLine("Student Id " + sid);
            Console.WriteLine("Student Name " + sname);
            Console.WriteLine("Course Name " + cname);
            Console.WriteLine("Date of Birth {0}/{1}/{2}",dd,mm,yy);

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students information you want to accept ");
            int  n = int.Parse(Console.ReadLine());
            Student[] allstudents = new Student[n];
            for(int i = 0; i < n; i++)
            {
                allstudents[i] = new Student();
                Console.Write("Enter Student Id ");
                allstudents[i].sid = int.Parse(Console.ReadLine());
                Console.Write("Enter student name ");
                allstudents[i].sname = Console.ReadLine();
                Console.Write("Enter course name ");
                allstudents[i].cname = Console.ReadLine();
                Console.Write("Enter Day ");
                allstudents[i].dd = int.Parse(Console.ReadLine());
                Console.Write("Enter Month ");
                allstudents[i].mm = int.Parse(Console.ReadLine());
                Console.Write("Enter Year ");
                allstudents[i].yy = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("****** Accepted Student Info ******");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("======================");
                allstudents[i].Display();
                Console.WriteLine("======================");
            }
            Console.ReadKey();
        }
    }
}
