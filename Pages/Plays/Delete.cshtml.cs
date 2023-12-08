using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _3312_CIDM_FINAL_PROJECT;

namespace _3312_CIDM_FINAL_PROJECT.Pages.Plays
{
    public class DeleteModel : PageModel
    {
        private readonly PlaybookContext _context;

        public DeleteModel(PlaybookContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Play Play { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Play == null)
            {
                return NotFound();
            }

            var play = await _context.Play.FirstOrDefaultAsync(m => m.PlayID == id);

            if (play == null)
            {
                return NotFound();
            }
            else 
            {
                Play = play;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Play == null)
            {
                return NotFound();
            }
            var Plays = await _context.Play.FindAsync(id);

            if (Plays != null)
            {
                Play = Plays;
                _context.Play.Remove(Plays);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
