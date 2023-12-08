using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using _3312_CIDM_FINAL_PROJECT;

namespace _3312_CIDM_FINAL_PROJECT
{
    public class CreateModel : PageModel
    {
        
        private readonly PlaybookContext _context;

        public CreateModel(PlaybookContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Play Play { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Play == null || Play == null)
            {
                return Page();
            }

            _context.Play.Add(Play);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}