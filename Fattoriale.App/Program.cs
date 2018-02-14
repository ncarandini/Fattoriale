using System;

namespace Fattoriale.App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");

            //modifica enzo
            bool corretto = false;

            //modifica enzo
            while (!corretto)
            {

                Console.Write("Inserisci n: ");
                string s = Console.ReadLine();

                if (int.TryParse(s, out int n))
                {
                    corretto = true;
                    int result = Fattoriale(n);
                    Console.WriteLine($"Il fattoriale di {n} è pari a {result}");
                }
                else
                {
                    Console.WriteLine("Il parametro inserito non è un numero. Riprovare.");
                }

            }

            //modifica enzo
            corretto = false;

            //modifica enzo
            Console.WriteLine("Premere 0, T oppure t per terminare");
            string exit = Console.ReadLine();

            while (!corretto)
            {
                
                if ((exit.Equals("0")) || (exit.Equals("T")) || (exit.Equals("t")))
                {
                    
                    corretto = true;
                    
                }
                else
                {
                    exit = Console.ReadLine();
                    
                }
            }

        }

        // Ho ragione io!
        static int Fattoriale(int n)
        {
            if (n < 2)
            {
                return 1;
            }

            return n * Fattoriale(n - 1);

        }
    }
}