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
           
            _2DArray bruh = new _2DArray();
            bruh.NormalForLoop(matrix);
            Console.WriteLine("Below is the For Each loop");
            bruh.ForEach(matrix);

          
        }
    }
}