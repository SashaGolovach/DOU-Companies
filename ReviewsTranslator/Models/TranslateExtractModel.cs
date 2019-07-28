using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewsTranslator.Models
{
    public class TranslateExtractModel
    {
        [JsonProperty(PropertyName = "translation")]
        public string Translation { get; set; }
        [JsonProperty(PropertyName = "actualQuery")]
        public string ActualQuery { get; set; }
        [JsonProperty(PropertyName = "resultType")]
        public int ResultType { get; set; }
        [JsonProperty(PropertyName = "transliteration")]
        public string Transliteration { get; set; }
        [JsonProperty(PropertyName = "synonyms")]
        public List<object> Synonyms { get; set; }
        [JsonProperty(PropertyName = "sourceLanguage")]
        public string SourceLanguage { get; set; }
    }
}
