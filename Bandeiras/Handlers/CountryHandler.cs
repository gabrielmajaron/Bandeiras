using Bandeiras.Models;
using System.Net;
using System.Text.Json;

namespace Bandeiras.Handlers
{
    public class CountryHandler
    {
        Form1 _window;

        WebClient webClient = new WebClient();
        TranslateHandler translator = new TranslateHandler();
        HttpClient httpClient = new HttpClient();

        public CountryHandler(Form1 window)
        {
            _window = window;
        }

        public async Task<List<CountryResponse>> GetCountries()
        {
            try
            {
                string apiUrl = "https://restcountries.com/v3.1/all"; 

                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();

                    List<CountryResponse> countries = JsonSerializer.Deserialize<List<CountryResponse>>(json);

                    var totalCountries = countries.Count;
                    int i = 0;

                    foreach(var country in countries)
                    {
                        var percentageProgress = (++i * 100) / totalCountries;

                        _window.UpdateTxtProgress($"Carregando: {percentageProgress}%");

                        country.Name.TranslatedName = GetTranslatedName(country.Name.Common);                        

                        country.Flags.PngBytes = GetFlagPngBytes(country.Flags.Png);
                    }

                    // Remove ilha são martinho com bandeira errada. Adicionado obs. no nome do país são martinho (Sint Marteen)
                    countries.Remove(countries.First(c => c.Name.Common.Equals("Saint Martin", StringComparison.CurrentCultureIgnoreCase)));
                    File.Delete(Environment.CurrentDirectory + "\\temp.png");

                    return countries.OrderBy(c => c.Name.TranslatedName).ToList();
                }
                else
                {
                    throw new Exception($"Erro ao acessar a API. Status: {response.StatusCode}");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private byte[] GetFlagPngBytes(string imgUrl)
        {
            webClient.DownloadFile(imgUrl, "temp.png");

            return File.ReadAllBytes(Environment.CurrentDirectory + "\\temp.png");
        }

        private string GetTranslatedName(string countryName)
        {
            if (countryName.Equals("turkey", StringComparison.InvariantCultureIgnoreCase))
                return "Turquia"; // Tradução errada: Peru

            if (countryName.Equals("jersey", StringComparison.InvariantCultureIgnoreCase))
                return countryName; // Tradução errada: Camisa

            if (countryName.Equals("czechia", StringComparison.InvariantCultureIgnoreCase))
                return "República Tcheca"; // Melhor tradução

            if (countryName.Equals("sint maarten", StringComparison.CurrentCultureIgnoreCase))
                return "São Martinho: Saint Martin (ilha) Sint Maarten (país)"; // Melhor tradução

            if (countryName.Equals("caribbean netherlands", StringComparison.InvariantCultureIgnoreCase))
                return "Caribe Neerlandês (ou Caribe Holandês)"; // Melhor tradução

            if (countryName.Contains("saint kitts and nevis", StringComparison.InvariantCultureIgnoreCase))
                return "São Cristóvão e Neves"; // Melhor tradução

            if (countryName.Contains("antarctica", StringComparison.InvariantCultureIgnoreCase))
                return "Antártida (ou Antártica)"; // Melhor tradução

            if (countryName.Contains("south georgia", StringComparison.InvariantCultureIgnoreCase))
                return "Ilha Geórgia do Sul (e também Ilhas Sandwich do Sul) *"; // Melhor tradução

            if (countryName.Equals("togo", StringComparison.InvariantCultureIgnoreCase))
                return countryName; // Tradução errada: Ir

            if (countryName.Equals("réunion", StringComparison.InvariantCultureIgnoreCase))
                return "Reunião (ou ilha da reunião)"; // Melhor tradução

            if (countryName.Equals("dr congo", StringComparison.InvariantCultureIgnoreCase))
                return "República Democrática de Congo *"; // Melhor tradução

            if (countryName.Equals("republic of the congo", StringComparison.InvariantCultureIgnoreCase))
                return "República de Congo *"; // Melhor tradução

            if(countryName.Equals("turkmenistan", StringComparison.InvariantCultureIgnoreCase))
                return "Turquemenistão"; // Melhor tradução

            return translator.Translate(countryName);
        }
    }
}

