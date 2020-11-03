using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskWebApp.Data;
using MegaDeskWebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MegaDeskWebApp.Pages.Quotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskWebApp.Data.MegaDeskWebAppContext _context;

        public IndexModel(MegaDeskWebApp.Data.MegaDeskWebAppContext context)
        {
            _context = context;
        }


        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Book { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CustomerName { get; set; }
        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public IList<Quote> Quote { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            // using System 
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            NameSort = sortOrder == "Name" ? "name_desc" : "Name";

            IQueryable<Quote> quoteQuery = from s in _context.Quote
                                                   select s;

            var quotes = from m in _context.Quote
                             select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                quotes = quotes.Where(s => s.CustomerName.Contains(SearchString));
            }
            //switch case for sorting
            switch (sortOrder)
            {
                case "name_desc":
                    quotes = quotes.OrderBy(s => s.CustomerName);
                    break;
                case "Name":
                    quotes = quotes.OrderByDescending(s => s.CustomerName);
                    break;
                case "Date":
                    quotes = quotes.OrderBy(s => Convert.ToDateTime(s.QuoteDate));
                    break;
                case "date_desc":
                    quotes = quotes.OrderByDescending(s => Convert.ToDateTime(s.QuoteDate));
                    break;
                default:
                    quotes = quotes.OrderBy(s => s.ID);
                    break;
            }

            Quote = await _context.Quote.ToListAsync();
            Quote = await quotes.ToListAsync();

        }
    }
}
