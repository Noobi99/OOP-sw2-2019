using System;
using System.Collections.Generic;
using System.Linq;

namespace Lektion08
{
    public class Opgave3
    {
        public class Person
        {
            public string Name { get; set; }
            public double Weight { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return "Name: " + Name + " Weight: " + Weight + " Age: " + Age;
            }
        }
        
        public void Execute_Opgave()
        {
            List<Person> people = new List<Person>()
            {
                new Person() {Name = "Ib", Weight = 89.6, Age = 27},
                new Person() {Name = "Bob", Weight = 62, Age = 42},
                new Person() {Name = "Søren", Weight = 72, Age = 50},
                new Person() {Name = "Christoffer", Weight = 70.2, Age = 19},
                new Person() {Name = "Torben", Weight = 95.5, Age = 30},
                new Person() { Name = "Anja", Weight = 35.2, Age = 12},
                new Person() { Name = "Andreas", Weight = 200.0, Age = 16}
                
            };
         

            // a
            var orderedA = people
                .OrderBy(p => p.Weight);

            // b
            var orderedB = people
                .OrderByDescending(p => p.Name);
            
            // c
            var orderedC = people
                .Where(p => p.Name.Contains('A') || p.Name.Contains("a"))
                .Where(p => p.Age > 10);
            
            // d
            var orderedD = people
                .Where(p => p.Age < 20 && p.Age > 12)
                .OrderByDescending(p => p.Name.Length);
            
            // e (optional)
            var orderedE = people
                .Where(p => p.Name == "Christoffer");
            
          
            
            
            

            foreach (var man in orderedE)
            {
                Console.WriteLine(man);
            }

        }
    }
}