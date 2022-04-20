using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QuoteApp.Models
{
    public class QuoteDbContext : DbContext
    {
        //Constructor
        public QuoteDbContext(DbContextOptions<QuoteDbContext> options) : base (options)
        {
        }

        public DbSet<Quote> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Quote>().HasData(

                new Quote
                {
                    QuoteId = 1,
                    TheQuote = "I've had enough trouble for a lifetime",
                    Author = "Harry Potter",
                    Date = "07/30/1997",
                    Subject = "Contentment",
                    Citation = "983jf9skdhjf93"
                },
                new Quote
                {
                    QuoteId = 2,
                    TheQuote = "Whether you think you can or you can't, you're right!",
                    Author = "Henry Ford",
                    Date = "05/01/1904",
                    Subject = "Inspirational",
                    Citation = "3c9j390192r3ss3"
                },
                new Quote
                {
                    QuoteId = 3,
                    TheQuote = "Fortune favors the brave",
                    Author = "Virgil",
                    Date = "01/01/1500",
                    Subject = "Inspirational",
                    Citation = "192f9djrk939283j3"
                },
                new Quote
                {
                    QuoteId = 4,
                    TheQuote = "Out of the mountain of despair, a stone of hope",
                    Author = "Martin Luther King Jr.",
                    Date = "06/18/1972",
                    Subject = "Faith",
                    Citation = "234k39fj3k3"
                },
                new Quote
                {
                    QuoteId = 5,
                    TheQuote = "It is our choices that show what we truly are, far more than our abilities",
                    Author = "Albus Dumbledore",
                    Date = "07/07/1994",
                    Subject = "Inspirational",
                    Citation = "a3jsdf034uikf932"
                },
                new Quote
                {
                    QuoteId = 6,
                    TheQuote = "If you can dream it, you can do it",
                    Author = "Walt Disney",
                    Date = "02/12/1950",
                    Subject = "Motivational",
                    Citation = "s0993jf9j2k22"
                }
            );
        }
    }
}
