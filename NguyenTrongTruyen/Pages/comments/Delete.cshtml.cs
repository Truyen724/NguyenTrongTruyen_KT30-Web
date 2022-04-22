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
    public class DeleteModel : PageModel
    {
        private readonly NguyenTrongTruyen.Data.TintucContext _context;

        public DeleteModel(NguyenTrongTruyen.Data.TintucContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            comment = await _context.comments.FindAsync(id);

            if (comment != null)
            {
                _context.comments.Remove(comment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
