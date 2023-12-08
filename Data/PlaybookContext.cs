using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _3312_CIDM_FINAL_PROJECT.Models;

    public class PlaybookContext : DbContext
    {
        public PlaybookContext (DbContextOptions<PlaybookContext> options)
            : base(options)
        {
        }

        public DbSet<_3312_CIDM_FINAL_PROJECT.Models.Play> Play { get; set; } = default!;
    }
