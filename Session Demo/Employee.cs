using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_Demo
{
    internal struct Employee
    {
        public Employee() { }
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Employee(int Id, string Name, decimal Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Salary = Salary;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object? obj)
        {
            //Employee? other = (Employee?)obj; //Explicit Castin: Unsafe Casting
            /// 1. Is operator
            ///if (obj is Employee other)  //Safe using is
            ///{
            ///    return (this.Id.Equals(other?.Id)) && (this.Name?.Equals(other.Name) ?? (other.Name == null ? true : false)) && (this.Salary.Equals(other.Salary));
            ///}
            ///return false;
            /// 2. As operator
            ///Employee? other = obj as Employee;
            ///if (other == null) 
            ///{
            ///    //return (this.Id.Equals(other?.Id)) && (this.Name?.Equals(other.Name) ?? (other.Name == null ? true : false)) && (this.Salary.Equals(other.Salary));
            ///}
            ///Employee? other;
            ///other = (Employee?) obj;  //Unsafe
            ///if (other == null) return false;
            ///
            ///return (this.Id.Equals(other?.Id)) && (this.Name?.Equals(other.Name) ?? (other.Name == null? true: false))&& (this.Salary.Equals(other.Salary));this.Salary.Equals(other.Salary));
        }
    }
}
