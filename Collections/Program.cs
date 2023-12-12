using System.Threading.Channels;

namespace Collections
{
    internal class Program
    {
        static int[,] matrix = {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };


        static void Main(string[] args)
        {   
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            Console.WriteLine("Finding even numbers in a 2D array");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 == 0 && matrix[i, j] != matrix[2, 1])
                    {
                        Console.Write(matrix[i, j] + ",");
                    }
                    else if (matrix[i, j] % 2 == 0)
                    {
                        Console.Write(matrix[i, j]);
                    }

                }
            }
        }
    }
}