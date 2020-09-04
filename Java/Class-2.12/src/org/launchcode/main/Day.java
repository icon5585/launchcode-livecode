package org.launchcode.main;

public enum Day {

	   SUNDAY("Sunday", false),
	   MONDAY("Monday", true),
	   TUESDAY("Tuesday", true),
	   WEDNESDAY("Wednesday", true),
	   THURSDAY("Thursday", true),
	   FRIDAY("Friday", true),
	   SATURDAY("Saturday", false);

	   private final String displayName;
	   private final boolean weekday;

	   // Note: The constructor is NOT public because it's only called from within the enum class
	   Day (String displayName, boolean weekday) {
	      this.displayName = displayName;
	      this.weekday = weekday;
	   }

	   public String getDisplayName() {
	      return this.displayName;
	   }

	   public boolean isWeekday() {
	      return this.weekday;
	   }

	}
