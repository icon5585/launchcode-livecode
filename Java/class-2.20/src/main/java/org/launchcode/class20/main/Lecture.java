package org.launchcode.class20.main;

public class Lecture {

	/**
	 * Class 2.20 - Chapter 20 - REST
	 * 
	 * Hank DeDona
	 * 
	 * @param args arguments passed into app at runtime
	 */
	public static void main(String[] args) {
		// REST or representational state transfer is an architectural 
		// style for providing standards between computer systems on the web.
		
		// REST allows for separate between the server (web server) providing services
		// and the application (web application or native) providing the UI to the user.
		
		// This means that the code on the client side can be changed at any time without affecting 
		// the operation of the server, and the code on the server side can be changed without 
		// affecting the operation of the client.
		
		// Stateful vs. stateless
		// When designing web services we attempt to (if at all possible) prefer stateless 
		// services over stateful. This allows us a few things:
		// 1) Don't have to manage state (user info, session info, etc) on a specific server
		// 2) Which allows for distributed web services over many servers without having to 
		// maintain state between them. This allows us to scale much more easily :)
		
		// Server & Client Communication - The backbone is HTTP
		// HTTP - Hypertext Transfer Protocol
		// Remember the HTTP verbs:
		// GET (Read)
		// POST (Create)
		// PUT (Update)
		// DELETE (Delete, obviously :P)
		
		// These can be mapped to the CRUD (Create, read, update, delete) verbs. Which are in parenthesis above.
		
		// HTTP Headers
		// Some specific headers are important to RESTful web services.
		
		// Accept
		// The accept header allows a client to tell the server what kind of response it expects back.
		// If the server supports it, then it will return a response with that MIME type. 
		// Examples:
		// text/html
		// application/json
		// image/png
		
		// If the server does not support the requested MIME type, it will throw an error 406 (not acceptable)
		
		// Content-Type
		// The content-type header allows a client to tell the server what kind of request it's making (when doing a 
		// POST or PUT).
		
		// It allows the client to tell the server what to expect in the POST/PUT body as far as formatting is concerned.
		// Examples:
		// application/x-www-form-urlencoded 
		// application/json
		// application/xml
		
		// If the server does not support the requested (provided) content-type, a 415 (Unsupported Media Type) 
		// error should be returned.
		
		// Paths
		// Paths are important in RESTful web services and allow your consumers (the applications using your services)
		// to easily navigate and successfully use your services.
		
		// The first part of the path is the resource (or controller if you prefer to think in that term)
		// Example: fashionboutique.com/customers/{customer_id} - This would be referring to the customers resource
		// The value after the resource could (should) be a customer identifier - we utilize these with the @PathParam annotation
		
		// You can have n deep paths afterward 
		// Example: fashionboutique.com/customers/{customer_id}/orders/{order_id} - This would provide information
		// for a given customers specific order
		
		// So how do we do this in Spring? 
		
		// We can use the convenience annotation @RestController instead of @Controller
		// This annotation combines the @Controller and @ResponseBody annotations into one!
		// This allows us to return JSON objects!
		
		// Refer to CustomerController.java, Customer.java and Order.java
		
	}
}
