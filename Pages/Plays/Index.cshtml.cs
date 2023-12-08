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
    public class IndexModel : PageModel
    {
        private readonly PlaybookContext _context;

        public IndexModel(PlaybookContext context)
        {
            _context = context;
        }

        public IList<Play> Play { get;set; } = default!;
 [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = default!;

        public async Task OnGetAsync()
            {
                var query =_context.Play.Select(p => p);
                switch (CurrentSort)
                {
                    case "first_asc":
                    query = query.OrderBy(p => p.Title);
                    break;
                    case "first_desc":
                    query = query.OrderByDescending(p => p.Title);
                    break;
                }
                Play = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
            }
    }
}