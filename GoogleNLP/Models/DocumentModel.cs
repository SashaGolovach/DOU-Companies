using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleNLP.Models
{
    public class DocumentModel
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }
    }
}
