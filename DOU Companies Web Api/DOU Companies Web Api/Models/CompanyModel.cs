using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DOU_Companies_Web_Api.Models
{
    public partial class CompanyModel
    {
        [Key]
        public string Name { get; set; }
        public string Score { get; set; }
        public string ReviewsCount { get; set; }
        public string SentimentAnalysisScore { get; set; }
    }
}
