using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Lektion3Net
{
    internal class Program
    {
        public abstract class Figur
        {
            public virtual int Area()
            {
                return 42;
            }
        }

        public class Trekant : Figur
        {
            
        }
        
        public class Person
        {
            protected string _name;
            protected int _age;
            public string _testMedPublic;
            private string _testMedPrivate;

            public virtual void PrintName()
            {
                Console.WriteLine(_name);
            }
            
            public virtual void PrintAge()
            {
                Console.WriteLine(_age);
            }

        }

        public class Employee : Person
        {
            private string _jobTitle;
            private float _salary;

         
            public string Test
            {
                get => _testMedPublic;
                set => _testMedPublic = value;
            }
            
            public string JobTitle
            {
                get => _jobTitle;
                set => _jobTitle = value;
            }

            public float Salary
            {
                get => _salary;
                set => _salary = value;
            }


            public Employee(string name, int age, string jobTitle, float salary)
            {
                _name = name;
                _age = age;
                JobTitle = jobTitle;
                Salary = salary;
            }
        }

        public class Manager : Employee
        {
            private float _bonusSalary;

            public float BonusSalary
            {
                get => _bonusSalary;
                set => _bonusSalary = value;
            }

            public Manager(string name, int age, string jobTitle, float salary, float bonusSalary) : base(name, age, jobTitle, salary)
            {
                JobTitle = jobTitle;
                Salary = salary;
                BonusSalary = bonusSalary;
            }
        }
            
        
        
        public static void Main(string[] args)
        {
            string test = "hello";
            var result = test.Equals("hello");
            
            /*
            var manager = new Manager("Christoffer", 19, "McDonalds Manager", 19000, 3000);
            Console.WriteLine(manager.JobTitle);
            manager.PrintName();
            manager.PrintAge();

            
            // Eksempel på en abstract class
            Figur fig = new Trekant();
            */
            
            // Opgave 2 - bruger klasse Person.cs
            var employee = new Lektion3Net.Employee("Christoffer", 19, "Student", 5600);
            var manager = new Lektion3Net.Manager("Christoffer", 19, "Super Student", 5600, 2000);

            Console.WriteLine(employee.Name);
            
            // Opgave 3 - Parking meter
            
        }
    }
}