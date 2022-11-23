using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pop_Georgiana_Lab6.Data;
using Pop_Georgiana_Lab6.Models;

namespace Pop_Georgiana_Lab6.Pages.Members
{
    public class CreateModel : PageModel
    {
        private readonly Pop_Georgiana_Lab6.Data.Pop_Georgiana_Lab6Context _context;

        public CreateModel(Pop_Georgiana_Lab6.Data.Pop_Georgiana_Lab6Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Member Member { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Member.Add(Member);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
