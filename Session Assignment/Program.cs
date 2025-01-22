namespace Session_Assignment
{
    internal class Program
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool flag;

            for (int i = 0; i < n - 1; i++)
            {
                flag = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        flag = true;  // Mark that a swap occurred
                    }
                }
                if (!flag)
                    break;
            }
        }
        public static void ReverseInPlace(ArrayList list)
        {
            int left = 0, right = list.Count - 1;
            while (left < right)
            {
                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }
        static void Main(string[] args)
        {
            #region Qeustion01
            //int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            //Console.WriteLine("Before Sort:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //BubbleSort(arr);

            //Console.WriteLine("After Sort:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //} 
            #endregion

            #region Question02
            //Range <int> intRange = new Range<int>(10, 50);
            //Console.WriteLine(intRange.IsInRange(30)); 
            //Console.WriteLine(intRange.Length()); 

            //Range <double> doubleRange = new Range<double>(5.5, 10.2);
            //Console.WriteLine(doubleRange.IsInRange(7.8));
            //Console.WriteLine(doubleRange.Length());
            #endregion

            #region Question03
            ArrayList list = new ArrayList { 1, 2, 3, 4, 5 };
            for (int i = 0; i < list.length; ++i)
            {
                Console.Writeline(list[i]);
            }

            ReverseInPlace(arrayList);

            Console.WriteLine("Reversed ArrayList:");
            for (int i = 0; i < list.length; ++i)
            {
                Console.WriteLine(list[i]);
            }
            #endregion
        }
    }
}
