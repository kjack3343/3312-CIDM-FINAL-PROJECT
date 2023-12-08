using System;
using System.ComponentModel.DataAnnotations;

namespace _3312_CIDM_FINAL_PROJECT.Pages
{
    public class Team
{
    public int TeamID { get; set; }
    [StringLength(30)]
    [Display]public string Name { get; set; }= null!;
    [Required]

   
    public int PlayID{get;set;} //foreign key
    public Play? Play{get;set;}//nav property

}
}