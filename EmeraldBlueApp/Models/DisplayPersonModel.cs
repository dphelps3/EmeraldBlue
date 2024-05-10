using System.ComponentModel.DataAnnotations;

namespace EmeraldBlueApp.Models
{
    public class DisplayPersonModel
    {
        [Required]
        [StringLength(15, ErrorMessage = "First name is too long.")]
        [MinLength(2, ErrorMessage = "First name cannot be smaller than 2 characters.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Last name is too long.")]
        [MinLength(2, ErrorMessage = "Last name cannot be smaller than 2 characters.")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
