using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Lab16_API_Core
{
    
    public class TodoItemAPI
    {
        HttpClient client;
        string apiUrl = "api/todoitems/";

        public TodoItemAPI()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("meineurl");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public TodoItem Get(string path)
        {
            HttpResponseMessage response = client.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                return TodoItem.ConvertToItem(response.Content.ReadAsStringAsync().Result);
            }
            return null;
        }

        public TodoItem Get(int id)
        {
            return Get(apiUrl + id);
        }

        public List<TodoItem> GetAll()
        {
            HttpResponseMessage response = client.GetAsync(apiUrl).Result;
            if (response.IsSuccessStatusCode)
            {
                return  TodoItem.ConvertToList(response.Content.ReadAsStringAsync().Result);
            }
            return null; 
        }

        public Uri Post(TodoItem item)
        {
            HttpContent content = new StringContent(TodoItem.ConvertToString(item), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(apiUrl, content).Result;

            if (response.IsSuccessStatusCode)
            {
                return response.Headers.Location;
            }

            return null;
        }

        public TodoItem Put(TodoItem item)
        {
            HttpContent content = new StringContent(TodoItem.ConvertToString(item), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(apiUrl + item.Id, content).Result;

            return TodoItem.ConvertToItem(response.Content.ReadAsStringAsync().Result);
        }

        public HttpStatusCode Delete(int id)
        {
            HttpResponseMessage response = client.DeleteAsync(apiUrl + id).Result;
            return response.StatusCode;
        }
    }
}
