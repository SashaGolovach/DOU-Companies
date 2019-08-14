using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DOU_Companies_Web_Api.Models
{
    public partial class ReviewItemModel
    {
        [Key]
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Text { get; set; }
        public string TranslatedText { get; set; }
        public float? Score { get; set; }
    }
}
