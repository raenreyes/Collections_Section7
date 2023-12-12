using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Interate
    {
        private int[,] _myArray;

        public int[,] Values { get { return _myArray; } set { _myArray = value; } }

        public void ForLoopIterate()
        {
            Console.WriteLine("This is the for loop iterating over the 2D array");
            for (int i = 0; i < _myArray.GetLength(0); i++)
            {
                for (int j = 0; j < _myArray.GetLength(1); j++)
                {
                    Console.Write(_myArray[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        public void ForEachIterate()
        {
            Console.WriteLine("This is the for each loop iterating over the 2D array");
            foreach (int item in _myArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
