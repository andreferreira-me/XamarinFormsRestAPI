using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Diagnostics;

namespace XamarinFormsRestAPI.Services
{
    public class RestClient
    {
        public string Serialize()
        {
            var countries = new[]
            {
                new Country { Name = "México" },
                new Country { Name = "Brasil" }
            };

            string json = JsonConvert.SerializeObject(countries);

            Debug.WriteLine(json);

            return json;
        }

        public void Deserialize()
        {
            var json = Serialize();

            var parsedJson = JsonConvert.DeserializeObject<IEnumerable<Country>>(json);

            foreach (Country item in parsedJson)
            {
                Debug.WriteLine(item.Name);
            }
        }
    }
}
