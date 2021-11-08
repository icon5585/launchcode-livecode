package org.launchcode.main.files;

public class DatabaseSaver implements Saveable {

	@Override
	public void saveStuff(String stuff) {
		System.out.println("Saving stuff to a database!");
		System.out.println("Stuff: " + stuff);
	}

}
