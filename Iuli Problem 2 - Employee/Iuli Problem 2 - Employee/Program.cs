using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iuli_Problem_2___Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEmployees = int.Parse(Console.ReadLine());
            string staticFirstName = "Ivan";
            string staticLastName;
            string staticEmail;
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                staticLastName = "Petrov" + i;
                staticEmail = string.Format("mail{0}@mail.com", i);
                List <Interests> staticInterests = new List<Interests>();
                staticInterests.Add(new Interests
                {
                    Name = string.Format("Interest{0}", i),
                    Type = string.Format("Type{0}", i),
                    CreatedOn = DateTime.Now
                });
                employees.Add(new Employee
                {
                    FirstName = staticFirstName,
                    LastName = staticLastName,
                    FullName = staticFirstName + " " + staticLastName,
                    Email = staticEmail,
                    ListOfInterests = staticInterests
                });
            }

            foreach (var currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee.FullName);
                Console.WriteLine(currentEmployee.Email);

                foreach (var currentInterest in currentEmployee.ListOfInterests)
                {
                    Console.WriteLine(currentInterest.Name);
                    Console.WriteLine(currentInterest.Type);
                    Console.WriteLine(currentInterest.CreatedOn + "\n");
                }
            }
        }
    }
}
