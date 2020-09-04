package org.launchcode.main.cat;

public class CatOwner {
	private Cat pet;

	   public CatOwner(Cat pet) {
	      this.pet = pet;
	   }

	   public void feedTheCat() {

	      // ...code to prepare the cat's meal...

	      pet.eat();
	   }
}
