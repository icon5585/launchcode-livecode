package org.launchcode.main;

public class HelloWorld {

	// This variable is public, therefore accessible to anyone!
	public String message = "Hello World";

	// None for you, this message is private and mine alone!
	private String privateMessage = "My private message";

	// Notice... No main method!

	// Default constructor...
	// Even without coding this, it is provided for you by default by Java
	public HelloWorld() {
	}

	/**
	 * Public say hello
	 */
	public void sayHello() {
		String message = "Goodbye World";

		// Goodbye
		System.out.println(message);

		// This refers to "this" class or things in "this" class
		// in this class the message variable above
		// Hello
		System.out.println(this.message);
	}

	/**
	 * Package-private say hello
	 */
	void sayHelloDefaultAccessLevel() {
		// This is not public, anything not in the same package,
		// in this case (org.launchcode.main) cannot see this method
		System.out.println("Hellooooooo!");

		// public
		// protected
		// package-private (default)
		// private
	}

	protected void sayHelloProtectedAccessLevel() {
		// This is protected and can only be seen by this class and sub-classes of this
		// class
		System.out.println("Hello");
	}

	/**
	 * Private say hello
	 */
	private void sayHelloPrivateAcessLevel() {
		// Note: I get a compile warning when I don't use a private method since it can
		// ONLY be used within the class locally
		System.out.println(privateMessage);
	}

}
