using System.Threading.Channels;

namespace Collections
{
    internal class Program
    {
        static int[,] matrix = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 4, 7,8 },
            { 1, 2, 3,4}
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Here is the orignal array");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine("");
            }

            //first row would be 0,0
            //second row would be 1,1
            //third row would be 2,2
            Console.WriteLine("\nThis will print the diagonals from Top Left To Bottom Right");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine("");
            }

            //first one we want 0,2
            //seconnd one we want 1,1
            //last one we want 2,0
            Console.WriteLine("\nThis will print the diagonals from Top Right To Bottom Left");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i + j == matrix.GetLength(1) - 1)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}