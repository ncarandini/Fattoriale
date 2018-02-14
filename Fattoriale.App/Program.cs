using System;

namespace Fattoriale.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //modifica enzo
            Console.WriteLine("Hello World!");

            Console.Write("Inserisci n: ");
            string s = Console.ReadLine();
            if (int.TryParse(s, out int n))
            {
                int result = Fattoriale(n);
                Console.WriteLine($"Il fattoriale di {n} è pari a {result}");
            }

            Console.Write("Premi un tasto per terminare...");
            Console.ReadKey();
        }

        static int Fattoriale(int n)
        {
            if (n < 3)
            {
                return 1;
            }

            return n * Fattoriale(n - 1);

        }
    }
}