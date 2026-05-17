using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Shared.AuthorData
{
    public class AuthorDetails
    {
        public int AuthorId { get; set; }
        [Required(ErrorMessage = "Please enter the name field.")]
        public string? FirstName { get; set; }
        [Required]
        public string? MiddleName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? Bio { get; set; }
        [Required]
        public DateOnly DateOfBirth { get; set; }
    }
}
