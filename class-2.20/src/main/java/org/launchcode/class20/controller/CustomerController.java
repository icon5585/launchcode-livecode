package org.launchcode.class20.controller;

import java.util.Arrays;
import java.util.List;

import org.launchcode.class20.model.Customer;
import org.launchcode.class20.model.Order;
import org.springframework.http.MediaType;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
@RequestMapping("customer")
public class CustomerController {

	/**
	 * Resource that produces an application/json representation of a customer
	 * 
	 * @return
	 */
	@GetMapping(path = "{customer_id}", produces = MediaType.APPLICATION_JSON_VALUE)
	public Customer getCustomer(@PathVariable("customer_id") String customerId) {

		Customer tempCust = new Customer();
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
	 * @return
	 */
	@GetMapping(path = "{customer_id}/orders/{order_id}", produces = MediaType.APPLICATION_JSON_VALUE)
	public Order getCustomerOrder(@PathVariable("customer_id") String customerId,
			@PathVariable("order_id") String orderId) {

		Order tempOrder = new Order();
		tempOrder.setOrderId(orderId);
		tempOrder.setDescription("Whatever you want!");

		return tempOrder;
	}

}
