using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibrarySystem.Shared.CategoryData
{
    public class CategoryDetails
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string? Description { get; set; }
    }
}
