namespace Session_Assignment
{
    internal class Program
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool flag;

            for (int i = 0; i < n - 1; i++)
            {
                flag = false;

                // The last i elements are already sorted, so reduce the range
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap adjacent elements if they are in the wrong order
                        Swap(ref arr[j], ref arr[j + 1]);
                        flag = true;  // Mark that a swap occurred
                    }
                }

                // If no elements were swapped, the array is already sorted
                if (!flag)
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
