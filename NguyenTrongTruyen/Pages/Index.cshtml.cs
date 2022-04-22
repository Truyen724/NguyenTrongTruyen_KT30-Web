using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Truyen.Models;
using Microsoft.EntityFrameworkCore;

namespace NguyenTrongTruyen.Pages;

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
