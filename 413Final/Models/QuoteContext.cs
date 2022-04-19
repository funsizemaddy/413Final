using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _413Final.Models
{
    public class QuoteContext : DbContext
    {
        public QuoteContext()
        {

        }

        public QuoteContext(DbContextOptions<QuoteContext> options) :base(options)
        {

        }
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Quote>().HasData(
                new Quote { id = 1, quote = "There is no path to happiness; happiness is the path", author = "Buddha" },
                new Quote { id = 2, quote = "Do or do not. There is no try.", author = "Yoda" },
                new Quote { id = 3, quote = "There is no secrets to success. It is the resutl of preparation, hard work, and learning from failure",author="Colin Powell" }) ;
        }
    }
}
