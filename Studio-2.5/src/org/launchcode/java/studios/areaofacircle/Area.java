package org.launchcode.java.studios.areaofacircle;

import java.util.Scanner;

public class Area {

	// 2.5.2
	public static void main(String[] args) {
		try (Scanner input = new Scanner(System.in)) {
			double radius = 0.0;
			do {
				System.out.print("Enter a radius: ");
				radius = input.nextDouble();
			} while (radius <= 0.0);
			System.out.println("The area of a circle of radius " + radius 
					+ " is: " + Circle.getArea(radius));
		} catch (Exception badThingsHappend) {
			System.err.println("Stop inputting garbage!!");
			badThingsHappend.printStackTrace();
		}
	}

}
