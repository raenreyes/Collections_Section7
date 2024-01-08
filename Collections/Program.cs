using System.Collections;
using System.Threading.Channels;
using System.Formats.Asn1;
using System;
using System.Collections.Generic;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> evenNumberList = Solution();

            foreach (int i in evenNumberList)
            {
                Console.Write(i + " ");
            }
        }
        public static List<int> Solution()
        {
            List<int> evenNumbers = new List<int>();
            for (int i = 100; i <= 170; i++)
            {
                if(i % 2 == 0)
                {
                    evenNumbers.Add(i);
                }
            }
            return evenNumbers;

        }
    }
}
