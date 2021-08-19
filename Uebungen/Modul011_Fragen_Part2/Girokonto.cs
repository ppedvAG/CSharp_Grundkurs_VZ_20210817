using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_Exercise3
{
    public class Girokonto : Konto, IUeberweisung
    {
        public Girokonto(string inhaber, decimal kontostand) : base(inhaber, kontostand)
        {

        }

        public void Ueberweisung(decimal betrag, Konto zielKonto)
        {
            if (betrag > 0)
            {
                Auszahlen(betrag * 1.03m);
                zielKonto.Einzahlen(betrag);
                Console.WriteLine($"Überweisung: {betrag} zu {zielKonto.Inhaber} (+ {betrag * 0.03m} Gebühr)");
            }
        }
    }
}
