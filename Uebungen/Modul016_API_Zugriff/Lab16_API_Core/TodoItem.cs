using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16_API_Core
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }

        public static string ConvertToString(TodoItem item)
        {
            return JsonConvert.SerializeObject(item);
        }

        public static TodoItem ConvertToItem(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<TodoItem>(json);
            }
            catch
            {
                return null;
            }
        }

        public static List<TodoItem> ConvertToList(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<TodoItem>>(json);
            }
            catch
            {
                return null;
            }
        }
    }
}
