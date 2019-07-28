using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewsTranslator.Models
{
    public class TranslateResponseModel
    {
        [JsonProperty(PropertyName = "extract")]
        public TranslateExtractModel Extract { get; set; }

        [JsonProperty(PropertyName = "originalResponse")]
        public string OriginalResponse { get; set; }
    }
}
