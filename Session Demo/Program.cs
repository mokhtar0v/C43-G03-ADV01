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
            Helper.SWAP(ref a, ref b);
            Console.WriteLine($"A = {a}");    
            Console.WriteLine($"B = {b}");    
            double k = 5.5, s = 6.2;
            Console.WriteLine("Before Swaping:-");
            Console.WriteLine($"K = {k}");
            Console.WriteLine($"S = {s}");
            Helper.SWAP(ref k, ref s);
            Console.WriteLine($"K = {k}");
            Console.WriteLine($"S = {s}");
            Point p01 = new Point(10, 20);
            Point p02 = new Point(30, 40);
            Console.WriteLine("Before Swaping:-");
            Console.WriteLine($"Point 01 = {p01}");
            Console.WriteLine($"Point 02 = {p02}");
            Helper.SWAP(ref p01, ref p02);
            Console.WriteLine($"Point 01 = {p01}");
            Console.WriteLine($"Point 02 = {p02}");
            #endregion
        }
    }
}
