using System.Collections;
using System.Threading.Channels;
using System.Collections.Generic;
namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            //declare a arraylist with no undefined size of the list
            ArrayList myArrayList = new ArrayList();
            //array list with a defined size
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(5);
            myArrayList.Add(13);
            myArrayList.Add(14);
            myArrayList.Add(25.3f);

            //delete element with specific entry to an array list
            myArrayList.Remove(13);


            //delete element at a specfic position
            myArrayList.RemoveAt(0);

            //how many objects are in your array list
            Console.WriteLine("The count of my array list is " + myArrayList.Count);

            double sum = 0;

            foreach (object i in myArrayList)
            {
                if (i is int || i is double || i is float)
                {
                    sum += Convert.ToDouble(i);
                }
         
            }

            Console.WriteLine("\nThe sum of the arraylist is " + sum);
        }

    }

}
