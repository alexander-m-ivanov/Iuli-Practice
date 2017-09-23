using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iuli_problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string testName = "Gus"; //Console.ReadLine();
            int age = 23;//int.Parse(Console.ReadLine());
            string email = "age@a.al";//Console.ReadLine();

            Person pesho = new Person(testName, age, email);
            Person ivan = new Person("Ivan", 25);

            Console.WriteLine(pesho.ToString());
            Console.WriteLine("\n" + ivan.ToString());

        }
    }
}
