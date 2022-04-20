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

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //}
    }
}
