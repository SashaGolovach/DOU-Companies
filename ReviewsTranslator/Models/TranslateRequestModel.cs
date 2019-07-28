using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewsTranslator.Models
{
    public class TranslateRequestModel
    {
        public string query;
        public string targetLang = "ru";
        public string sourceLang = "auto";
    }
}
