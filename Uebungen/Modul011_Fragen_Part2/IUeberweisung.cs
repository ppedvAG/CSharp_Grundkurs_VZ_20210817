using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_Exercise3
{
    public interface IUeberweisung
    {
        void Ueberweisung(decimal betrag, Konto zielKonto); 
    }
}
