using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteApp.Models.ViewModels
{
    public class QuotesViewModel
    {
        public IQueryable<Quote> Quotes { get; set; }
        //public PageInfo PageInfo { get; set; }
    }
}
