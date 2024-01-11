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
          Dictionary<int,Gamer> entryForGamers = new Dictionary<int,Gamer>();
            string continueLoop = " ";

            while (continueLoop != "n")
            {
                
                Console.WriteLine("Enter a ID in numbers for your player: ");
                string userID = Console.ReadLine();
                int keyID = int.Parse(userID);

                Console.WriteLine("Enter Your Role: ");
                string role = Console.ReadLine();
                Console.WriteLine("Enter Your Gamer Name: ");
                string userName = Console.ReadLine();
                Console.WriteLine("Enter Your Rank: ");
                string rankChange = Console.ReadLine();
                int rank = int.Parse(rankChange);

                if (entryForGamers.ContainsKey(keyID))
                {
                    Console.WriteLine("That user ID already Exist these stats will not be saved");
                }
                else {
                    entryForGamers.Add(keyID, new Gamer(role, userName, rank));
                }

                Console.WriteLine("\nWould you like to add another player: (y/n)");
                continueLoop = Console.ReadLine();
                continueLoop = continueLoop.ToLower();



            }
            IterateGamerData(entryForGamers);

        }
        public static void IterateGamerData (Dictionary<int, Gamer> entryForGamers)
        {
            foreach (KeyValuePair<int,Gamer> temp in entryForGamers)
            {
                Gamer gamer = temp.Value;
                Console.WriteLine($"Gamer ID: {temp.Key}, Role: {gamer.Role}, UserName: {gamer.Name}, Rank: {gamer.rank}");
            }
        }
        
        
    }

}



