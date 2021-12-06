package org.launchcode.main;

public class Lecture {

	/**
	 * Class 2.19 - Chapter 19 - Authentication
	 * 
	 * Hank DeDona
	 * 
	 * @param args arguments passed into app at runtime
	 */
	public static void main(String[] args) {
		section19_1();
		section19_2();
		section19_3();
		section19_4();
		section19_5();
	}
	
	private static void section19_1() {
		// 19.1 - Authentication
		// Are the user the say they are? Not to be confused with authorization (do they have access to what they're requesting)
		
		// 19.1.2 - Simple auth flow
		// Every request to your web application your app will ask 2 questions
		// 1) Is the user asking for a restricted page?
		// 2) If so, do we know who they are?

		// Login Page --> Authentication --> Restricted Page (If auth successful)
		
		// 19.1.2.1 - Sessions and cookies
		
		// Session
		// Session data (can be) stored server-side.
		// Includes: Shopping carts, user is logged in, checkout process
		
		// Cookie
		// Small text that's stored in the users browser in key/value pairs
		
		// How does this work? When a user logs in, the server creates a session state and drops a cookie in the browser
		// session_id: 81LfWG9
		
		// Every request (assuming the same domain) to your web application will include this session ID so decisions can be made.
		// Reference: https://education.launchcode.org/java-web-development/chapters/auth/intro.html
		
		// 19.1.3 - Spring security
		// Spring security handles a lot of different authentication/authorization functionality, but is complicated and outside the 
		// scope of this bootcamp.
	}
	
	private static void section19_2() {
		// 19.2 Hashing Passwords
		
		// 19.2.1. Two-Way Encryption
		// This allows the encrypted data to be encoded and decoded (to get the original contents)
		// There are multiple types of two-way encryption, asymmetric and symmetric 
		// The difference is asymmetric uses two different keys (one to encrypt and one to decrypt) where symmetric uses the same for both
		
		// 19.2.2 One-Way Encryption (Hashing)
		// Hashing allows for data to be hashed (encrypted in a way) and nearly impossible to decode (decrypt)
		// Hashing also generates the same size hash regardless of input size
		
		// Functions of hashes:
		// 1) Deterministic
		// 2) Hard to reverse
		// 3) Hash values are ALMOST unique
		// 4) Similar messages have VERY different hash values
		
		// 19.2.3. Password Verification With Hashes
		// When storing user credentials in a database, it doesn't make sense to store the plain text password
		// It's much safer to store the hash (or better yet a salted hash), look up rainbow tables if you're curious why...
		// If the database is compromised, then the passwords are still safe!
		
		// 19.2.3.1 - Collisions
		// When two different input values produce the same hash, we have a collision (violating function 3)!
	}

	private static void section19_3() { 
		// 19.3
		// Refer to User.java and UserRepository.java in the coding-events project
	}
	
	private static void section19_4() {
		// 19.4 - Login and registration forms
		// Refer to AuthenticationController.java from the coding-events project for the majority of the code
	}
	
	private static void section19_5() {
		// 19.5 - Filtering requests in Spring
		// 19.5.1 - Request Filters
		// A request filter can be built by extending the spring class HandlerInterceptorAdapter
		
		// 3 methods can be overridden
		// preHandle - called before a request is handled by a controller
		// postHandle - called after a request is handled by a controller, but before the view is rendered
		// afterCompletion - called after the view is rendered
		
		// Filters are commonly used to "filter" requests to your web applications

		// Refer to AuthenticationFilter.java in coding-events project
		
		// preHandle dictates what happens to the request, if it returns true, then it continues on
		// otherwise you can redirect the request elsewhere (like /login for instance)
		
		// 19.5.2 - Whitelists
		// The thing about the filter is that it will be applied to ALL requests (including initial requests before a user logs in)
		// Therefore we need to have a whitelist of paths that are allowed to be accessed without authenticating
		
		// 19.5.3 - Registering your new filter!
		// Spring needs to know about your filter in order to apply it to all in-bound web application requests
		// Refer to WebApplicationConfig.java in the coding-events project
		// @Configuration - Annotation to define spring configuration
		// Override the  addInterceptors(InterceptorRegistry registry) method and add your filter! 
	}
}
