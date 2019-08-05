using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleNLP.Models
{
    public class AnalyseRequestModel
    {
        [JsonProperty(PropertyName = "encodingType")]
        public string EncodingType { get; set; }

        [JsonProperty(PropertyName = "document")]
        public DocumentModel Document { get; set; }
    }
}
