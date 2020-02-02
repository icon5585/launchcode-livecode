package org.launchcode.studio;

public abstract class BaseDisc {
	private String name;
	private int storageCapacity;
	private int remainingCapacity;
	private int capacityUsed;
	
	public BaseDisc(String aName, int maxCapacity, String aType, int someUsedCapacity) {
		name = aName;
		storageCapacity = maxCapacity;
		capacityUsed = checkCapacity(someUsedCapacity);
		remainingCapacity = spaceLeft();
	}

	private int checkCapacity(int dataWritten) {
		if (storageCapacity < dataWritten) {
			return storageCapacity;
		}
		return dataWritten;
	}

	private int spaceLeft() {
		return storageCapacity - capacityUsed;
	}

	public String diskInfo() {
		String output = String.format(
				"\nDisk name: %s\nMax capacity: %d" + "\nSpace used: %d" + "\nAvailable space: %d\n", name,
				storageCapacity, capacityUsed, remainingCapacity);
		return output;
	}

	public String writeData(int dataSize) {
		if (dataSize > remainingCapacity) {
			return "Not enough disc space!";
		}
		capacityUsed += dataSize;
		remainingCapacity -= dataSize;

		return "Data written to disc. Remaining space = " + remainingCapacity;
	}

}
