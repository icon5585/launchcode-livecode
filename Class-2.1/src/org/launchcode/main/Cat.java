package org.launchcode.main;

public class Cat implements Cloneable {

	String name;

	public Cat() {
		this.name = "cat";
	}

	public Cat(String name) {
		this.name = name;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public static void makeNoise() {
		System.out.println("ROAR!");
	}

	public Cat clone() throws CloneNotSupportedException {
		return (Cat) super.clone();
	}

}
