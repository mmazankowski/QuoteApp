using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 

namespace QuoteApp.Models
{
    public partial class Quote
    {
        [Key]
        [Required]
        public int QuoteId { get; set; }
        [Required]
        public string TheQuote { get; set; }
        [Required]
        public string Author { get; set; }

        public string Date { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Citation { get; set; }
    }
}
