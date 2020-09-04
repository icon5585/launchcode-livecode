package org.launchcode.java.studios;

/**
 * Class representing a menu item
 * 
 * @author Hank DeDona
 *
 */
public class MenuItem {

	private final int menuId;
	private final String description;
	private final double price;
	private final MenuCategory category;
	private boolean isNew;

	/**
	 * Construct a {@link MenuItem}
	 * 
	 * @param menuId      the {@link MenuItem}s identifier
	 * @param description the {@link MenuItem}s description
	 * @param price       the price
	 * @param category    the {@link MenuCategory}
	 * @param isNew       whether or not the {@link MenuItem} is new
	 */
	public MenuItem(int menuId, String description, double price, MenuCategory category, boolean isNew) {
		this.menuId = menuId;
		this.description = description;
		this.price = price;
		this.category = category;
		this.isNew = isNew;
	}

	/**
	 * Construct a not-new (i.e. old) {@link MenuItem}
	 * 
	 * @param menuId      the {@link MenuItem}s identifier
	 * @param description the {@link MenuItem}s description
	 * @param price       the price
	 * @param category    the {@link MenuCategory}
	 */
	public MenuItem(int menuId, String description, double price, MenuCategory category) {
		this(menuId, description, price, category, false);
	}

	/**
	 * @return the {@link MenuItem}s description
	 */
	public String getDescription() {
		return description;
	}

	/**
	 * @return the {@link MenuItem}s price
	 */
	public double getPrice() {
		return price;
	}

	/**
	 * @return the {@link MenuItem}s {@link MenuCategory}
	 */
	public MenuCategory getCategory() {
		return category;
	}

	/**
	 * @return {@code true} if the {@link MenuItem} is new, {@code false} otherwise
	 */
	public boolean isNew() {
		return isNew;
	}

	/**
	 * @return the {@link MenuItem}s identifier
	 */
	public int getMenuId() {
		return menuId;
	}

	@Override
	public String toString() {
		return menuId + " " + description + " " + price + " " + category + " "
				+ (isNew ? "new menu item" : "old menu item");
	}

	@Override
	public boolean equals(Object o) {
		if (o == this) {
			return true;
		}
		if (o == null) {
			return false;
		}
		if (!(o instanceof MenuItem)) {
			return false;
		}

		MenuItem menuItem = (MenuItem) o;

		return this.getCategory() == menuItem.getCategory() && this.getDescription() == menuItem.getDescription()
				&& this.getMenuId() == menuItem.getMenuId() && this.getPrice() == menuItem.getPrice();
	}
}
