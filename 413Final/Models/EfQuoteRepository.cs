using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _413Final.Models
{
    public class EfQuoteRepository
    {
        private QuoteContext context { get; set; }
        public EfQuoteRepository(QuoteContext temp) => context = temp;

        public IQueryable<Quote> Quote => context.Quotes;

        public void SaveQuote(Quote q)
        {
            context.SaveChanges();
        }

        public void CreateQuote(Quote q)
        {
            context.Add(q);
            context.SaveChanges();

        }
        public void DeleteQuote(Quote q)
        {
            context.Remove(q);
            context.SaveChanges();
        }

    }
}
