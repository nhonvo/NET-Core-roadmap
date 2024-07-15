# Yêu cầu bài tập

-  Đọc dữ liệu từ file JSON chứa danh sách sản phẩm [MOCK_users](MOCK_users.json)
-  generate class từ file json https://json2csharp.com/


```csharp
// Đọc nội dung từ file JSON vào một chuỗi
using Newtonsoft.Json;

string jsonContent = File.ReadAllText("MOCK_users.json");

// Chuyển đổi chuỗi JSON thành đối tượng Order
List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonContent);

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string UserType { get; set; }
    public string City { get; set; }
}
```

## Các yêu cầu cần phải đạt được

1. Viết câu truy vấn để đếm số lượng người dùng trong từng loại UserType cùng với các thông tin : 
    - Tuổi lớn nhất trong mỗi loại UserType. 
    - Tuổi nhỏ nhất trong mỗi loại UserType. 
    - Độ tuổi trung bình của người dùng trong mỗi loại UserType.

2. Đếm số lượng người dùng theo từng `Gender`, và hiển thị thông tin:
    -   Sắp xếp kết quả theo giới tính (tăng dần).
    -   Tuổi lớn nhất trong mỗi giới tính.
    -   Tuổi nhỏ nhất trong mỗi giới tính.
    -   Độ tuổi trung bình của người dùng trong mỗi giới tính.

3. Nhóm người dùng theo `Age`, và sắp xếp kết quả theo số lượng thành viên mỗi nhóm (tăng dần).

4. Nhóm người dùng theo `City`, và đếm số lượng người dùng trong mỗi nhóm, sắp xếp theo tên thành phố (tăng dần).

5. NNhóm người dùng theo `City`, và đếm số lượng người dùng trong mỗi nhóm, chỉ lấy những nhóm có 3 người trở lên, sắp xếp theo tên thành phố (tăng dần).

6. Nhóm người dùng theo `Age`, và đếm số lượng thành viên trong nhóm, chỉ hiển thị nhóm có ít nhất 2 người.

- tất cả dữ liệu trong [MOCK_Product.json](MOCK_Product.json) được generate từ trang web có tên là https://www.mockaroo.com/ 
- Nếu câu truy vấn của bạn không trả về kết quả mong muốn, hãy chỉnh sửa dữ liệu để kiểm tra tính đúng đắn của câu truy vấn.