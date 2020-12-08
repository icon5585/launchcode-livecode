using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CodingEvents.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        // Primary key of event categories
        [Required(ErrorMessage = "Category is required")]
        public int CategoryId { get; set; }

        // List of all available event categories (as select list items)
        public List<SelectListItem> Categories { get; set; }

        public AddEventViewModel() { }

        public AddEventViewModel(List<EventCategory> categories)
        {
            Categories = new List<SelectListItem>();

            // Generate the list of Select List Items based on the event categories from the DB
            foreach(EventCategory curCategory in categories)
            {
                Categories.Add(new SelectListItem
                {
                    Value = curCategory.Id.ToString(),
                    Text = curCategory.Name
                });
            }
        }
    }
}
