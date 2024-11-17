using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class student
    {
        public int id;
        public string name;
        public int mark;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("numbe of students:");
            Console.WriteLine("most be 5 to 10");
            int c = int.Parse(Console.ReadLine());
            if (c >= 5 && c <= 10)
            {
                List<student> list = new List<student>();
                for (int i = 0; i < c; i++)
                {
                    student studdent = new student();
                    Console.WriteLine("name of student");
                    string name = Console.ReadLine();
                    Console.WriteLine("id of student");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("mark of student");
                    int mark = int.Parse(Console.ReadLine());
                    studdent.name = name;
                    studdent.id = id;
                    studdent.mark = mark;
                    list.Add(studdent);

                }
                bool found = false;
                Console.WriteLine("student how pass is:");
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].mark > 49)
                    {
                        found = true;
                        Console.WriteLine("name student:" + list[i].name);
                        Console.WriteLine("id of student" + list[i].id);
                    }
                }
                if (!found)
                    Console.WriteLine("no pass:");
                else
                    Console.WriteLine("the number of student must be from 5 to 10");
                Console.ReadLine();
            }
        }
    }
}
