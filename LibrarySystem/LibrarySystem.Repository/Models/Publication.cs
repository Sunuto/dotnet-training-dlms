using System;
using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Repository.Models;

public class Publication : BaseEntity
{
    [Key]
    public int Id { get; set; } 
    [Required]
    public string Name { get; set; }
    [Required]
    public string? Address { get; set; }
    [Required]
    public string? ContactPersonName { get; set; }
    [Required]
    public string? ContactPhone { get; set; }
    [Required]
    public string? ContactEmail { get; set; }
    public string? Website { get; set; }
}