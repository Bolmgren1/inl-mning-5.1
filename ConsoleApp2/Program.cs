using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många meningar vill du skriva?");
            int antal = int.Parse(Console.ReadLine());
            string[] meningar = new string[antal];

            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine("Skriv in din mening här");
                meningar[i] = Console.ReadLine();

            }

            Console.WriteLine("Dessa är de meningarna du skrev in");
            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine(meningar[i]);
            }
            

            
        }
    }
}
