using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("Pres 1. To Add an Employee");
                Console.WriteLine("press 2. Display Employee");
                Console.WriteLine("press 3. Exit");
                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Employee Name");
                        Employee_name = new Employee_name (Console.ReadLine());
                }
            }
                


        }

        private string firstName, lastName, job, gender;
        private int salary, age, tax;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Job
        {
            get
            {
                return job;
            }
            set
            {
                job = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public int Tax
        {
            get
            {
                return tax;
            }
            set
            {
                tax = value;
            }
        }

        public Employee(string _firstName , string _lastName , string _job, string _)

    }   
        static void Main(string[] args)
        {
        }

    
}
