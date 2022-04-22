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
    public class DetailsModel : PageModel
    {
        private readonly NguyenTrongTruyen.Data.TintucContext _context;

        public DetailsModel(NguyenTrongTruyen.Data.TintucContext context)
        {
            _context = context;
        }

        public comment comment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            comment = await _context.comments.FirstOrDefaultAsync(m => m.ID == id);

            if (comment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
