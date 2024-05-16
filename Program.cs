namespace Challenge_Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a letter: ");
            string letter = (Console.ReadLine());

            Console.WriteLine("Enter desired width: ");
            int width = Convert.ToInt32(Console.ReadLine());


            for (int i = width; i >= 1; i--)
            {
                for (int j = 0; j < i ; j++)
                {
                    Console.WriteLine(letter);
                }
                Console.WriteLine();
            }
        }
    }
}
