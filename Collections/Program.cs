namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("Index " + i + ": ");
                string input = Console.ReadLine();
                bool success = int.TryParse(input, out nums[i]);
            }
            Console.WriteLine("This is the for loop iterating through array");
            for (int j = 0;j < nums.Length;j++)
            {
                Console.WriteLine("Index " + j + ": " + nums[j]);
            }

            Console.WriteLine("This is the for each loop iterating through array");
            int counter = 0;
            foreach (int k in nums) {
                Console.WriteLine("Index " + counter + ": " + k);
                counter++;
            }
        }
    }
}