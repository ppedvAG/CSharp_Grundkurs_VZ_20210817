using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_Exercise3
{
    public class Jugendkonto : Konto, IUeberweisung
    {
        public Jugendkonto(string inhaber, decimal kontostand) : base(inhaber, kontostand)
        {

        }

        public override void Auszahlen(decimal betrag)
        {
            if ((betrag > 0 && betrag <= 50) && Kontostand - betrag >= 0)
            {
                base.Auszahlen(betrag);
            }
            else
            {
                Console.WriteLine($"Auszahlung: 0 - maximaler Betrag 50 ({betrag})");
            }
        }

        public void Ueberweisung(decimal betrag, Konto zielKonto)
        {
            if (Kontostand - betrag < 0)
            {
                Console.WriteLine("Überweisung: zu wenig Guthaben!");
            }
            else if (betrag > 0 && betrag <= 100)
            {
                base.Auszahlen(betrag); 

                zielKonto.Einzahlen(betrag);
                Console.WriteLine($"Überweisung: {betrag} zu {zielKonto.Inhaber}");
            }
            else
            {
                Console.WriteLine("Überweisung: 0 - maximaler Betrag 100!");
            }
        }
    }
}
