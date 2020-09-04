package org.launchcode.main;

public class Temperature {
	private double fahrenheit;

	public double getFahrenheit() {
		return fahrenheit;
	}

	public void setFahrenheit(double fahrenheit) {

		double absoluteZeroFahrenheit = -459.67;

		if (fahrenheit < absoluteZeroFahrenheit) {
			System.out.println("Value is below absolute zero");
		}

		this.fahrenheit = fahrenheit;
	}
	
	// 4.3.2.3 Properties (or variables or fields)
	// When getting or setting, we can do some manipulation instead of
	// just direct assignment or retrieval like below (we never actually store celsius)
	public double getCelsius() {
	    return (fahrenheit - 32) * 5.0 / 9.0;
	}

	public void setCelsius(double celsius) {
	    double fahrenheit = celsius * 9.0 / 5.0 + 32;
	    setFahrenheit(fahrenheit);
	}
}
