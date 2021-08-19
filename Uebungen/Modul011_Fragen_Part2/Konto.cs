using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_Exercise3
{
    public class Konto
    {
        public string Inhaber { get; private set; }
        public decimal Kontostand { get; private set; }

        public Konto(string inhaber, decimal kontostand)
        {
            Inhaber = inhaber;
            Kontostand = kontostand;
        }

        public virtual void Einzahlen(decimal betrag)
        {
            if (betrag > 0)
            {
                Kontostand += betrag;
                Console.WriteLine($"Einzahlung: {betrag}");
            }
            else
            {
                Console.WriteLine("Einzahlung: 0 - negativer Betrag!");
            }
        }

        public virtual void Auszahlen(decimal betrag)
        {
            if (betrag > 0)
            {
                Kontostand -= betrag;
                Console.WriteLine($"Auszahlung: {betrag}");
            }
            else
            {
                Console.WriteLine("Auszahlung: 0 - negativer Betrag!");
            }
        }

        public interface IUeberweisung
        {
        }
    }
}
