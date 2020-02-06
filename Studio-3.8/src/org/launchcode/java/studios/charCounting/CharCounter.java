package org.launchcode.java.studios.charCounting;

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class CharCounter {
	// Test text
	private static final String TEST_TEXT = "This is some test text to be counted, woo!";

	/**
	 * Studio 3.8 - Character Counter - Hank DeDona - 1/8/2020
	 * 
	 * @param args program arguments
	 */
	public static void main(String[] args) {
		try (Scanner in = new Scanner(System.in)) {
			System.out.print("Enter some text to be counted or enter to use default text: ");
			String inputText = in.nextLine();
			if ("".equals(inputText)) {
				inputText = TEST_TEXT;
			}

			Map<Character, Integer> countedChars = countCharacters(inputText);

			System.out.println("Counting characters!");
			for (Map.Entry<Character, Integer> countedChar : countedChars.entrySet()) {
				System.out.println(countedChar.getKey() + ": " + countedChar.getValue());
			}
		} catch (Exception e) {
			System.err.println("Noooope!");
			System.exit(1);
		}
	}

	private static Map<Character, Integer> countCharacters(String inputText) {
		char[] charactersInString = inputText.toCharArray();
		Map<Character, Integer> countedChars = new HashMap<>();

		for (char curChar : charactersInString) {
			if (Character.isLetter(curChar)) {
				if (countedChars.containsKey(curChar)) {
					int curVal = countedChars.get(curChar);
					countedChars.put(curChar, curVal++);
				} else {
					countedChars.put(curChar, 1);
				}
			}
		}

		return countedChars;
	}

}
