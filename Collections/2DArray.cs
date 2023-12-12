using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class _2DArray
    {
        public void NormalForLoop(int[,] myArray)
        {
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++) {
                    Console.Write(myArray[i,j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        public void ForEach(int[,] myArray)
        {
            foreach(int k in myArray)
            {
                Console.Write(k + " ");
            }
        }
    }
}
