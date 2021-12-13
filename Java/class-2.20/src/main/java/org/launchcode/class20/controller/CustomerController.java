package org.launchcode.class20.controller;

import java.util.Arrays;
import java.util.List;

import org.launchcode.class20.model.Customer;
import org.launchcode.class20.model.Order;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RestController;

/**
 * Rest controller for {@link Customer}s and their {@link Order}s
 * 
 * @author Hank DeDona
 */
@RestController		// Convenience annotation that combines @Controller and @ResponseBody
public class CustomerController {

	/**
	 * Resource that produces an application/json representation of a customer
	 * 
	 * @return a JSON {@link Customer} object
	 */
	@GetMapping(path = "customer/{customerId}", produces = MediaType.APPLICATION_JSON_VALUE)
	public Customer getCustomer(@PathVariable String customerId) {

		Customer tempCust = new Customer();
		tempCust.setCustomerId(customerId);
		tempCust.setFirstName("Test");
		tempCust.setLastName("LastName");
		tempCust.setAddress("1 Test Ln");
		tempCust.setCity("Testville");
		tempCust.setZip(01234);

		Order order1 = new Order();
		order1.setOrderId("1");
		order1.setDescription("Something super cool");

		Order order2 = new Order();
		order2.setOrderId("2");
		order2.setDescription("Something not quite as cool");

		List<Order> orders = Arrays.asList(order1, order2);

		tempCust.setOrders(orders);

		return tempCust;
	}

	/**
	 * Resource that produces an application/json representation of a customers
	 * order
	 * 
	 * @return a JSON {@link Order} object
	 */
	@GetMapping(path = "customer/{customerId}/orders/{orderId}", produces = MediaType.APPLICATION_JSON_VALUE)
	public Order getCustomerOrder(@PathVariable String customerId, @PathVariable String orderId) {

		Order tempOrder = new Order();
		tempOrder.setOrderId(orderId);
		tempOrder.setDescription("Whatever you want!");

		return tempOrder;
	}

}
