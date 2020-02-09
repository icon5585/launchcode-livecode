package org.launchcode.main;

public class Lecture {
	/**
	 * Class 2.10 - 2/10/2020 - Chapter 11 - Thymeleaf - Hank DeDona
	 * 
	 * @param args arguments passed into app at runtime
	 */
	public static void main(String[] args) {
		// 11.1 Templates 
		// Allow for simple reuse of code "bits" in views (html/css/etc) front end components
		// Thymeleaf allows for creation of these templates and reuse
		// Allows for the following of the DRY (don't repeat yourself) principle 
		// Templates are not only for static content, you can pass in dynamic variables
		
		// Add the thymeleaf dependency to your existing hello-spring project build.gradle file
		// implementation 'org.springframework.boot:spring-boot-starter-thymeleaf'
		
		// 11.2.3 - Intro to templates (static)
		// All thymeleaf templates will reside in your src/main/resource/templates folder
		
		// Adding thymeleaf to an HTML file via XML namespaces
		// xmlns:th="http://www.thymeleaf.org/"
		// This allows you to use th:... for thymeleaf 
		
		// Updating our controller, see HelloController.helloForm()
		// Instead of returning a long HTML string, we return the string "form"
		// which refers to the name of the template "form.html" in our src/main/resource/templates folder
		
		// 11.3 - Using a template (dynamic)
		// 11.3.1 - Passing data
		// Remember MVC (Model, view, controller), passing data involves models!
		
		// We can do this one of two ways.
		// 1) Create our own model classes 
		// 2) Use the spring provided class literally called Model and add attributes to it!
		
		// Passing in data to the template and using it
		// th:text="${greeting}"			Note: ${} means that it's a variable
		
		// 11.3.2 - See HelloController.hello() and HelloController.helloAgain()
		
		// 11.4 - Iterating in a template
		// Just as we have iterated in Java using for loops, we can iterate in templates!
		// See hello-list.html thymeleaf template
		
		// For-each loops in thymeleaf
		// <th:each="name : ${names}">
		// Read this as for each name in the variable names ${names}

		// <th:block> 
		// Do this "block" of code for each loop
		
		// See HelloController.helloNames() and hello-list.html
		
		// 11.5 Conditionals in thymeleaf
		// By conditionals we really mean if/else statements
		// Note: I have no idea why the pre-work suddenly jumps into this unknown coffee project...
		
		// If statements in thymeleaf 
		// <th:if = "${condition}">
		
		// Else statements in thymeleaf (also called unless)
		// <th:unless = "${condition}">
		
		// 11.5.1.2 - What is true?
		// 1) If condition is a boolean or statement and true.
		// 2) If condition is a non-zero number or character.
		// 3) If condition is a string that is NOT "false", "off", or "no".
		// 4) If condition is a data type other than a boolean, number, character, or String
		
		// 11.5.1.4 - Logical operators (and, or, not)
		
		// AND
		// <th:if = "${condition1 and condition2 and...}">
		// Evaluates to true if ALL conditions are true
		
		// OR
		// <th:if = "${condition1 or condition2 or...}">
		// Evaluates to true if ANY condition is true
		
		// NOT
		// <th:if = "${!condition}">
		// Evaluates to true when condition is false
		// Note: same as in Java using an exclamation point for not!
		
		
		// 11.6 - Thymeleaf forms
		// Forms in thymeleaf are no different than any other HTML form, really
		// Still need a controller method to 
		// 1) Display the form to the user
		// 2) Handle the post form request from the user with the input
		
		// Refer to EventController.displayCreateEventForm() and EventController.processCreateEventForm()
		// Note: The example is using a static list as a makeshift data layer to store the events
		
		// 11.7 - Thymeleaf Fragments
		// DRY - Don't Repeat Yourself
		// Fragments are "pieces" of code that you can reuse in your templates in many places so you don't have
		// to type the same code over and over again and only have to manage/update it in one place.
		
		// 11.7.1.1 - th:fragment
		// Thymeleaf fragment tag
		// <th:fragment = "fragmentName">
		
		// Refer to fragments.html where we created two fragments (in one file) called head and header (confusing, I know)
		
		// 11.7.1.2 - th:replace
		// <h1 th:replace = "fragments :: styledHeader">
		// This will replace this tag with the code from the fragments called styledHeader
		
		// If you look at our create.html you'll see the following:
		// <header th:replace="fragments :: header">
		// What this does is replace that one line with all the code from fragments.html fragment called header
		
		// 11.8 - Static Resources (src and href tags)
		// These tags are used to add static content to our thymeleaf templates such as pictures, videos, css and JS
		// Static resources are stored in the src/main/resources/static folder
		
		// 11.8.1.1 src
		// <img th:src = "@{/familyPhoto1.jpg}" />
		// The @ symbol is used to define a FILE PATH
		
		// 11.8.1.2 href
		// Usually used for CSS and JS files
		
		// Note: Will automatically look in the static folder under src/main/resources
		// <link rel="stylesheet" th:href="@{/styles.css}">			- CSS
	    // <script th:src="@{/script.js}"></script>					- JS
		// Again, the @ symbol is for file paths
		
		// 11.9 - Bootstrap
		// Ugh... Everybody loves bootstrap, it's a commonly used styling library (mostly CSS)
		// It requires you to add certain (specific) class tags to your HTML elements in order to be styled
		
		// e.g. btn btn-primary - This will style a button a certain way (a primary button)
		
		// 11.9.2 Adding Bootstrap to your project...
		// https://www.bootstrapcdn.com
		
		// Note: Latest version as of 2/9/2020 is 4.4.1 and you need both their CSS and JS files!
		// <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
		// <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
		
		// Almost everything with bootstrap is based of CSS classes 
		
		// This will do some basic styling to your body of your HTML (pretty much everything)
		// <body class="container">
		
		// Navigation bar
		// <ul class="nav"> and <li class="nav-item">
		
		// There are numerous other CSS classes in bootstrap: table, btn, btn-success, nav-link, form-group, form-control, etc
		// Refer to the html classes for some examples
		
	}
}
