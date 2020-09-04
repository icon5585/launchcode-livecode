package org.launchcode.main.cat;

// Notice that we declare this as an interface, not a class (also it must be public) 
public interface Feedable {

	// 8.2.1.1 Method Signatures
	// Things to note...
	// 1) ONLY provide the method signature (access modifier, return type, method name, and parameters)
	// 2) In the case of interfaces we don't provide the access modifier because ALL methods in an interface
	// are public by default
	// 3) As mentioned above, it must be declared an interface and be PUBLIC
	
	// This is what you'll normally see in an interface
	void eat();
	
	// 8.2.1.2 Static Methods
	// Note: You can have static methods in interfaces with actual implementations, but I rarely see them.
	static void doSomethingStupid() {
		System.out.println("I'm doing something stupid");
	}
	
	// 8.2.1.3 Default Methods
	// A default method has a body and is a fully-formed method. It is preceded with the default keyword, 
	// and it may be overridden by classes implementing the interface. DON'T USE THESE!!
	default void someOtherStupidMethod() {
        System.out.println("This method is also stupid, write a better interface next time");
    }

}
