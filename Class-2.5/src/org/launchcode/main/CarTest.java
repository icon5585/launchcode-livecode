package org.launchcode.main;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertNotNull;
import static org.junit.Assert.assertTrue;
import static org.junit.Assert.fail;

import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.JUnit4;

/**
 * Class for testing the {@link Car} class
 * 
 * @author Hank DeDona
 *
 */
@RunWith(JUnit4.class)
public class CarTest {

	private static int numTestsRun = 0;

	// Concepts...
	// @BeforeClass, @Before, @After, @AfterClass, @Test & asserts...

	Car testCar;

	// THESE ARE ALL OPTIONAL!
	
	// Only run once for the entire test at the beginning
	@BeforeClass
	public static void setup() {
		System.out.println("Starting unit tests CarTest!");
	}

	// This code is run once before EVERY test!
	@Before
	public void init() {
		// Instantiate a new test car object
		testCar = new Car("Toyota", "Prius", 10, 50);
	}

	// This code is run once after EVERY test!
	@After
	public void finalize() {
		System.out.println("Test #" + ++numTestsRun + " run!"); // Q: What happens if I used numTestsRun++???
	}

	// Only run once for the entire test at the end
	@AfterClass
	public static void tearDown() {
		System.out.println("Finished running " + numTestsRun + " unit tests in class CarTest!");
	}

	// Test an empty test... Dunno why...
	@Test
	public void emptyTest() {
		assertEquals(10, 10, .001);
	}

	// Checks that the testCar (and therefore the constructor) worked
	@Test
	public void testNotNull() {
		assertNotNull(testCar);
	}

	// Check that the constructor sets gasTankLevel properly
	@Test
	public void testInitialGasTank() {
		assertEquals(10, testCar.getGasTankLevel(), .001);
	}

	// Check that the initial gas tank level is not 0
	@Test
	public void testInitialGasTankNotZero() {
		assertFalse(testCar.getGasTankLevel() == 0);
	}

	// Check that the initial gas tank level is 10
	@Test
	public void testInitialGasTankIs10() {
		assertTrue(testCar.getGasTankLevel() == 10);
	}

	// Checks that gasTankLevel is accurate after driving within tank range
	@Test
	public void testGasTankAfterDriving() {
		testCar.drive(50);
		assertEquals(9, testCar.getGasTankLevel(), .001);
	}

	// Checks that gasTankLevel is accurate after attempting to drive past tank
	// range
	@Test
	public void testGasTankAfterExceedingTankRange() {
		testCar.drive(501);
		assertEquals(testCar.getGasTankLevel(), 0, .001);
	}

	// Can't have more gas than tank size, expect an exception
	@Test(expected = IllegalArgumentException.class)
	public void testGasOverfillException() {
		testCar.addGas(5);
		fail("Shouldn't get here, car cannot have more gas in tank than the size of the tank");
	}

}
