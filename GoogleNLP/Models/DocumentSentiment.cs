using Newtonsoft.Json;

namespace GoogleNLP.Models
{
    public class DocumentSentiment
    {
        [JsonProperty(PropertyName = "magnitude")]
        public string Magnitude { get; set; }

        [JsonProperty(PropertyName = "score")]
        public string Score { get; set; }
    }
}