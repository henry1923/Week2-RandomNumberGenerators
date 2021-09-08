using System;

namespace EpicDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb 2 mängijat
            //iga mängija viskab täringut (1-6)
            //programm kuvab nende visete tulemused ja kuvab ka, kes on võitja
            // - ehk kes viskas suuremat

            Random rnd = new Random();

            string PlayerOne = "Pede";
            string PlayerTwo = "Lits";

            int PedeThrow = rnd.Next(1, 7);
            int LitsThrow = rnd.Next(1, 7);

            Console.WriteLine($"PlayerOne threw {PedeThrow};");
            Console.WriteLine($"PlayerTwo threw {LitsThrow};");


            if (PedeThrow > LitsThrow)
            {
                Console.WriteLine($"{PlayerOne} wins!");
            }
            else if (PedeThrow < LitsThrow)

            { 
                Console.WriteLine($"{PlayerTwo} wins!");
            }
            else
            {
                Console.WriteLine("Draw! Let them try again.");
            }


            







        }














            
    }
}
