using System;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett heltal för att beräkna antalet primtal som är mindre än det:");
            int tal = int.Parse(Console.ReadLine());
            int antal = Metod2(tal);
            Console.WriteLine("Det finns " + antal + " primtal mindre än " + tal + ".");
        }

        static int Metod2(int tal)
        {
            int antal = 0;
            for (int i = 2; i < tal; i++)
            {
                if (Metod(i))
                {
                    antal++;
                }
            }
            return antal;
        }

        static bool Metod(int tal)
        {
            int deltal = 0;
            for (int i = 2; i < tal; i++)
            {
                if (tal % i == 0)
                {
                    deltal++;
                }
            }
            return deltal == 0;
        }
    }
}