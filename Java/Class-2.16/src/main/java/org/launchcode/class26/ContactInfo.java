package org.launchcode.class26;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;

// 17.2.1 - Persistent Classes
@Entity // Signifies to JPA that this class represents an entity to be persisted
public class ContactInfo {

	// @Id represents an identifier, in the case of a DB - a primary key
	// @GeneratedValue means that it is generated for us (in the case of a MySQL DB column AUTO_INCREMENT)
	@Id
	@GeneratedValue
	private int id;

	private String name;

	private String email;

	// Default no-arg constructor
	public ContactInfo() {}
	
	public ContactInfo(String n, String e) {
		this.setName(n);
		this.setEmail(e);
	}	

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}
	
	@Override
	public String toString() {
		return "Name: " + getName() + "| Email: " + getEmail();
	}
}