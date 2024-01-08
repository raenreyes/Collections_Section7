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
            List<int> list = new List<int> { 3, 2, 4 };
            List<int> result = TwoSum(list, 6);

            foreach (int k in result)
            {
                Console.Write(k + " ");
            }
        }
            public static List<int> TwoSum(List<int> nums, int target)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                for(int j = i + 1; j < nums.Count; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new List<int> { i, j };
                    }
                }
            }
            return new List<int>(0);
        }
    }
}
