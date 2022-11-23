using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pop_Georgiana_Lab6.Data;
using Pop_Georgiana_Lab6.Models;

namespace Pop_Georgiana_Lab6.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly Pop_Georgiana_Lab6.Data.Pop_Georgiana_Lab6Context _context;

        public DetailsModel(Pop_Georgiana_Lab6.Data.Pop_Georgiana_Lab6Context context)
        {
            _context = context;
        }

        public Author Author { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Author == null)
            {
                return NotFound();
            }

            var author = await _context.Author.FirstOrDefaultAsync(m => m.ID == id);
            if (author == null)
            {
                return NotFound();
            }
            else
            {
                Author = author;
            }
            return Page();
        }
    }
}