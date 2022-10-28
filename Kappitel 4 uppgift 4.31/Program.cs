using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en mening");
            string mening = Console.ReadLine();
            bool ord =false;

            for (int i = 0; i < mening.Length; i++)
            {
                if (mening[..i].Contains(mening[i]))
                {
                    continue;
                }
                if (mening[(i + 1)..].Contains(mening[i]))
                {
                    Console.WriteLine($"texten innerhåller {mening[i]} mer än en gång");
                    ord = true;
                }

            }
            if (ord == false)
            {
                Console.WriteLine("Ingen bokstav förekommer mer än en gång");
            }
        }
    }
}
