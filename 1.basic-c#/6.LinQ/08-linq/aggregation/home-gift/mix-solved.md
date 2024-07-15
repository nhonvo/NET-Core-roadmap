# Yêu cầu bài tập

-  Đọc dữ liệu từ file JSON chứa danh sách sản phẩm [MOCK_orders.json](MOCK_orders.json)
-   generate class từ file json https://json2csharp.com/


```csharp
// Đọc nội dung từ file JSON vào một chuỗi
using Newtonsoft.Json;

string jsonContent = File.ReadAllText("MOCK_orders.json");

// Chuyển đổi chuỗi JSON thành đối tượng Order
List< Order> myDeserializedClass = JsonConvert.DeserializeObject<List<Order>>(jsonContent);

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


1. Lấy danh sách các đơn hàng được đặt trong tháng 7 năm 2023 và sắp xếp chúng theo các quy tắc sau đây:
    - Sắp xếp các đơn hàng theo ngày đặt hàng từ cũ đến mới.
    - Nếu có nhiều đơn hàng có cùng ngày đặt, thì sắp xếp các đơn hàng đó theo tổng số lượng sản phẩm giảm dần.

```csharp
var ordersQuery = orders.Where(order => order.OrderDate.Year == 2023 && order.OrderDate.Month == 7)
                        .OrderBy(order => order.OrderDate)
                        .ThenByDescending(order => order.Items.Sum(item => item.Quantity))
                        .ToList();
```


2. Lấy danh sách các đơn hàng được đặt trong tháng 7 năm 2023 và chỉ lấy những đơn hàng có tổng giá trị (tính bằng giá sản phẩm nhân số lượng sản phẩm) lớn hơn 5000 đơn vị tiền tệ. Sau đó, sắp xếp các đơn hàng theo số lượng sản phẩm từ cao đến thấp.

```csharp
var ordersQuery = orders
                    .Where(order => order.OrderDate.Year == 2023 && order.OrderDate.Month == 7)
                    .Where(order => order.Items.Sum(item => item.UnitPrice * item.Quantity) > 5000)
                    .OrderByDescending(order => order.Items.Sum(item => item.Quantity))
                    .Select(order => $"OrderNumber = {order.OrderNumber}, CustomerName = {order.Customer.FirstName} {order.Customer.LastName}, TotalQuantity = {order.Items.Sum(item => item.Quantity)}, TotalAmount = {order.Items.Sum(item => item.UnitPrice * item.Quantity)}")
                    .ToList();
ordersQuery.Dump();
```


```bash
OrderNumber = 23, CustomerName = Tanny Doyle, TotalQuantity = 234, TotalAmount = 100047
OrderNumber = 472, CustomerName = Dinny Giraudeau, TotalQuantity = 168, TotalAmount = 77445
OrderNumber = 147, CustomerName = Cobby Storrock, TotalQuantity = 118, TotalAmount = 38437
```


3. Lấy danh sách các đơn hàng được đặt trong năm 2023 và chỉ lấy những đơn hàng có tổng số lượng sản phẩm (lớn hơn hoặc bằng 4). Sau đó, sắp xếp các đơn hàng theo tổng giá trị của đơn hàng (tính bằng giá sản phẩm nhân số lượng sản phẩm) từ cao đến thấp.

```console
var ordersQuery = orders
                        .Where(order => order.OrderDate.Year == 2023)
                        .Where(order => order.Items.Sum(item => item.Quantity) >= 4)
                        .OrderByDescending(order => order.Items.Sum(item => item.UnitPrice * item.Quantity))
                        .Select(order => $"{order.OrderNumber}, {order.Customer.FirstName} {order.Customer.LastName}, {order.Items.Sum(item => item.UnitPrice * item.Quantity)}")
                        .ToList();

ordersQuery.Dump();
```

```console
413, Lelah Bownas, 144158       
437, Aime Renals, 130771         
494, Gerta Oherlihy, 124010      
362, Lexy Sokill, 109285         
95, Neel Rosewarne, 100278       
467, Christopher Boulding, 100109
23, Tanny Doyle, 100047          
186, Zach Abrahamsson, 84480     
472, Dinny Giraudeau, 77445      
1, Bale Hyman, 74962             
18, Maurise Wankel, 71601        
112, Ardelia Flory, 60581        
324, Gay Godspeede, 56709        
314, Harriett Gaiter, 53766      
26, Bonita Dudeney, 47418        
265, Byrann Tolwood, 40480       
147, Cobby Storrock, 38437       
425, Sumner Race, 35437          
209, Gayleen Dibsdale, 30716     
76, Yettie Devote, 20102         
452, Alvera Iban, 17698          
451, Elbert Normanville, 13598   
28, Jedidiah Winchcombe, 13102   
305, Immanuel McFaul, 2112       
```

4. Lấy danh sách các đơn hàng được đặt trong năm 2023 và chỉ lấy các thông tin sau của mỗi đơn hàng: số đơn hàng, tên khách hàng(cả firstName và lastName), và tổng số sản phẩm trong đơn hàng. Sau đó, sắp xếp các đơn hàng theo số sản phẩm từ nhiều đến ít

```csharp
var ordersQuery = orders
    .Where(order => order.OrderDate.Year == 2023)
    .OrderByDescending(order => order.Items.Sum(item => item.Quantity))
    .Select(order => $"OrderNumber = {order.OrderNumber}, Customer = {order.Customer.FirstName} {order.Customer.LastName}, Quantity = {order.Items.Sum(item => item.Quantity)}")
    .ToList();
```

- Kết quả

```console
OrderNumber = 362, Customer = Lexy Sokill, Quantity = 236         
OrderNumber = 112, Customer = Ardelia Flory, Quantity = 235       
OrderNumber = 23, Customer = Tanny Doyle, Quantity = 234          
OrderNumber = 26, Customer = Bonita Dudeney, Quantity = 205       
OrderNumber = 324, Customer = Gay Godspeede, Quantity = 205       
OrderNumber = 413, Customer = Lelah Bownas, Quantity = 202        
OrderNumber = 494, Customer = Gerta Oherlihy, Quantity = 201      
OrderNumber = 1, Customer = Bale Hyman, Quantity = 189            
OrderNumber = 437, Customer = Aime Renals, Quantity = 189         
OrderNumber = 186, Customer = Zach Abrahamsson, Quantity = 172    
OrderNumber = 472, Customer = Dinny Giraudeau, Quantity = 168     
OrderNumber = 467, Customer = Christopher Boulding, Quantity = 139
OrderNumber = 95, Customer = Neel Rosewarne, Quantity = 135       
OrderNumber = 147, Customer = Cobby Storrock, Quantity = 118      
OrderNumber = 28, Customer = Jedidiah Winchcombe, Quantity = 107  
OrderNumber = 305, Customer = Immanuel McFaul, Quantity = 88      
OrderNumber = 18, Customer = Maurise Wankel, Quantity = 87        
OrderNumber = 452, Customer = Alvera Iban, Quantity = 77          
OrderNumber = 425, Customer = Sumner Race, Quantity = 72          
OrderNumber = 314, Customer = Harriett Gaiter, Quantity = 58      
OrderNumber = 76, Customer = Yettie Devote, Quantity = 46         
OrderNumber = 265, Customer = Byrann Tolwood, Quantity = 46       
OrderNumber = 209, Customer = Gayleen Dibsdale, Quantity = 43     
OrderNumber = 451, Customer = Elbert Normanville, Quantity = 26   
```

5. Lấy danh sách các đơn hàng được đặt trong năm 2023 và chỉ lấy các thông tin sau của mỗi đơn hàng: số đơn hàng, tên khách hàng, tổng giá trị đơn hàng (tính bằng giá sản phẩm nhân số lượng sản phẩm), và địa chỉ giao hàng (chỉ lấy thành phố). Sau đó, sắp xếp các đơn hàng theo tổng giá trị đơn hàng từ cao đến thấp.

```csharp
var ordersQuery = orders
            .Where(order => order.OrderDate.Year == 2023)
            .OrderByDescending(order => order.Items.Sum(item => item.UnitPrice * item.Quantity))
            .Select(order => $"OrderNumber = {order.OrderNumber}, Customer = {order.Customer.FirstName} {order.Customer.LastName}, TotalOrderValue = {order.Items.Sum(item => item.UnitPrice * item.Quantity)}, ShippingCity = {order.ShippingAddress.City}")
    .ToList();
```

```console
OrderNumber = 413, Customer = Lelah Bownas, TotalOrderValue = 144158, ShippingCity = Amapala            
OrderNumber = 437, Customer = Aime Renals, TotalOrderValue = 130771, ShippingCity = Bindura             
OrderNumber = 494, Customer = Gerta Oherlihy, TotalOrderValue = 124010, ShippingCity = Leki             
OrderNumber = 362, Customer = Lexy Sokill, TotalOrderValue = 109285, ShippingCity = Henglian            
OrderNumber = 95, Customer = Neel Rosewarne, TotalOrderValue = 100278, ShippingCity = Pontevedra        
OrderNumber = 467, Customer = Christopher Boulding, TotalOrderValue = 100109, ShippingCity = Las Tablas 
OrderNumber = 23, Customer = Tanny Doyle, TotalOrderValue = 100047, ShippingCity = Millerovo            
OrderNumber = 186, Customer = Zach Abrahamsson, TotalOrderValue = 84480, ShippingCity = Andahuaylillas  
OrderNumber = 472, Customer = Dinny Giraudeau, TotalOrderValue = 77445, ShippingCity = Dushanbe         
OrderNumber = 1, Customer = Bale Hyman, TotalOrderValue = 74962, ShippingCity = Telbang                 
OrderNumber = 18, Customer = Maurise Wankel, TotalOrderValue = 71601, ShippingCity = Doumuhu            
OrderNumber = 112, Customer = Ardelia Flory, TotalOrderValue = 60581, ShippingCity = Muritiba           
OrderNumber = 324, Customer = Gay Godspeede, TotalOrderValue = 56709, ShippingCity = Masohi             
OrderNumber = 314, Customer = Harriett Gaiter, TotalOrderValue = 53766, ShippingCity = Yurimaguas       
OrderNumber = 26, Customer = Bonita Dudeney, TotalOrderValue = 47418, ShippingCity = Al `Udayn          
OrderNumber = 265, Customer = Byrann Tolwood, TotalOrderValue = 40480, ShippingCity = Bondowoso         
OrderNumber = 147, Customer = Cobby Storrock, TotalOrderValue = 38437, ShippingCity = Qorao'zak         
OrderNumber = 425, Customer = Sumner Race, TotalOrderValue = 35437, ShippingCity = Atalaia              
OrderNumber = 209, Customer = Gayleen Dibsdale, TotalOrderValue = 30716, ShippingCity = Pujijie         
OrderNumber = 76, Customer = Yettie Devote, TotalOrderValue = 20102, ShippingCity = Cimonyong           
OrderNumber = 452, Customer = Alvera Iban, TotalOrderValue = 17698, ShippingCity = Kuruman              
OrderNumber = 451, Customer = Elbert Normanville, TotalOrderValue = 13598, ShippingCity = Tonantins     
OrderNumber = 28, Customer = Jedidiah Winchcombe, TotalOrderValue = 13102, ShippingCity = Maloco        
OrderNumber = 305, Customer = Immanuel McFaul, TotalOrderValue = 2112, ShippingCity = Telbang           
```

6. Lấy danh sách các đơn hàng được đặt trong tháng 8 năm 2023 và chỉ lấy các thông tin sau của mỗi đơn hàng: số đơn hàng, tên khách hàng (được kết hợp từ FirstName và LastName), tổng số lượng sản phẩm trong đơn hàng, và tổng giá trị của đơn hàng (tính bằng giá sản phẩm nhân số lượng sản phẩm). Sau đó, sắp xếp các đơn hàng theo tổng giá trị từ cao đến thấp.

```csharp

var ordersQuery = orders
    .Where(order => order.OrderDate.Year == 2023 && order.OrderDate.Month == 8)
    .OrderByDescending(order => order.Items.Sum(item => item.UnitPrice * item.Quantity))
    .Select(order => $"OrderNumber = {order.OrderNumber}, Customer = {order.Customer.FirstName} {order.Customer.LastName}, TotalQuantity = {order.Items.Sum(item => item.Quantity)}, TotalOrderValue = {order.Items.Sum(item => item.UnitPrice * item.Quantity)}")
    .ToList();
```

```console
OrderNumber = 437, Customer = Aime Renals, TotalQuantity = 189, TotalOrderValue = 130771
OrderNumber = 324, Customer = Gay Godspeede, TotalQuantity = 205, TotalOrderValue = 56709
```

7. Lấy danh sách các đơn hàng được đặt trong năm 2023 và chỉ lấy các thông tin sau của mỗi đơn hàng: số đơn hàng, tên khách hàng (được kết hợp từ FirstName và LastName), tổng số lượng sản phẩm trong đơn hàng, và tổng giá trị của đơn hàng (tính bằng giá sản phẩm nhân số lượng sản phẩm). Chỉ lấy các đơn hàng có tổng giá trị lớn hơn 10000 đơn vị tiền tệ. Sau đó, sắp xếp các đơn hàng theo tổng số lượng sản phẩm từ cao đến thấp.

8. Lấy danh sách các đơn hàng được đặt trong năm 2023 và chỉ lấy các thông tin sau của mỗi đơn hàng: số đơn hàng, tên khách hàng (được kết hợp từ FirstName và LastName), và tổng giá trị của đơn hàng (tính bằng giá sản phẩm nhân số lượng sản phẩm). Sau đó, chỉ lấy các đơn hàng có tổng giá trị từ 5000 đến 10000 đơn vị tiền tệ và sắp xếp các đơn hàng này theo số đơn hàng từ lớn đến nhỏ.

9. Lấy danh sách các đơn hàng được đặt trong năm 2023 và chỉ lấy các thông tin sau của mỗi đơn hàng: số đơn hàng, tên khách hàng (được kết hợp từ FirstName và LastName), ngày đặt hàng, và tổng giá trị của đơn hàng (tính bằng giá sản phẩm nhân số lượng sản phẩm). Sau đó, chỉ lấy các đơn hàng có ngày đặt hàng vào thứ 2 (Monday) và sắp xếp các đơn hàng này theo ngày đặt hàng từ mới đến cũ.

10. Lấy danh sách các đơn hàng được đặt trong năm 2023 và chỉ lấy các thông tin sau của mỗi đơn hàng: số đơn hàng, tên khách hàng (được kết hợp từ FirstName và LastName), ngày đặt hàng, và tổng số lượng sản phẩm trong đơn hàng. Sau đó, chỉ lấy các đơn hàng có tổng số lượng sản phẩm lớn hơn 3 và sắp xếp các đơn hàng này theo ngày đặt hàng từ mới đến cũ.


- tất cả dữ liệu trong [MOCK_Product.json](MOCK_Product.json) được generate từ trang web có tên là https://www.mockaroo.com/ 
- Nếu câu truy vấn của bạn không trả về kết quả mong muốn, hãy chỉnh sửa dữ liệu để kiểm tra tính đúng đắn của câu truy vấn.