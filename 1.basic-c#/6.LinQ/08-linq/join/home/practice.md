# Thực hành

- Đọc dữ liệu từ các file json được cung cấp ở thư mục cùng cấp

- [MOCK_DATA_Customers](MOCK_DATA_Customers.json)
- [MOCK_DATA_OrderDetails](MOCK_DATA_OrderDetails.json)
- [MOCK_DATA_Orders](MOCK_DATA_Orders.json)
- [MOCK_DATA_Products](MOCK_DATA_Products.json)

```csharp
using Newtonsoft.Json;

// Đường dẫn đến các file JSON
string customersFile = "MOCK_DATA_Customers.json";
string orderDetailsFile = "MOCK_DATA_OrderDetails.json";
string ordersFile = "MOCK_DATA_Orders.json";
string productsFile = "MOCK_DATA_Products.json";

// Đọc nội dung từ các file JSON
List<Customer> customers = ReadJsonFile<List<Customer>>(customersFile);
List<OrderDetail> orderDetails = ReadJsonFile<List<OrderDetail>>(orderDetailsFile);
List<Order> orders = ReadJsonFile<List<Order>>(ordersFile);
List<Product> products = ReadJsonFile<List<Product>>(productsFile);

// Hiển thị số lượng dữ liệu đã đọc được từ mỗi file
Console.WriteLine($"Số lượng khách hàng: {customers.Count}");
Console.WriteLine($"Số lượng chi tiết đơn hàng: {orderDetails.Count}");
Console.WriteLine($"Số lượng đơn hàng: {orders.Count}");
Console.WriteLine($"Số lượng sản phẩm: {products.Count}");

T ReadJsonFile<T>(string filePath)
{
    using (StreamReader file = File.OpenText(filePath))
    {
        JsonSerializer serializer = new JsonSerializer();
        return (T)serializer.Deserialize(file, typeof(T));
    }
}

public class Customer
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string MembershipStatus { get; set; }
    public DateTime LastPurchaseDate { get; set; }
    public int LoyaltyPoints { get; set; }
}


public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public int CustomerId { get; set; }
    public Shipping Shipping { get; set; }
}

public class Shipping
{
    public string Address { get; set; }
    public DateTime Date { get; set; }
}

public class OrderDetail
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}


public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public string Manufacturer { get; set; }
    public DateTime CreateDate { get; set; }
    public List<string> Category { get; set; }
}
```


1.  Tạo một danh sách gồm tên đầy đủ của khách hàng và tổng số đơn hàng mà mỗi khách hàng đã đặt. Sắp xếp giảm dần theo tổng số đơn hàng. (Giải bằng 2 cách: Join và GroupJoin)

2.  Lấy danh sách tên sản phẩm và tổng số lượng sản phẩm đã được đặt trong các đơn hàng. sảy ra trong năm 2019 & 2020

3.  Tạo danh sách gồm tên Nhà sản xuất và tên sản phẩm rẻ nhất của từng Nhà sản xuất.

4.  Đếm số lượng khách hàng theo từng loại thành viên và sắp xếp theo thứ tự giảm dần của số lượng.

5.  Liệt kê tất cả khách hàng đã đặt ít nhất một đơn hàng, và số lượng đơn hàng mà mỗi khách hàng đã đặt. Sắp xếp giảm dần theo đơn hàng giá trị nhất của mỗi khách hàng.

6.  Tạo một danh sách gồm tên đầy đủ của khách hàng, tổng giá trị đơn hàng của từng khách hàng và sắp xếp giảm dần theo tổng giá trị.

7.  Đếm số lượng sản phẩm theo từng loại danh mục và sắp xếp theo thứ tự tăng dần của số lượng.

8.  Liệt kê các đơn hàng có giá trị cao nhất của từng năm kèm với tên khách hàng đã đặt đơn hàng này.

9. Thống kê sản phẩm và tổng số lượng sản phẩm đã bán của từng nhà sản xuất, doanh thu của sản phẩm, sắp xếp theo doanh thu của sản phẩm tăng dần.

10. Tạo danh sách các sản phẩm có giá cao nhất trong từng danh mục và sắp xếp theo danh mục theo thứ tự bảng chữ cái.

11. Liệt kê các khách hàng đã mua sản phẩm từ năm 2020 trở đi, và tính tổng số tiền mỗi khách hàng đã chi tiêu. Chỉ lấy những khách hàng đã tiêu trên 250$. Sắp xếp danh sách theo tổng số tiền giảm dần.

12. Tính tổng số lượng sản phẩm và giá trị được đặt mỗi năm của từng sản phẩm.