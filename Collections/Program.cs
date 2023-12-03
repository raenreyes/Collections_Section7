using System.Threading.Channels;

namespace Collections
{
    internal class Program
    {
        static int[,] matrix = {

            {1,2,3 },
            {4,5,6 },
            {7,8,9 }

        };
        static void Main(string[] args)
        {   
            //iterate a 2D array with a foreach loop but only used for iteration
            foreach (int item in matrix) 
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" ");

            //this is how you iterate a 2D array with a for loop
            Console.WriteLine("This is our 2D array printed using nested for loop");
            //out for loop
            for (int i = matrix.GetLength(0) - 1; i >= 0; i--) { 
                //inner for loop
                for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                {
                    
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine(" ");
            }
        }


    }
}