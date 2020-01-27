package org.launchcode.main.cat.test;

import static org.junit.Assert.assertEquals;

import org.junit.Test;
import org.launchcode.main.cat.HouseCat;

public class CatTest {
	
	@Test
	public void inheritsSuperInFirstConstructor() {
	   HouseCat keyboardCat = new HouseCat("Keyboard Cat", 7);
	   assertEquals(7, keyboardCat.getWeight(), .001);
	}
}
