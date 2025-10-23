using System;

namespace OldPhonePadChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Old Phone Pad Simulation (Type 'exit' to quit)");
            while (true)
            {
                Console.Write("\nEnter input (end with #): ");
                string input = Console.ReadLine();

                if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
                    break;

                string output = OldPhone.OldPhonePad(input);
                Console.WriteLine($"Output: {output}");
            }

            Console.WriteLine("\nGoodbye 👋");
        }
    }
}
