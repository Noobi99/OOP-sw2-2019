namespace Lektion3Net
{
    /* Opgave 2
    Write a class to represent a person. A person has a name and an age. Write a subclass to
    represent an employee. An employee has a job title and a salary. Write a subclass to represent a
    manager. A manager has bonus which is added on top of his or her base salary. Add appropriate
    constructors for each class.
     */
    
    public class Person
    {
        protected string Name { get; set; }
        protected int Age { get; set; }
        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class Employee : Person
    {
        public string JobTitle;
        public float Salary;
        // Constructor
        public Employee(string name, int age, string jobTitle, float salary) : base(name, age)
        {
            JobTitle = jobTitle;
            Salary = salary;
        }
    }

    public class Manager : Employee
    {
        public float BonusSalary;
        // Constructor
        public Manager(string name, int age, string jobTitle, float salary, float bonusSalary) : base(name, age, jobTitle, salary)
        {
            BonusSalary = bonusSalary;
        }
    }
    
}