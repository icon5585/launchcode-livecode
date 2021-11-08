package org.launchcode.main.files;

public class FlatFileSaver implements Saveable {

	@Override
	public void saveStuff(String stuff) {
		System.out.println("Saving stuff to a flat file!");
		System.out.println("Stuff: " + stuff);
	}

}
