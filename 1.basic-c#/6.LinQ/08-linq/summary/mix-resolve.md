# Đáp án

1. **Yêu cầu:** Lấy danh sách tất cả các sản phẩm đã được đánh giá (có review), sắp xếp theo thứ tự giảm dần của đơn giá sản phẩm (UnitPrice). Sau đó, chọn ra các đơn hàng có chứa ít nhất một sản phẩm có giá trị cao hơn 50, đồng thời tính tổng số lượng các sản phẩm trong từng đơn hàng đó. Cuối cùng, chỉ chọn những đơn hàng có tổng số lượng sản phẩm nhiều hơn 20, và sắp xếp kết quả theo thứ tự giảm dần của tổng số lượng sản phẩm.

**Kết quả cần in ra:** Mã đơn hàng, tên khách hàng, danh sách tên các sản phẩm đã được đánh giá (mỗi sản phẩm có đánh giá chỉ liệt kê một lần), và tổng số lượng các sản phẩm trong đơn hàng đó.



```csharp
var result = myDeserializedClass
    // Bước 1: Chọn các đơn hàng có chứa ít nhất một sản phẩm đã được đánh giá
    .Where(order => order.Items.Any(item => item.Reviews != null && item.Reviews.Count > 0))
    // Bước 2: Sắp xếp các sản phẩm theo đơn giá giảm dần
    .Select(order => new
    {
        order.OrderNumber,
        CustomerName = $"{order.Customer.FirstName} {order.Customer.LastName}",
        ReviewedProducts = order.Items
            .Where(item => item.Reviews != null && item.Reviews.Count > 0)
            .OrderByDescending(item => item.UnitPrice)
            .Select(item => item.ProductName)
            .Distinct()
            .ToList(),
        TotalQuantity = order.Items
            .Where(item => item.UnitPrice > 50)
            .Sum(item => item.Quantity)
    })
    // Bước 3: Chọn các đơn hàng có tổng số lượng sản phẩm lớn hơn 20
    .Where(order => order.TotalQuantity > 20)
    // Bước 4: Sắp xếp kết quả theo tổng số lượng sản phẩm giảm dần
    .OrderByDescending(order => order.TotalQuantity)
    .ToList();
```



2. Tìm thông tin các đơn hàng đã thanh toán bằng "Credit Card" có chứa ít nhất 2 sản phẩm được đánh giá từ 4 sao trở lên, và tổng giá trị các sản phẩm trong đơn hàng lớn hơn 5000. Chỉ hiển thị các đơn hàng có tổng giá trị lớn hơn 100,000. Sắp xếp kết quả theo tên khách hàng (tăng dần) và tổng giá trị đơn hàng (giảm dần). In ra các thông tin sau:
    - Mã đơn hàng
    - Tên khách hàng (Họ và tên)
    - Tổng giá trị đơn hàng
    - Phương thức thanh toán
    - Danh sách tên sản phẩm

```csharp
var result = myDeserializedClass
    .Where(order => order.Payment.PaymentMethod == "Credit Card" &&
                    order.Items.Count(item => item.Reviews.Any(review => review.Rating >= 4)) >= 2)
    .Select(order => new
    {
        OrderNumber = order.OrderNumber, // Mã đơn hàng
        CustomerName = $"{order.Customer.FirstName} {order.Customer.LastName}", // Tên khách hàng
        TotalOrderValue = order.Items.Sum(item => item.UnitPrice * item.Quantity), // Tổng giá trị đơn hàng
        PaymentMethod = order.Payment.PaymentMethod, // Phương thức thanh toán
        ProductNames = order.Items.Select(item => item.ProductName).ToList() // Danh sách tên sản phẩm
    })
    .Where(order => order.TotalOrderValue > 100000) // Chỉ lấy các đơn hàng có tổng giá trị lớn hơn 100_000
    .OrderBy(order => order.CustomerName) // Sắp xếp theo tên khách hàng
    .ThenByDescending(order => order.TotalOrderValue) // Sắp xếp theo tổng giá trị đơn hàng giảm dần
    .ToList().Dump();
```