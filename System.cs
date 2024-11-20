using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using conversor.ui;
using conversor.models;

namespace conversor
{
    public class System
    {
        private static readonly string key = File.ReadAllText("C:\\Users\\vinicius\\source\\repos\\conversor\\.env");
        public static void Run()
        {
            Tuple<string, string, double> result = UserInterface.GetUserInput();
            API_Response response = APIQuery(result.Item1, result.Item2, result.Item3);
            UserInterface.UserOutput(response);

            Run();
        }

        private static API_Response APIQuery(string basecurrency, string targetcurrency, double value)
        {
            using var httpClient = new HttpClient();
            try
            {
                string URL = $"https://v6.exchangerate-api.com/v6/{key}/pair/{basecurrency}/{targetcurrency}/{value}";

                HttpResponseMessage response = httpClient.GetAsync(URL).Result;

                string jsonResponse = response.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<API_Response>(jsonResponse);
            }
            catch (Exception)
            {
                return new API_Response();
            }
        }
    }

    
}
