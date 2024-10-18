using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee(int Id,string Name,int Age,double Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.Salary = Salary;
            

        }
    }
}
