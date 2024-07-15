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

1. In ra thông tin mã đơn hàng, tên khách hàng và tên sản phẩm đầu tiên trong đơn hàng đó. Nếu đơn hàng không có sản phẩm thì "tên sản phẩm đầu tiên trong đơn hàng đó" sẽ là "Không có sản phẩm". 

2. In ra thông tin mã đơn hàng, tên khách hàng và tên sản phẩm cuối cùng trong đơn hàng đó. Tìm tên của sản phẩm cuối cùng trong mỗi đơn hàng. Nếu đơn hàng không có sản phẩm thì "tên sản phẩm đầu tiên trong đơn hàng đó" sẽ là "Không có sản phẩm".

3. In ra thông tin mã đơn hàng, tên khách hàng và tên sản phẩm duy nhất trong đơn hàng đó. Tìm tên của sản phẩm duy nhất trong mỗi đơn hàng. Nếu đơn hàng có nhiều hơn một sản phẩm thì "tên sản phẩm đầu tiên trong đơn hàng đó" sẽ là "Đơn hàng không hợp lệ". 

4. Tìm tên của sản phẩm có giá trị cao nhất trong từng đơn hàng. In ra thông tin mã đơn hàng, tên khách hàng và tên sản phẩm đó.

5. Tìm tên của sản phẩm duy nhất có giá trị thấp nhất trong từng đơn hàng. In ra thông tin mã đơn hàng, tên khách hàng và tên sản phẩm đó.

- tất cả dữ liệu trong [MOCK_Product.json](MOCK_Product.json) được generate từ trang web có tên là https://www.mockaroo.com/ 
- Nếu câu truy vấn của bạn không trả về kết quả mong muốn, hãy chỉnh sửa dữ liệu để kiểm tra tính đúng đắn của câu truy vấn.