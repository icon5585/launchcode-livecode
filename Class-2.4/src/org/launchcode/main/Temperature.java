package org.launchcode.main;

// 5.1.2 Static Fields
public class Temperature {
	private double fahrenheit;

	public static double absoluteZeroFahrenheit = -459.67;

	public double getFahrenheit() {
		return fahrenheit;
	}

	public void setFahrenheit(double fahrenheit) {

		if (fahrenheit < absoluteZeroFahrenheit) {
			throw new IllegalArgumentException("Value is below absolute zero");
		}

		this.fahrenheit = fahrenheit;
	}

	public void printAbsoluteZero() {
		// Both of these are wrong!
		System.out.println("Absolute zero in F is: " + absoluteZeroFahrenheit);

		// We can also be more explicit - This is wrong, don't do this...
		System.out.println("Absolute zero in F is: " + this.absoluteZeroFahrenheit);
	}
}
