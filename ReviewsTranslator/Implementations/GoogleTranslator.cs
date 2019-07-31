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

        public async Task<string> Analyse(string text)
        {
            try
            {
                var url = "https://www.repustate.com/sentiment-analysis-api-demo/";

                var body = new Dictionary<string, string>
                {
                    { "csrfmiddlewaretoken", "QenD1hL4EsAOx5dOynK4vLOTyKQ55Wg9rnLxTmB5lRofE8LOGMfXFkA9OO18S7Tj" },
                    { "language", "ru" },
                    {"text",  text}
                };

                using (HttpClient client = new HttpClient())
                {
                    var content = new FormUrlEncodedContent(body);
                    var request = new HttpRequestMessage(HttpMethod.Post, url) { Content = content};
                    request.Headers.Add("Referer", url);
                    request.Headers.Add("Cookie", "__stripe_mid=04bbffd8-9b9a-4c06-a3b4-80e8f481417e; csrftoken=60JfEsSf3HdLbgqVq1yL4Voe9d6PEMCTH979wxIgK61cijYVyq3EeuauphhSrXf3; sessionid=ki45aofxwcic9814hdiltw4c2vli1nri");
                    HttpResponseMessage response = await client.SendAsync(request);

                    string responseString = await response.Content.ReadAsStringAsync();

                    return responseString;
                }
            }
            catch (HttpRequestException ex)
            {
                return null;
            }
        }
    }
}
