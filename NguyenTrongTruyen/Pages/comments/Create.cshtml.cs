using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NguyenTrongTruyen.Data;
using Truyen.Models;

namespace NguyenTrongTruyen.Pages.comments
{
    public class CreateModel : PageModel
    {
        private readonly NguyenTrongTruyen.Data.TintucContext _context;

        public CreateModel(NguyenTrongTruyen.Data.TintucContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public comment comment { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        // public async Task<IActionResult> OnPostAsync()
        // {
        //     if (!ModelState.IsValid)
        //     {
        //         return Page();
        //     }

        //     _context.comment.Add(comment);
        //     await _context.SaveChangesAsync();

        //     return RedirectToPage("./Index");
        // }
        public async Task<IActionResult> OnPostAsync()
        {
            var emptycomment = new comment();

            if (await TryUpdateModelAsync<comment>(
                emptycomment,
                "comment",   // Prefix for form value.
                 s=>s.Author,s=>s.Content, s=>s.CreateAt))
            {
                _context.comments.Add(emptycomment);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            return Page();
        }
    }
}
