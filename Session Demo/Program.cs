namespace Session_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generic Ex01
            int a = 5, b = 6;
            Console.WriteLine("Before Swaping:-");
            Console.WriteLine($"A = {a}");    
            Console.WriteLine($"B = {b}");
            //Helper.SWAP(ref a, ref b);
            Console.WriteLine($"A = {a}");    
            Console.WriteLine($"B = {b}");    
            double k = 5.5, s = 6.2;
            Console.WriteLine("Before Swaping:-");
            Console.WriteLine($"K = {k}");
            Console.WriteLine($"S = {s}");
            //Helper.SWAP(ref k, ref s);
            Console.WriteLine($"K = {k}");
            Console.WriteLine($"S = {s}");
            Point p01 = new Point(10, 20);
            Point p02 = new Point(30, 40);
            Console.WriteLine("Before Swaping:-");
            Console.WriteLine($"Point 01 = {p01}");
            Console.WriteLine($"Point 02 = {p02}");
            //Helper.SWAP(ref p01, ref p02);
            Console.WriteLine($"Point 01 = {p01}");
            Console.WriteLine($"Point 02 = {p02}");
            #endregion

            #region Generic Ex02
            int[] nums = { 10, 2, 8, 4, 9, 1, 5, 3, 7, 6 };
            int res = Helper<int>.LinearSearch(nums, 7);
            Console.WriteLine($"The number is in index: {res}");
            Employee emp01 = new Employee() { Id = 10, Name = "Ahmed", Salary = 5000 };
            Employee emp02 = new Employee() { Id = 20, Name = "Ahmed", Salary = 3000 };
            if (emp01.Equals(emp02)) Console.WriteLine("Equals");
            //if (emp01 == emp02) Console.WriteLine("Equals");
            else Console.WriteLine("Not Equals");
            #endregion

            #region Equality and GetHashCode
            //Employee emp01 = new Employee(10, "Ali", 5000);
            //Employee emp02 = new Employee(10, "Ali", 5000);
            //Console.WriteLine($"Emp01.GetHashCode(): {emp01.GetHashCode()}");
            //Console.WriteLine($"Emp02.GetHashCode(): {emp02.GetHashCode()}");
            ///if (emp01 == emp02)  //Compare ref based on equality
            ///if (emp01.Equals(emp02)) //Compare value based on equality
            ///{
            ///    Console.WriteLine("Equals");
            ///}
            ///else
            ///{
            ///    Console.WriteLine("Not Equals");
            ///}
            ///HashSet<Employee> emps = new HashSet<Employee>();
            ///emps.Add(emp01);
            ///emps.Add(emp02);
            ///foreach (Employee e in emps)
            ///    Console.WriteLine(e);

            #endregion

            #region Is and As Operators
            //Employee[] emps =
            //{
            //    new Employee() {Id = 10, Name = "Ahmed", Salary = 9000},
            //    new Employee() {Id = 20, Name = "Ali", Salary = 2000},
            //    new Employee() {Id = 7, Name = "Omar", Salary = 12000},
            //    new Employee() {Id = 13, Name = "HH", Salary = 100}
            //};
            //
            //int indax = Helper<Employee>.LinearSearch(emps, new Employee() { Id = 7, Name = "Ali", Salary = 12000 });
            //Console.WriteLine($"Employee in index: {indax}");
            #endregion

            #region IEqualityComparer
            //Employee[] emps =
            //{
            //    new Employee() {Id = 10, Name = "Ahmed", Salary = 9000},
            //    new Employee() {Id = 20, Name = "Ali", Salary = 2000},
            //    new Employee() {Id = 7, Name = "Omar", Salary = 12000},
            //    new Employee() {Id = 13, Name = "HH", Salary = 100}
            //};

            //int indax = Helper<Employee>.LinearSearch(emps, new Employee() { Name = "Ali" }, new EmpEqComName());
            //Console.WriteLine($"Employee in index: {indax}");
            #endregion

            #region Delegate
            //Employee[] emps =
            //{
            //    new Employee() {Id = 10, Name = "Ahmed", Salary = 9000},
            //    new Employee() {Id = 20, Name = "Ali", Salary = 2000},
            //    new Employee() {Id = 7, Name = "Omar", Salary = 12000},
            //    new Employee() {Id = 13, Name = "HHH", Salary = 100}
            //};

            //int indax = Helper<Employee>.LinearSearch(emps, new Employee() { Name = "Omar" }, delegate (Employee X, Employee Y) { return X.Name == Y.Name; });
            //Console.WriteLine($"Employee in index: {indax}");
            #endregion
        }
    }
}
