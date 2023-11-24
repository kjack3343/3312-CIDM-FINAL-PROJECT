using System;

namespace _3312_CIDM_FINAL_PROJECT.Models{
    public class Play
{
    public int PlayID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    // Navigation property for the many-to-many relationship
    public ICollection<Playbook> Playbooks { get; set; }
}
}