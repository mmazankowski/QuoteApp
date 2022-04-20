using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteApp.Models
{
    public interface iQuoteRepository
    {
        IQueryable<Quote> Quotes { get; }
    }
}
