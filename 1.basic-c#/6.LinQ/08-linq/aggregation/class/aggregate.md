# Yêu cầu bài tập

-  Đọc dữ liệu từ file JSON chứa danh sách đơn hàng [MOCK_DATA_orders](MOCK_DATA_orders.json)
-   generate class từ file json https://json2csharp.com/

```csharp
using Dumpify;
using Newtonsoft.Json;

string jsonContent = File.ReadAllText("MOCK_DATA_orders.json");

// Chuyển đổi chuỗi JSON thành đối tượng Order
List<Order> orders = JsonConvert.DeserializeObject<List<Order>>(jsonContent);

// Yêu cầu 1: Đếm số lượng sản phẩm trong từng đơn hàng và in ra thông tin mã đơn hàng, tên khách hàng, và số lượng sản phẩm
var productCounts = orders.Select(order => $"OrderId = {order.OrderId}, NameOfCustomer = {order.NameOfCustomer}, Products Count = {order.Products.Count}");

productCounts.Dump();

public class Order
{
    public int OrderId { get; set; }
    public string NameOfCustomer { get; set; }
    public List<Product> Products { get; set; }
}

public class Product
{
    public string ProductId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}
```

1. Tính tổng giá trị của từng đơn hàng và in ra thông tin mã đơn hàng, tên khách hàng, và tổng giá trị đơn hàng này.

2. Tìm sản phẩm có giá trị thấp nhất trong từng đơn hàng và in ra thông tin mã đơn hàng, tên khách hàng, và tên sản phẩm có giá trị thấp nhất.

3. Tìm giá trị sản phẩm đắt nhất trong từng đơn hàng và in ra thông tin mã đơn hàng, tên khách hàng, và tên sản phẩm có giá trị cao nhất.

4. Tính tổng giá trị của từng đơn hàng và in ra thông tin mã đơn hàng, tên khách hàng và tổng giá trị đơn hàng này.

5. Tìm giá trị sản phẩm rẻ nhất trong từng đơn hàng và in ra thông tin mã đơn hàng, tên khách hàng và giá trị sản phẩm rẻ nhất.

6. Liệt kê tên của các sản phẩm trong từng đơn hàng và in ra thông tin mã đơn hàng, tên khách hàng, và tên các sản phẩm trong đơn hàng gác nhau bằng dấu phẩy

7. Tính số lượng sản phẩm có giá trị lớn hơn 500 trong từng đơn hàng và in ra thông tin mã đơn hàng, tên khách hàng, và số lượng sản phẩm có giá trị lớn hơn 500.


- tất cả dữ liệu trong [MOCK_Product.json](MOCK_Product.json) được generate từ trang web có tên là https://www.mockaroo.com/ 
- Nếu câu truy vấn của bạn không trả về kết quả mong muốn, hãy chỉnh sửa dữ liệu để kiểm tra tính đúng đắn của câu truy vấn.