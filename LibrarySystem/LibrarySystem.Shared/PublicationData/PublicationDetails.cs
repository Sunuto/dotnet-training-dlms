using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibrarySystem.Shared.PublicationData
{
    public class PublicationDetails
    {
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
}
