using System;

/**
 * LC 101 - Unit 2 
 * Class 2.15
 * Chapter 15 - ViewModels and Model Validation
 * Hank DeDona
 * 11/17/20
 */
namespace Class_2._15
{
    class Lecture
    {
        static void Main(string[] args)
        {
            // 15.1 ViewModels and Passing Data To/From Views
            // A ViewModel is a model class designed specifically to be used in a view.
            // ViewModels allow us to strongly-type our forms and add input validation :)

// Using the ViewBag brings with it some potential pitfalls including type-safety
// as well as spelling/naming

// 15.1.2 Refactoring the View/Controller
// In order to use a model inside of our razor views, we need a new annotation @model
// e.g. if we want a list of event objects in our razor view, we would do: @model List<Event>
// This replaces using the ViewBag we now can use Model

// 15.1.4 Adding a ViewModel
// A ViewModel is really no different (from a JOCO standpoint) from any other model.
// The difference is how it's used.

// 15.2 Server-side validation
// While less efficient, it is possible (and recommended) to do server-side validation, basically
// what this involves is taking in the values in a ViewModel as we have done before, then checking
// the properties after they get to the controller, and returning an error if some invalid input
// was provided.

// 15.3 Validation Attributes
// 15.3.1 Common Attributes

// [Required] - Specifies that a field cannot be null
// [Range] - Specifies the range of potential values of a numeric field.
// [StringLength] - Specifies the minimum and/or maximum length of a string field.
// [EmailAddress] - Specifies that a string field should conform to email formatting standards.

// 15.3.2.Defining Validation Messages
// When using validation attributes, you can defy a user-friendly error message
// e.g. [Required(ErrorMessage = "Username is required")]
// e.g. [StringLength(12, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 12 characters long")]

// 15.3.4 Applying Validation Attributes
// Refer to the AddEventViewModel class in the CodingEvents project
// The attributes are only 1/2 of the equation, we need to add the validation code to the controller

// 15.4 Validating Models in a Controller
// We need to take those Validation Attributes and check it against the ModelState in the controller
// ModelState.IsValid will check if the constraints on the model properties are met.

// 15.5 Validation and Views
// We have added validation attributes as well as checked to make sure the model state is valid, but
// we aren't showing the user any error messages!

// In order to display it to the user, we need to add something to our razor view
// asp-validation-for - This adds an HTML element to the page only if the validation fails
// for the model property you set it to.
// e.g. <span asp-validation-for="ContactEmail"></span> - only shows this if the ContactEmail is invalid

// 16.1 Enums
// Enums are beneficial when you have a finite number of options, they can be used in place of a string.
/* e.g.
  enum Day
    {
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
    }
*/


}
}
}
