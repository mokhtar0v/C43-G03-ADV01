using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_Demo
{
    internal static class Helper
    {
        public static void SWAP(ref int x, ref int y)
        {
        Console.WriteLine("After Swaping: ");
        int temp = x;
        x = y;
        y = temp;
        }
        public static void SWAP(ref double x, ref double y)
        {
        Console.WriteLine("After Swaping: ");
        double temp = x;
        x = y;
        y = temp;
        }
        public static void SWAP(ref Point x, ref Point y)
        {
        Console.WriteLine("After Swaping: ");
        Point temp = x;
        x = y;
        y = temp;
        }
        public static void SWAP<T>(ref T x, ref T y)
        {
            Console.WriteLine("After Swaping:-");
            T temp = x;
            x = y;
            y = temp;
        }
    }
}
