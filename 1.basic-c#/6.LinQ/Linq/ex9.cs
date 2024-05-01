// Create a list of customers
List<Customer> customers = new List<Customer>()
{
    new Customer() { Id = 1, Name = "John" },
    new Customer() { Id = 2, Name = "Jane" },
    new Customer() { Id = 3, Name = "Bob" }
};

// Create a list of orders
List<Order> orders = new List<Order>()
{
    new Order() { Id = 1, CustomerId = 1, TotalAmount = 50.00 },
    new Order() { Id = 2, CustomerId = 1, TotalAmount = 25.00 },
    new Order() { Id = 3, CustomerId = 3, TotalAmount = 100.00 }
};

// Join the collections based on the CustomerId property
var query = from order in orders
            join customer in customers
            on order.CustomerId equals customer.Id
            select new { customer.Name, order.TotalAmount };

var query1 = orders.Join(
    customers,
    orders => orders.CustomerId,
    customers => customers.Id,
    (orders, customers) => new
    {
        order = orders,
        customer = customers,
        orders.TotalAmount,
        customers.Name
    }
);
foreach (var item in query1)
{
    System.Console.WriteLine(item.customer.Id + ": " + item.order.CustomerId + " " + item.TotalAmount + " " + item.Name);
}

// Print the results
foreach (var result in query)
{
    Console.WriteLine("{0} placed an order on {1} ", result.Name, result.TotalAmount);
}

class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public double TotalAmount { get; set; }
}
