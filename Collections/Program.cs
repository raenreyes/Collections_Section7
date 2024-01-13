using System.Collections;
using System.Threading.Channels;
using System.Formats.Asn1;
using System;
using System.Collections.Generic;


namespace Collections
{
    public class Program
    {
        //Key - Value
        //Auto - Car
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            //how to add an obect to a stack using Push()
            stack.Push(1);
            stack.Push(2);
            //Peek() will return the element at the top of the stack without removing it
            Console.WriteLine($"The element at the top of the stack is {stack.Peek()}");
            stack.Push(3);
            Console.WriteLine($"The element at the top of the stack is {stack.Peek()}");
            stack.Push(4);
            Console.WriteLine($"The element at the top of the stack is {stack.Peek()}");
            //remove an item from a stack
            if (stack.Count > 0)
            {
                Console.WriteLine($"Popped Item is {stack.Pop()}");
            }
            
            Console.WriteLine($"The element at the top of the stack is {stack.Peek()}");

            while (stack.Count > 0)
            {
                Console.WriteLine($"Popping all items {stack.Pop()}");
            }



             //with a stack
            //reverse an array
            int[] numbers =  new int[] { 8,2,3,4,7,6,2};
            Stack<int> reverseArray = new Stack<int>();

            foreach (int item in numbers)
            {
                Console.Write(item + " ");
                reverseArray.Push(item);
            }

            Console.WriteLine("\nThe numbers in reverse");

            while (reverseArray.Count > 0)
            {
                int number = reverseArray.Pop();
                Console.Write(number + " ");
            }
        }



    }

}



