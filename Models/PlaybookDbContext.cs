using System;
using _3312_CIDM_FINAL_PROJECT.Models;
using Microsoft.EntityFrameworkCore;

namespace _3312_CIDM_FINAL_PROJECT{
    public class PlaybookDbContext : DbContext
{
    public DbSet<Team> Teams { get; set; }
    public DbSet<Play> Plays { get; set; }
    public DbSet<Playbook> Playbooks { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Playbook>()
            .HasKey(p => new { p.TeamID, p.PlayID });
        modelBuilder.Entity<Playbook>()
            .HasOne(p => p.Team)
            .WithMany(t => t.Playbooks)
            .HasForeignKey(p => p.TeamID);
        modelBuilder.Entity<Playbook>()
            .HasOne(p => p.Play)
            .WithMany(pl => pl.Playbooks)
            .HasForeignKey(p => p.PlayID);
    }
}
}