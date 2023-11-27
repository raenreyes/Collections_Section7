namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] friends = new string[5];
            int counter = 0;
            foreach (string friend in friends) {
                Console.WriteLine("Enter your friends name");
                string input = Console.ReadLine();
                friends[counter] = input;
                counter++;
            }

            foreach (string greet in friends) {
                Console.WriteLine("Hello " + greet);
            }
            
        }
    }
}