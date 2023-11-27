namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 10;
            grades[2] = 60;
            grades[3] = 34;
            grades[4] = 70;

            Console.WriteLine("Enter a value to be stored in the array");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out grades[0]);
            Console.WriteLine("Your value was store in an array and it was " + grades[0]);

            int[] gradesOfMathA = { 20, 13, 12, 8, 8 };

            int[] gradesOfMathB = { 15, 20, 3, 17, 18, 15 };

            Console.WriteLine("The length of this array is " + gradesOfMathA.Length);
            Console.WriteLine("The length of this array is " + gradesOfMathB.Length);

        }
    }
}