using System;

namespace GaetEtTal
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal = 7;

            Console.WriteLine("Du skal nu gætte et tal mellem 1 og 10!");
            int gæt = Convert.ToInt32(Console.ReadLine());

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