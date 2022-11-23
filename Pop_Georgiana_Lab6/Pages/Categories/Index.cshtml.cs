using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pop_Georgiana_Lab6.Data;
using Pop_Georgiana_Lab6.Models;

namespace Pop_Georgiana_Lab6.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Pop_Georgiana_Lab6.Data.Pop_Georgiana_Lab6Context _context;

        public IndexModel(Pop_Georgiana_Lab6.Data.Pop_Georgiana_Lab6Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }
        }
    }
}