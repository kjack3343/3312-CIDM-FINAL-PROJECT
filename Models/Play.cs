using System;
using _3312_CIDM_FINAL_PROJECT.Pages;

namespace _3312_CIDM_FINAL_PROJECT{
    public class Play
{
    public int PlayID { get; set; } = default!;
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    // Navigation property for the many-to-many relationship
   
   public List<Team> Teams {get;set;} = new List<Team>();
}
}