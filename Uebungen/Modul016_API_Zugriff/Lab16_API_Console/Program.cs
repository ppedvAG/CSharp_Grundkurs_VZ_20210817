using Lab16_API_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab16_API_Console
{
    class Program
    {
        static TodoItemAPI api = new TodoItemAPI();
        static void Main(string[] args)
        {
            try
            {
                TodoItem item = new TodoItem()
                {
                    Name = "mein neues Item (Benedikt)",
                    IsComplete = false
                };

                ItemInfo(item);

                Uri url = api.Post(item);
                Console.WriteLine($"Erstellt mir Url: {url}");

                item = api.Get(url.PathAndQuery);
                ItemInfo(item);

                item.Name = "Ich habe einen neuen Namen (Benedikt)";

                item = api.Put(item);
                ItemInfo(item);

                HttpStatusCode code = api.Delete(item.Id);
                Console.WriteLine($"Gelöscht mir Statuscode:{code}({(int)code})");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        static void ItemInfo(TodoItem item)
        {
            Console.WriteLine($"Id: {item.Id} \nName: {item.Name} \nIsComplete: {item.IsComplete}");
        }
    }
}
