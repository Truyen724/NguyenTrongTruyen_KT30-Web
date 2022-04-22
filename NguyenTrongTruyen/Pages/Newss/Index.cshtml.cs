using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NguyenTrongTruyen.Data;
using Truyen.Models;

namespace NguyenTrongTruyen.Pages.Newss
{
    public class IndexModel : PageModel
    {
        private readonly NguyenTrongTruyen.Data.TintucContext _context;

        public IndexModel(NguyenTrongTruyen.Data.TintucContext context)
        {
            _context = context;
        }

        public IList<News> News { get;set; }

        public async Task OnGetAsync()
        {
            News = await _context.Newss.ToListAsync();
        }

    }
}
