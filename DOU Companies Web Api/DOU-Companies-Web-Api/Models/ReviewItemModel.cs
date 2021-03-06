﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOU
{
    public class ReviewItemModel
    {
        [Key]
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Text { get; set; }
        public string TranslatedText { get; set; }
        public float? Score { get; set; }
    }
}
