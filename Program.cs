namespace AppDevClassActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string? sentence = Console.ReadLine();

            int letterCount = 0;

            foreach (char c in sentence)
            {
                if (char.IsLetter(c))
                {
                    letterCount++;
                }
            }

            Console.WriteLine($"Number of letters in the sentence: {letterCount}");
        }
    }
}
