using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_Demo
{
    internal struct Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public override bool Equals(object? obj)
        {
            Employee other = (Employee)obj; //Unsaafe casting
            return this.Id == other.Id && this.Name == other.Name && this.Salary == other.Salary;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(this.Id, this.Name, this.Salary);
        }
    }
}
