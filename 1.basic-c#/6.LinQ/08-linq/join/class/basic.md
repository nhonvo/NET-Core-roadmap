# Thực hành


```csharp
using Dumpify;

List<Order> orders = new List<Order> {
    new Order { OrderId = 1, CustomerId = 1, Amount = 100 },
    new Order { OrderId = 2, CustomerId = 2, Amount = 200 },
    new Order { OrderId = 3, CustomerId = 1, Amount = 150 },
    new Order { OrderId = 4, CustomerId = 3, Amount = 250 }
};

List<Customer> customers = new List<Customer> {
    new Customer { CustomerId = 1, Name = "Alice", Address = "123 Main St" },
    new Customer { CustomerId = 2, Name = "Bob", Address = "456 Elm St" },
    new Customer { CustomerId = 3, Name = "Charlie", Address = "789 Maple St" }
};

// 1. Thực hiện join đơn hàng và khách hàng và in dữ liệu ra console để kiểm tra
// Dữ liệu bao gồm: CustomerId, Name, Address, OrderId, Amount

// 2. Tính số tiền đã tiêu trên mỗi khách hàng: CustomerId, Name, TotalAmountSpend, và sắp xếp theo số Tiền tiêu tăng dần

public class Order
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public decimal Amount { get; set; }
}

public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}
```