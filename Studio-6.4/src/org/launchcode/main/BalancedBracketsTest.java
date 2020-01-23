package org.launchcode.main;

import static org.junit.Assert.*;

import org.junit.Test;

public class BalancedBracketsTest {

	@Test
	public void emptyTest() {
		assertEquals(true, true);
	}

	@Test
	public void onlyBracketsReturnsTrue() {
		assertTrue(BalancedBrackets.hasBalancedBrackets("[]"));
	}

	@Test
	public void testHasBalancedBracketsTrueEmpty() {
		assertTrue(BalancedBrackets.hasBalancedBrackets(""));
	}

	@Test
	public void testHasBalancedBracketsTrue1() {
		assertTrue(BalancedBrackets.hasBalancedBrackets("[]"));
	}

	@Test
	public void testHasBalancedBracketsTrue2() {
		assertTrue(BalancedBrackets.hasBalancedBrackets("[LaunchCode]"));
	}

	@Test
	public void testHasBalancedBracketsTrue3() {
		assertTrue(BalancedBrackets.hasBalancedBrackets("Launch[Code]"));
	}

	@Test
	public void testHasBalancedBracketsTrue4() {
		assertTrue(BalancedBrackets.hasBalancedBrackets("Launch[Code]"));
	}

	@Test
	public void testHasBalancedBracketsTrue5() {
		assertTrue(BalancedBrackets.hasBalancedBrackets("[]LaunchCode"));
	}

	@Test
	public void testHasBalancedBracketsTrueNested() {
		assertTrue(BalancedBrackets.hasBalancedBrackets("[Launch[]Code]"));
	}

	@Test
	public void testHasBalancedBracketsFalse1() {
		assertFalse(BalancedBrackets.hasBalancedBrackets("[LaunchCode"));
	}

	@Test
	public void testHasBalancedBracketsFalse2() {
		assertFalse(BalancedBrackets.hasBalancedBrackets("["));
	}

	@Test
	public void testHasBalancedBracketsFalse3() {
		assertFalse(BalancedBrackets.hasBalancedBrackets("]"));
	}
}