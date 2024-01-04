using System.Threading.Channels;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            //declare jagged array
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];


            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            //another way to intialize a jagged array
            int[][] jaggedArray2 = new int[][] {
                new int[] {2,3,5,7,11 },
                new int[] {1,2,3 },
                new int[] {13,21}
            };

            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.Write("Array " + (i + 1) + ": ");
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.Write(jaggedArray2[i][j] + " ");
                }

                Console.WriteLine("");
            }

        }
    }

}
