using GoogleNLP.Interfaces;
using GoogleNLP.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GoogleNLP.Implementations
{
    public class NLPService : INLPService
    {
        private const string _apiKey = "Bearer TOKEN";

        public async Task<decimal> Analyse(string text)
        {
            if (string.IsNullOrEmpty(text))
                return default(decimal);
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var request = new HttpRequestMessage(HttpMethod.Post, "https://language.googleapis.com/v1/documents:analyzeSentiment");
                    var model = new AnalyseRequestModel
                    {
                        EncodingType = "UTF8",
                        Document = new DocumentModel
                        {
                            Type = "PLAIN_TEXT",
                            Content = text
                        }
                    };
                    var jsonMessage = JsonConvert.SerializeObject(model);
                    request.Headers.Add("Authorization", _apiKey);
                    request.Content = new StringContent(jsonMessage, Encoding.UTF8, "application/json");
                    var response = await client.SendAsync(request);

                    response.EnsureSuccessStatusCode();
                    string responseString = await response.Content.ReadAsStringAsync();
                    var analyseResponse = JsonConvert.DeserializeObject<AnalyseResponseModel>(responseString);
                    return Decimal.Parse(analyseResponse.Sentiment.Score.Replace('.', ','));
                }
            }
            catch
            {
                return -10m;
            }
        }
    }
}
