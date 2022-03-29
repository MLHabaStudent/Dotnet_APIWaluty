using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;

//8fd494470bca455a8caf0d3d918a97fb

namespace DBWaluty
{
    public class DataManager
    {
        private static string app_id;

        public DataManager(string id = "8fd494470bca455a8caf0d3d918a97fb")
        {
            app_id = id;
        }

        /*private string getDateURL()
        {
            string request = "https://openexchangerates.org/api/historical/" + date + ".json?app_id=" + app_id;
            return request;
        }*/

        private async Task<Currency> updateData(string url)
        {
            Currency recieved;
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(url);
            recieved = JsonConvert.DeserializeObject<Currency>(response);
            return recieved;
        }

        public Currency getLatest()
        {
            string request = "https://openexchangerates.org/api/latest.json?app_id=" + app_id;
            return updateData(request).Result;
        }
    }
}
