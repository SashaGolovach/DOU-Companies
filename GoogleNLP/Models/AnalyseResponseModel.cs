using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleNLP.Models
{
    public class AnalyseResponseModel
    {
        [JsonProperty(PropertyName = "documentSentiment")]
        public DocumentSentiment Sentiment { get; set; }
    }
}
