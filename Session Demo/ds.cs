using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_Demo
{
    internal class EmpEqComID : IEqualityComparer<Employee>
    {

        public bool Equals(Employee? x, Employee? y)
        {
            return x?.Id == y?.Id;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
           return HashCode.Combine(obj.Id);
        }
    }
    internal class EmpEqComName : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x?.Name == y?.Name;
        }
        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.Name);
        }
    }
    internal class EmpEqComSalary : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x.Salary == y.Salary;
        }
        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.Salary);
        }
    }
}
