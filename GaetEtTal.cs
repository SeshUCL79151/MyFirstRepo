using System;

namespace GaetEtTal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opret en instans af Random-klassen
            Random random = new Random();

            // Generer et tilfældigt tal mellem 1 og 10
            int tal = random.Next(1, 11);

            Console.WriteLine("Du skal nu gætte et tal mellem 1 og 10!");
            int gæt = Convert.ToInt32(Console.ReadLine()); // Læs brugerens gæt

            // Tjek om gættet er korrekt
            if (gæt == tal)
            {
                Console.WriteLine("Tillykke, du gættede rigtigt!");
            }
            else
            {
                Console.WriteLine("Desværre, det var forkert :(");
            }

        }
    }
}