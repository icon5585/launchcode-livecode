package org.launchcode.main.animal;

public class Dog extends Animal {

	@Override
	public void animalSound() {
		System.out.println("Woof!");
	}
	
	public void chaseSquirrel() {
		System.out.println("I'm gonna get the squirrel!");
	}

}
