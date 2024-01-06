using System.Threading.Channels;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[] sum1 = new int[] { 1001, 5, 2, 34, -675, 23, 3, 1, 2345, 5 };
            int[] sum2 = new int[] { 3, 1, 99 };
            int[] sum3 = new int[] { 58, 2, 89, 23, 344, 345, 65, -6, 53, 4, 34, 35, 5, 65, 65, 34, 3, 5, 4 };

            Console.WriteLine("The min value of the first array is " + Min(sum1));
            Console.WriteLine("The min value of the first array is " + Min(sum2));
            Console.WriteLine("The min value of the first array is " + Min(sum3));

        }
        public static int Min(params int[] numbers)
        {
            int min = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }
    }

}
