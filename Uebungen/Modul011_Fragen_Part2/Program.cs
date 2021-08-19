using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Girokonto giro = new Girokonto("Max", 1451.51m);
            Jugendkonto jugend = new Jugendkonto("Bea", 345.15m);

            Random random = new Random();

            //Girokonto
            Console.WriteLine($"Girokonto von: {giro.Inhaber}");
            for (int i = 0; i < 10; i++)
            {
                if (random.Next() % 2 == 0)
                {
                    giro.Einzahlen(random.Next(100, 10000) / 100);
                }
                else
                {
                    giro.Auszahlen(random.Next(100, 10000) / 100);
                }
            }

            //Jugendkonto
            Console.WriteLine($"Jugendkonto von: {jugend.Inhaber}");
            for (int i = 0; i < 10; i++)
            {
                if (random.Next() % 2 == 0)
                {
                    jugend.Einzahlen(random.Next(100, 10000) / 100);
                }
                else
                {
                    jugend.Auszahlen(random.Next(100, 10000) / 100);
                }
            }

            Console.ReadLine();
        }
    }
}
