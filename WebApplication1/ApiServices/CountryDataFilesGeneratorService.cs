using System.Diagnostics.Metrics;
using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ApiServices
{
    public class CountryDataFilesGeneratorService
    {
        public async void GenerateCountryDataFiles()
        {
            string url = "https://restcountries.com/v3.1/all";
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                string responseBody = response.Content.ReadAsStringAsync().Result;
                Country[] countries = JsonSerializer.Deserialize<Country[]>(responseBody);
                foreach (Country country in countries)
                {
                    string name = country.Name.Common;
                    string region = country.Region;
                    string subregion = country.Subregion;
                    string latlng = string.Join(", ", country.Latlng.Select(x => x.ToString()));
                    string area = country.Area?.ToString();
                    string population = country.Population?.ToString();

                    // create text file for each country
                    string filename = $"Countries/{name}.txt";
                    using (StreamWriter file = new StreamWriter(filename))
                    {
                        file.WriteLine($"Country: {name}");
                        file.WriteLine($"Region: {region}");
                        file.WriteLine($"Subregion: {subregion}");
                        file.WriteLine($"Latlng: {latlng}");
                        file.WriteLine($"Area: {area}");
                        file.WriteLine($"Population: {population}");
                    }
                }
            }
        }
    }
}

