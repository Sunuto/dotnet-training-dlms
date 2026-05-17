using System;
using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Repository.Models;

public class Publication : BaseEntity
{
    [Key]
    public int PublicationId { get; set; } 
    [Required]
    public string PublicationName { get; set; }
    [Required]
    public string? PublicationAddress { get; set; }
    [Required]
    public string? PContactPersonName { get; set; }
    [Required]
    public string? PContactPhone { get; set; }
    [Required]
    public string? PublicationEmail { get; set; }
    public string? PublicationWebsite { get; set; }
}