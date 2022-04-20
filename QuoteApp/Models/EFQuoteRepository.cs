using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteApp.Models
{
    public class EFQuoteRepository : iQuoteRepository
    {
        private QuoteDbContext context { get; set; }

        public EFQuoteRepository(QuoteDbContext temp)
        {
            context = temp;
        }

        public IQueryable<Quote> Quotes => context.Quotes;
    }
}
