using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NguyenTrongTruyen.Data;
using Truyen.Models;

namespace NguyenTrongTruyen.Pages.Categorys
{
    public class IndexModel : PageModel
    {
        private readonly NguyenTrongTruyen.Data.TintucContext _context;

        public IndexModel(NguyenTrongTruyen.Data.TintucContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Categorys.Take(10).ToListAsync();
        }
    }
}
