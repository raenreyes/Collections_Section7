using System.Threading.Channels;

namespace Collections
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int[,] arrayOfNumbers = {
                {34,56,76 },
                {5,7,8 },
                {93,46,12 }
            };
            Interate bruh = new Interate();
            bruh.Values = arrayOfNumbers;
            bruh.ForLoopIterate();
            Console.WriteLine("------------------------------------------------------------------------------------");
            bruh.ForEachIterate();
        }
    }
}