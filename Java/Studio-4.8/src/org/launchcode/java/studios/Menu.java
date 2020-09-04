package org.launchcode.java.studios;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;

/**
 * Menu class
 * 
 * @author Hank DeDona
 *
 */
public class Menu {

	private List<MenuItem> menu;
	private LocalDateTime lastUpdated;

	/**
	 * Default constructor for the {@link Menu}
	 * 
	 */
	public Menu() {
		this.menu = new ArrayList<>();
		this.lastUpdated = LocalDateTime.now(); // Now
	}

	/**
	 * Add a {@link MenuItem} to the menu
	 * 
	 * @param menuItem the {@link MenuItem} to add, please not be null
	 */
	public void addMenuItem(MenuItem menuItem) {
		menu.add(menuItem);
		lastUpdated = LocalDateTime.now(); // update last updated to now
	}

	/**
	 * Remove a {@link MenuItem}from the menu
	 * 
	 * @param menuItemId the identifier from the menu to remove, please not be null
	 */
	public void removeMenuItem(int menuItemId) {
		for (int i = 0; i < menu.size(); i++) {
			if (menu.get(i).getMenuId() == menuItemId) {
				menu.remove(i);
				lastUpdated = LocalDateTime.now();
				break;
			}
		}
	}

	/**
	 * @return the menu of items
	 */
	public List<MenuItem> getMenu() {
		return menu;
	}

	/**
	 * @return the last {@link LocalDateTime} the menu was updated
	 */
	public LocalDateTime getLastUpdated() {
		return lastUpdated;
	}

}
