using System;
using _3312_CIDM_FINAL_PROJECT.Models;

namespace _3312_CIDM_FINAL_PROJECT{
    public class Playbook
{
    public int TeamID { get; set; }
    public int PlayID { get; set; }
    // Navigation properties
    public Team Team { get; set; }= null!;
    public Play Play { get; set; }= null!;
}
}