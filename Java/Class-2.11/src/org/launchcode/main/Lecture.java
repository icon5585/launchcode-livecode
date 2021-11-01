package org.launchcode.main;

public class Lecture {
	/**
	 * Class 2.11 - Chapter 12 - Models & Model Binding - Hank DeDona
	 * 
	 * @param args arguments passed into app at runtime
	 */
	public static void main(String[] args) {
		// 12.1 Models in MVC (The M)
		// A model represents the logic for accessing and storing the data used in an application. 
		// Properly constructed, they do not depend on any controllers or views, which makes models easy to reuse without modification.

		// Model
		// Shapes data to fit the needs of an application.
		
		// View
		// Displays data to the user.
		
		// Controller
		// Directs the flow of information between the view and the model.
		
		// 12.1.3 Model Vs. Controller
		// What does a model do?
		// Model code defines the logic for processes that the user never needs to see. These include:

		// 1) The mechanics for storing data.
		// 2) The mechanics for retrieving data.
		// 3) The mechanics for organizing data.
		// 4) Updating or manipulating the data independent of any controller or view actions.
		
		// 12.2 Create a model
		// Refer to Event.java and index.html (under templates/events)
		
		// We create a new POJO (our model) to store the data for a given event called Event.java
		// We can then reference it in our thymeleaf template using event.name (this calls the getName() method getter)
		// as well as event.description (this calls the getDescription() method)
		
		// 12.3 Models & Data
		// Usually when we create a model class, we'll be persisting (storing) it in a database (or some other data store),
		// in order to do this we need to keep track of each model object (POJO) by giving it a unique ID (this would be a primary key in a DB)
		
		// Refer to Event.java (id & getId())
		
		// 12.3.4 - Create a fake DB (a data layer)
		// For this class, until we get into databases, we'll use a "Mock" database through the use of maps
		// Refer to EventData.java
		
		// 12.3.5 - Delete an event
		// In order to delete an event, we need to use that ID we just created as well as a new template (delete.html)
		// Refer to EventController.renderDeleteEventForm() and EventController.processDeleteEventsForm()
		
		// 12.4 - Model binding
		// Allowing spring to create a Model object on form submission.
		
		// This uses a new annotation, @ModelAttribute 
		// Refer to EventController.processCreateEventForm() - 
		
		// What is going on here is that Spring is automatically calling the constructor of the Event class for us
		// Your form value names MUST match the names of the variables in your Model Java classes!
	}

}
