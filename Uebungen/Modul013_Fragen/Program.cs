using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Exercise1
{
    class Program
    {
        static DateTime aktuellerTag = new DateTime(2021, 8, 5);
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Vorname = "Tina";
            person.Nachname = "Testfrau";
            person.Geburtsdatum = new DateTime(1994, 8, 11);
            person.OnGeburtstag += Person_OnGeburtstag;

            person.OnGeburtstag += (sender, eventargs) => Console.WriteLine("mit Lambda geht es auch!");
            person.OnGeburtstag += delegate (object sender, EventArgs eventArgs)
            {
                Console.WriteLine("Das ist eine anonyme Methode");
            };

            for (int i = 0; i < 10; i++)
            {
                aktuellerTag = aktuellerTag.AddDays(1);
                Console.WriteLine($"Heute ist der {aktuellerTag.ToShortDateString()}");

                person.AelterWerden(aktuellerTag);
            }

            Console.ReadLine();
        }

        private static void Person_OnGeburtstag(object sender, EventArgs e)
        {
            Person person = sender as Person;
            if (person != null)
            {
                GeburtstagsEventArgs eventargs = e as GeburtstagsEventArgs;
                if (eventargs != null)
                {
                    Console.WriteLine($"Alles Gute zu deinem {eventargs.Alter}. Geburtstag, {person.Vorname}");
                }
            }
        }
    }

    class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime Geburtsdatum { get; set; }

        public event EventHandler OnGeburtstag;

        public void AelterWerden(DateTime heute)
        {
            if (OnGeburtstag == null)
                return;
            
            if (heute.Month == Geburtsdatum.Month && heute.Day == Geburtsdatum.Day)
                OnGeburtstag(this, new GeburtstagsEventArgs() { Alter = heute.Year - Geburtsdatum.Year });
        }
    }

    public class GeburtstagsEventArgs : EventArgs
    {
        public int Alter { get; set; }
    }
}
