package org.launchcode.studio;

public class MainRunner {

	public static void main(String[] args) {

		CD cd = new CD("CD example", 700, "CD-R", 350);
		DVD dvd = new DVD("DVD example", 4700, "DVD-R", 1450);

		cd.spinDisc();
		dvd.spinDisc();

		cd.readData();
		dvd.readData();

		System.out.println(cd.writeData(275));
		System.out.println(dvd.writeData(8000));

		System.out.println(cd.diskInfo());
		System.out.println(dvd.diskInfo());
	}

}
