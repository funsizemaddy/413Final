using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _413Final.Models
{
    interface IQuoteRepository
    {
        IQueryable<Quote> quotes { get; }

        public void SaveQuote(Quote q);
        public void CreateQuote(Quote q);
        public void DeleteQuote(Quote q);
    }
}
