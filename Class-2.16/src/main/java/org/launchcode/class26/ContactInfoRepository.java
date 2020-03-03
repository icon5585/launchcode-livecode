package org.launchcode.class26;

import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

// 17.2.2 - Repositories
// The @Repository annotation signals to JPA that this class handles CRUD methods for a given class
@Repository
//This is an example of Java Generics, in this case we are extending a CrudRepository Interface for a ContactInfo object identified by an Integer
public interface ContactInfoRepository extends CrudRepository<ContactInfo, Integer> {	
	// You may have noticed that this is an interface with no methods... but since it extends the interface CrudRepository 
	// it provides all the methods that we'll need for the CRUD methods for ContactInfo objects
}
