# Yêu cầu bài tập

-  Đọc dữ liệu từ file JSON chứa danh sách sản phẩm [MOCK_orders.json](MOCK_orders.json)
-   generate class từ file json https://json2csharp.com/


```csharp
// Đọc nội dung từ file JSON vào một chuỗi
using Newtonsoft.Json;

string jsonContent = File.ReadAllText("MOCK_orders.json");

// Chuyển đổi chuỗi JSON thành đối tượng Order
List<Order> myDeserializedClass = JsonConvert.DeserializeObject<List<Order>>(jsonContent);

Console.WriteLine();

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
}

public class BillingAddress
{
    public string Street { get; set; }
}

public class Customer
{
    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public Address Address { get; set; }
}

public class Item
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int UnitPrice { get; set; }
    public int Quantity { get; set; }
    public List<Review> Reviews { get; set; }
}

public class Payment
{
    public string PaymentMethod { get; set; }
    public string CardNumber { get; set; }
    public DateTime ExpirationDate { get; set; }
}

public class Review
{
    public int Rating { get; set; }
    public string Comment { get; set; }
    public string Reviewer { get; set; }
}

public class Order
{
    public int OrderNumber { get; set; }
    public DateTime OrderDate { get; set; }
    public Customer Customer { get; set; }
    public List<Item> Items { get; set; }
    public Payment Payment { get; set; }
    public string ShippingMethod { get; set; }
    public ShippingAddress ShippingAddress { get; set; }
    public BillingAddress BillingAddress { get; set; }
}

public class ShippingAddress
{
    public string Street { get; set; }
    public string City { get; set; }
}
```

Dưới đây là phân tích ý nghĩa từng cột trong đối tượng JSON cho đơn hàng:

1.  **OrderNumber**: Số đơn hàng, duy nhất cho mỗi đơn hàng để phân biệt các đơn hàng với nhau.

2.  **OrderDate**: Ngày và giờ đặt hàng, được định dạng theo chuẩn ISO 8601 ("yyyy-MM-ddTHH:mm").
3.  **Customer**: Thông tin chi tiết về khách hàng:

    -   **CustomerId**: Mã số khách hàng.
    -   **FirstName** và **LastName**: Tên và họ của khách hàng.
    -   **Email**: Địa chỉ email của khách hàng.
    -   **Phone**: Số điện thoại của khách hàng.
    -   **Address**: Địa chỉ của khách hàng bao gồm:
        -   **Street**: Đường phố.
        -   **City**: Thành phố hoặc thị trấn.
4.  **Items**: Danh sách các sản phẩm trong đơn hàng, mỗi sản phẩm bao gồm:

    -   **ProductId**: Mã số sản phẩm.
    -   **ProductName**: Tên sản phẩm.
    -   **UnitPrice**: Giá của mỗi đơn vị sản phẩm.
    -   **Quantity**: Số lượng sản phẩm được đặt mua.
    -   **Reviews**: Danh sách các đánh giá từ người dùng về sản phẩm, mỗi đánh giá bao gồm:
        -   **Rating**: Điểm đánh giá.
        -   **Comment**: Nhận xét về sản phẩm từ người dùng.
        -   **Reviewer**: Tên người đánh giá.
5.  **Payment**: Thông tin về phương thức thanh toán:

    -   **PaymentMethod**: Phương thức thanh toán (ví dụ: Debit Card, Credit Card, etc.).
    -   **CardNumber**: Số thẻ thanh toán, được che giấu phần quan trọng.
    -   **ExpirationDate**: Ngày hết hạn của thẻ thanh toán.
6.  **ShippingMethod**: Phương thức vận chuyển của đơn hàng (ví dụ: Next Day, Standard, etc.).

7.  **ShippingAddress**: Địa chỉ giao hàng của khách hàng:

    -   **Street**: Đường phố.
    -   **City**: Thành phố hoặc thị trấn.
    -   **ZipCode**: Mã bưu điện.
8.  **BillingAddress**: Địa chỉ thanh toán của khách hàng, bao gồm:

    -   **Street**: Đường phố.


## Các yêu cầu cần phải đạt được


1. **Yêu cầu:** Lấy danh sách tất cả các sản phẩm đã được đánh giá (có review), sắp xếp theo thứ tự giảm dần của đơn giá sản phẩm (UnitPrice). Sau đó, chọn ra các đơn hàng có chứa ít nhất một sản phẩm có giá trị cao hơn 50, đồng thời tính tổng số lượng các sản phẩm trong từng đơn hàng đó. Cuối cùng, chỉ chọn những đơn hàng có tổng số lượng sản phẩm nhiều hơn 20, và sắp xếp kết quả theo thứ tự giảm dần của tổng số lượng sản phẩm.

**Kết quả cần in ra:** Mã đơn hàng, tên khách hàng, danh sách tên các sản phẩm đã được đánh giá (mỗi sản phẩm có đánh giá chỉ liệt kê một lần), và tổng số lượng các sản phẩm trong đơn hàng đó.



2. Tìm thông tin các đơn hàng đã thanh toán bằng "Credit Card" có chứa ít nhất 2 sản phẩm được đánh giá từ 4 sao trở lên, và tổng giá trị các sản phẩm trong đơn hàng lớn hơn 5000. Chỉ hiển thị các đơn hàng có tổng giá trị lớn hơn 100,000. Sắp xếp kết quả theo tên khách hàng (tăng dần) và tổng giá trị đơn hàng (giảm dần). In ra các thông tin sau:
    - Mã đơn hàng
    - Tên khách hàng (Họ và tên)
    - Tổng giá trị đơn hàng
    - Phương thức thanh toán
    - Danh sách tên sản phẩm

- Nếu thấy quá khó khăn thì đáp án ở kế bên [Đáp án gợi ý](mix-resolve.md)

- tất cả dữ liệu trong [MOCK_orders.json](MOCK_orders.json) được generate từ trang web có tên là https://www.mockaroo.com/ 
- Nếu câu truy vấn của bạn không trả về kết quả mong muốn, hãy chỉnh sửa dữ liệu để kiểm tra tính đúng đắn của câu truy vấn.