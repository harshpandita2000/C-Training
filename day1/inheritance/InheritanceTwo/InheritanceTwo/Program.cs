using System;

class Employee
{
    public string name;
    public double salary;

    public Employee(string name, double salary)
    {
        this.name = name;
        this.salary = salary;
    }
}

class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    public Developer(string name, double salary, string programmingLanguage) : base(name, salary)
    {
        ProgrammingLanguage = programmingLanguage; 
    }

    
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {name}, Salary: {salary}, Programming Language: {ProgrammingLanguage}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Developer dev = new Developer("Manish", 75000, "C#");
        dev.DisplayDetails();
    }
}
