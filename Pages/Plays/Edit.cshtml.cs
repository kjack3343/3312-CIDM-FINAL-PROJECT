using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _3312_CIDM_FINAL_PROJECT;

namespace _3312_CIDM_FINAL_PROJECT.Pages.Plays
{
    public class EditModel : PageModel
    {
        private readonly PlaybookContext _context;

        public EditModel(PlaybookContext context)
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

            var play =  await _context.Play.FirstOrDefaultAsync(m => m.PlayID == id);
            if (play == null)
            {
                return NotFound();
            }
            Play = play;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Play).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayExists(Play.PlayID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PlayExists(int id)
        {
          return (_context.Play?.Any(e => e.PlayID == id)).GetValueOrDefault();
        }
    }
}
