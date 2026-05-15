using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Repository.Models;

public class LibraryLocation : BaseEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Aisle { get; set; }

    [Required]
    public string Shelf { get; set; }

    public string? Section { get; set; }

    public string? Floor { get; set; }

    public string? Description { get; set; }
}
