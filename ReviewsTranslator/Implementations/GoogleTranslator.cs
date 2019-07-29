using Newtonsoft.Json;
using ReviewsTranslator.Interfaces;
using ReviewsTranslator.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace ReviewsTranslator.Implementations
{
    public class GoogleTranslator : IGoogleTranslator
    {
        public async Task<string> Translate(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var request = new HttpRequestMessage(HttpMethod.Post, "https://google-translate-proxy.herokuapp.com/api/translate");
                    var model = new TranslateRequestModel
                    {
                        query = text
                    };
                    var jsonMessage = JsonConvert.SerializeObject(model);
                    request.Content = new StringContent(jsonMessage, Encoding.UTF8, "application/json");
                    var response = await client.SendAsync(request);
                    response.EnsureSuccessStatusCode();
                    string responseString = await response.Content.ReadAsStringAsync();
                    var translateResponse = JsonConvert.DeserializeObject<TranslateResponseModel>(responseString);
                    return translateResponse.Extract.Translation;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
