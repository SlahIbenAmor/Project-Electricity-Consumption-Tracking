#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.Models;

public class ElectricalAppliance
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Category is required")]
    public string Category { get; set; }

    [Required(ErrorMessage = "Brand is required")]
    public string Brand { get; set; }

    [Required(ErrorMessage = "Quantity is required")]
    [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
    public int Quantity { get; set; }

    [Required(ErrorMessage = "Power is required")]
    [Range(1, int.MaxValue, ErrorMessage = "Power must be positive")]
    public int Power { get; set; }

    [Required(ErrorMessage = "Usage per day is required")]
    [Range(0, 24, ErrorMessage = "Usage per day must be between 0 and 24 hours")]
    public double UsagePerDay { get; set; }

    [Required]
    public int UserId { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public User? Owner { get; set; }
}