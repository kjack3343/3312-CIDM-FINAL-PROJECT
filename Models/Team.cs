using System;

namespace _3312_CIDM_FINAL_PROJECT{
    public class Team
{
    public int TeamID { get; set; }
    public string Name { get; set; }= null!;
    // Navigation property for the many-to-many relationship
    public ICollection<Playbook> Playbooks { get; set; } = null!;
}
}