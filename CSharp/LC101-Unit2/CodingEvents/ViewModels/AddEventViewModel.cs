using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ViewModels
{
    public class AddEventViewModel
    {
        // 15.3.4 Validation attributes for name and description
        // ErrorMessage is the user-friendly message provided if the validation fails :(
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description for your event.")]
        [StringLength(500, ErrorMessage = "Description is too long!")]
        public string Description { get; set; }

        // Note: EmailAddress validation attribute makes sure it conforms to an email address using regular expressions
        [EmailAddress]
        public string ContactEmail { get; set; }

        public AddEventViewModel() {}
    }
}
