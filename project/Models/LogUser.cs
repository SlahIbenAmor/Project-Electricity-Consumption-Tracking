#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace project.Models;
public class LogUser
{
    [Display(Name ="Email")]   
    public string LogEmail { get; set; } 
    [Required(ErrorMessage ="Password is required")]
    [Display(Name ="Password")]   
    [DataType(DataType.Password)]
    public string LogPassword { get; set; }

}
