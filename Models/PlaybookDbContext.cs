using System;
using _3312_CIDM_FINAL_PROJECT;
using _3312_CIDM_FINAL_PROJECT.Pages;
using Microsoft.EntityFrameworkCore;

namespace _3312_CIDM_FINAL_PROJECT{
    public class PlaybookDbContext : DbContext
{
    public PlaybookDbContext (DbContextOptions<PlaybookDbContext> options)
            : base(options)
        {
        }
   
    public DbSet<Play> Play { get; set; }
   public DbSet<Team> Teams {get;set;}
   
}
}