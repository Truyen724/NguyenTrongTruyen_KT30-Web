using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NguyenTrongTruyen.Data;
using Truyen.Models;

namespace NguyenTrongTruyen.Pages.comments
{
    public class IndexModel : PageModel
    {
        private readonly NguyenTrongTruyen.Data.TintucContext _context;

        public IndexModel(NguyenTrongTruyen.Data.TintucContext context)
        {
            _context = context;
        }

        public IList<comment> comment { get;set; }

        public async Task OnGetAsync()
        {
            comment = await _context.comments.ToListAsync();
        }
    }
}
