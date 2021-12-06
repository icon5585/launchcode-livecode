package org.launchcode.class26;

import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;

// 17.3.1 - CRUD Operations
@Controller
public class ContactInfoController {

	@Autowired
	private ContactInfoRepository repo;

	public ContactInfoController() {
	}

	public void saveFrank() {
		ContactInfo frank = new ContactInfo("Frank", "frank@email.com");
		repo.save(frank); // Should save Frank to the MySQL DB!
	}

	public void readAndUpdateFrank() {
		// READ
		Optional<ContactInfo> optionalFrank = repo.findById(1); // Find frank in the MySQL DB first

		// If we find Frank, lets update his email
		if (optionalFrank.isPresent()) {
			ContactInfo frank = optionalFrank.get();

			// Update his email
			frank.setEmail("franksnewemail@gmail.com");

			// Save (UPDATE)
			repo.save(frank);
		}
	}

	public void readAndDeleteFrank() {
		// READ
		Optional<ContactInfo> optionalFrank = repo.findById(1); // Find frank in the MySQL DB first

		// If we find Frank, lets delete him
		if (optionalFrank.isPresent()) {
			repo.delete(optionalFrank.get());

			// OR

			// repo.deleteById(1); // Can use primary key to delete as well
		}
	}

	// Note: This is hacked together!
	@GetMapping
	@ResponseBody
	public String index(@RequestParam String crudOperation) {
		if (crudOperation.equalsIgnoreCase("create")) {
			saveFrank();
		} else if (crudOperation.equalsIgnoreCase("update")) {
			readAndUpdateFrank();
		} else if (crudOperation.equalsIgnoreCase("delete")) {
			readAndDeleteFrank();
		} else if(crudOperation.equalsIgnoreCase("read")) {
			Optional<ContactInfo> optionalFrank = repo.findById(1); // Find frank in the MySQL DB first
			
			if(optionalFrank.isPresent()) {
				return optionalFrank.get().toString();
			} else {
				return "Frank not found!";
			}
		}

		return "Done";
	}

}
