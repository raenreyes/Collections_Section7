using System.Collections;
using System.Threading.Channels;
using System.Collections.Generic;
namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ArrayList can hold any type of objects like int, string or doubles
            int num = 6;

            string name = "Raen Reyes";

            float pi = 3.14f;

            ArrayList myList = new ArrayList();
            myList.Add(num);
            myList.Add(name);
            myList.Add(pi);

            foreach (object i in myList)
            {
                Console.Write(i + " ");
            }

            //this is a list and its generic which means it can only hold one type of data type
            List<int> list = new List<int>();
            int userNum = 0;
            while (userNum != 99)
            {
                Console.WriteLine("Hello pls enter numbers for a list");
                string toConvert = Console.ReadLine();
                bool success = int.TryParse(toConvert, out userNum);
                if(success && userNum != 99)
                {
                    list.Add(userNum);
                }
                else  {
                    Console.WriteLine("Pls enter a valid number");
                }
            }
            Console.WriteLine("This are the values that you passed");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }
       
    }

}
