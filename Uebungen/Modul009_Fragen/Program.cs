using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul009_Fragen
{
    class Program
    {
        enum Formen { Form, Kreis, Zylinder, Kugel }

        static void Main(string[] args)
        {
            int anzahl = 10;
            Form[] formen = new Form[anzahl];
            Random randomGenerator = new Random();

            for (int i = 0; i < formen.Length; i++)
            {
                int zahlAusRandom = 1;
                Formen formTyp = (Formen)zahlAusRandom;

                double x = randomGenerator.Next(100, 10000) / 100.0;
                double y = (randomGenerator.NextDouble() + 0.01) * 100;

                switch (formTyp)
                {
                    case Formen.Form:
                        formen[i] = new Form(x, y);
                        break;
                    case Formen.Kreis:
                        formen[i] = new Kreis(x);
                        break;
                    case Formen.Zylinder:
                        formen[i] = new Zylinder(x, y);
                        break;
                    case Formen.Kugel:
                        formen[i] = new Kugel(x);
                        break;
                    default:
                        break;
                }
            }

            foreach (var item in formen)
            {
                Console.WriteLine(item.Info());
            }
            Console.ReadLine();
        }
    }
}
