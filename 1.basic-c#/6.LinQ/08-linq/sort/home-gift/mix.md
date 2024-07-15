# Yêu cầu bài tập

-  Đọc dữ liệu từ file JSON chứa danh sách sản phẩm [MOCK_car.json](MOCK_car.json)
- Giải thích ý nghĩa từng cột:

1.  **CarID**: ID của xe (số).
2.  **Make**: Hãng sản xuất xe (chuỗi).
3.  **Model**: Mẫu xe (chuỗi).
4.  **Year**: Năm sản xuất (số).
5.  **Price**: Giá xe (số thập phân).
6.  **Engine**: Thông tin động cơ (đối tượng).
    -   **EngineType**: Loại động cơ (chuỗi).
    -   **Displacement**: Dung tích xi lanh (số thập phân).
    -   **Horsepower**: Công suất (số thập phân).
7.  **Dimensions**: Kích thước xe (đối tượng).
    -   **Length**: Chiều dài (số).
    -   **Width**: Chiều rộng (số).
    -   **Height**: Chiều cao (số).
    -   **Wheelbase**: Chiều dài cơ sở (số).
8.  **Weight**: Trọng lượng xe (đối tượng).
    -   **CurbWeight**: Trọng lượng không tải (số).
    -   **GrossWeight**: Trọng lượng toàn tải (số).
9.  **Performance**: Hiệu suất xe (đối tượng).
    -   **TopSpeed**: Tốc độ tối đa (số).
    -   **ZeroToSixty**: Thời gian tăng tốc từ 0-60 mph (số thập phân).
10. **FuelCapacity**: Dung tích bình nhiên liệu (số thập phân).
11. **Mileage**: Số dặm đi được (đối tượng).
    -   **City**: Số dặm đi được trong thành phố (số).
    -   **Highway**: Số dặm đi được trên xa lộ (số).
12. **ColorsAvailable**: Các màu sắc có sẵn (mảng chuỗi).
13. **Warranty**: Thông tin bảo hành (đối tượng).
    -   **Duration**: Thời gian bảo hành theo tháng (số).
    -   **Coverage**: Số dặm bảo hành thoe mile (số).
14. **Owner**: Thông tin chủ sở hữu (đối tượng).
    -   **OwnerID**: ID của chủ sở hữu (số).
    -   **Name**: Tên chủ sở hữu (chuỗi).
    -   **Address**: Địa chỉ của chủ sở hữu (đối tượng).
        -   **Street**: Tên đường (chuỗi).
        -   **City**: Thành phố (chuỗi).
        -   **State**: Bang (chuỗi).
        -   **ZipCode**: Mã bưu điện (chuỗi).
15. **Description**: Mô tả chi tiết về xe (chuỗi dài).
16. **Features**: Các tính năng nổi bật của xe (chuỗi dài).
17. **AdditionalInfo**: Thông tin bổ sung về xe (chuỗi dài).
18. **ManufactureDate**: Ngày sản xuất xe (dạng ngày tháng).
19. **LastServiceDate**: Ngày bảo dưỡng gần nhất (dạng ngày tháng).
20. **PurchaseDate**: Ngày mua xe (dạng ngày tháng).

## Các yêu cầu cần phải đạt được

1. Lọc các xe hơi có màu sắc là 'Black' hoặc 'White', và sắp xếp chúng dựa trên năm sản xuất (tăng dần). Thông tin cần lấy bao gồm hãng sản xuất, mẫu xe, năm sản xuất và màu sắc.

2. Lấy danh sách các xe hơi có dung tích xi lanh trên 2.0, và sắp xếp chúng theo công suất giảm dần. Thông tin cần lấy bao gồm hãng sản xuất, mẫu xe, dung tích xi lanh và công suất.

3. Lọc các xe hơi có mức tiêu thụ nhiên liệu trong thành phố trên 25 mpg, và sắp xếp chúng theo thứ tự từ xe nhanh nhất đến xe chậm nhất (dựa trên tốc độ tối đa). Thông tin cần lấy bao gồm hãng sản xuất, mẫu xe, tốc độ tối đa và mức tiêu thụ nhiên liệu trong thành phố.

4. Lấy danh sách các xe hơi sản xuất sau năm 2010, có trọng lượng không tải dưới 3000 lbs, và sắp xếp chúng theo giá xe từ cao đến thấp. Thông tin cần lấy bao gồm hãng sản xuất, mẫu xe, năm sản xuất và giá xe.

5. Lấy danh sách các xe hơi có màu sắc là 'Red', 'Blue' hoặc 'Green', và sắp xếp chúng theo chiều cao từ thấp đến cao. Thông tin cần lấy bao gồm hãng sản xuất, mẫu xe, chiều cao và màu sắc.

6. Lấy danh sách các xe hơi có số dặm bảo hành trên 50000, và sắp xếp chúng theo thời gian bảo hành từ cao đến thấp. Thông tin cần lấy bao gồm hãng sản xuất, mẫu xe, thời gian bảo hành và số dặm bảo hành.

7. Lấy danh sách các xe hơi có thời gian bảo hành từ 30 đến 60 tháng, và sắp xếp theo hãng sản xuất từ A đến Z, sau đó theo mẫu xe từ A đến Z. Thông tin cần lấy bao gồm hãng sản xuất, mẫu xe và thời gian bảo hành.

8. Lấy danh sách các xe hơi có mức tiêu thụ nhiên liệu trên xa lộ từ 25 mpg trở lên, và sắp xếp theo mức tiêu thụ nhiên liệu trong thành phố từ cao đến thấp. Thông tin cần lấy bao gồm hãng sản xuất, mẫu xe, mức tiêu thụ nhiên liệu trên xa lộ và mức tiêu thụ nhiên liệu trong thành phố.

9. Lấy danh sách các xe hơi có dung tích xi lanh từ 1.5 trở lên, và sắp xếp theo dung tích xi lanh từ thấp đến cao, sau đó theo công suất từ cao đến thấp. Thông tin cần lấy bao gồm hãng sản xuất, mẫu xe, dung tích xi lanh và công suất.

10. Lấy danh sách các xe hơi có giá xe trên 50000 Rial, và sắp xếp theo giá xe từ cao đến thấp, sau đó theo năm sản xuất từ cao đến thấp. Thông tin cần lấy bao gồm hãng sản xuất, mẫu xe, năm sản xuất và giá xe

11. Lấy danh sách các xe hơi có số dặm đi được trên thành phố dưới 30, và sắp xếp theo số dặm đi được trên xa lộ từ cao đến thấp, sau đó theo năm sản xuất từ thấp đến cao. Thông tin cần lấy bao gồm hãng sản xuất, mẫu xe, số dặm đi được trên xa lộ và năm sản xuất.

12. Lấy danh sách các xe hơi có độ dài cơ sở từ 1700 đến 1900 mm, và sắp xếp theo độ rộng từ cao đến thấp, sau đó theo độ cao từ thấp đến cao. Thông tin cần lấy bao gồm hãng sản xuất, mẫu xe, độ rộng và độ cao.

13. Lấy danh sách các xe hơi có công suất từ 200 mã lực trở lên, và sắp xếp theo công suất từ cao đến thấp, sau đó theo dung tích xi lanh từ cao đến thấp. Thông tin cần lấy bao gồm hãng sản xuất, mẫu xe, công suất và dung tích xi lanh.

14. Lấy danh sách các xe hơi có mô tả dài hơn 500 ký tự, và sắp xếp theo độ dài mô tả từ cao đến thấp, sau đó theo năm sản xuất từ cao đến thấp. Thông tin cần lấy bao gồm hãng sản xuất, mẫu xe, độ dài mô tả và năm sản xuất.

15. Lấy danh sách các xe hơi mà ngày sản xuất sau ngày 1 tháng 1 năm 2000, và sắp xếp chúng theo ngày sản xuất từ mới đến cũ. Thông tin cần lấy bao gồm hãng sản xuất, mẫu xe và ngày sản xuất.

16. Lấy danh sách các xe hơi có ngày mua trong khoảng từ năm 2015 đến năm 2020, và sắp xếp theo ngày mua từ cũ đến mới. Thông tin cần lấy bao gồm hãng sản xuất, mẫu xe và ngày mua.

17. Lấy danh sách các xe hơi có ngày bảo dưỡng gần nhất sau ngày 1 tháng 1 năm 2022, và sắp xếp theo ngày bảo dưỡng từ gần nhất đến xa nhất. Thông tin cần lấy bao gồm hãng sản xuất, mẫu xe và ngày bảo dưỡng gần nhất.

18. Lấy danh sách các xe hơi có mức giá từ 20000 đến 60000 USD, có màu sắc là 'Black' hoặc 'White', và sắp xếp chúng theo năm sản xuất từ mới đến cũ, sau đó theo tên mẫu xe từ A-Z. Thông tin cần lấy bao gồm hãng sản xuất, mẫu xe, năm sản xuất, màu sắc và giá bán.

19. Lấy danh sách các xe hơi có số dặm bảo hành trên 40000 và thời gian bảo hành dưới 5 năm, và sắp xếp chúng theo thời gian bảo hành từ thấp đến cao, sau đó theo số dặm bảo hành từ cao đến thấp. Thông tin cần lấy bao gồm hãng sản xuất, mẫu xe, thời gian bảo hành và số dặm bảo hành.

20. Lấy danh sách các xe hơi có màu sắc là 'Red' hoặc 'Blue', và có thể chạy được trên 30 dặm một galon nhiên liệu trong thành phố, và sắp xếp chúng theo hiệu suất từ cao đến thấp, sau đó theo tên hãng sản xuất từ A-Z. Thông tin cần lấy bao gồm hãng sản xuất, mẫu xe, hiệu suất và màu sắc.

21. Lấy danh sách các xe hơi sản xuất sau năm 2010, có thể chạy được ít nhất 25 dặm một galon nhiên liệu trên xa lộ, và có giá bán từ 30000 USD trở lên. Sắp xếp các xe theo hiệu suất trên xa lộ từ cao đến thấp, sau đó theo năm sản xuất từ mới đến cũ. Thông tin cần lấy bao gồm hãng sản xuất, mẫu xe, hiệu suất trên xa lộ và năm sản xuất.

22. Lấy danh sách các xe hơi có trọng lượng không tải dưới 3000 lbs, có mức tiêu thụ nhiên liệu trong thành phố ít hơn 20 dặm một galon nhiên liệu, và có màu sắc là 'Silver'. Sắp xếp các xe theo mức tiêu thụ nhiên liệu trong thành phố tăng dần, sau đó theo trọng lượng không tải giảm dần. Thông tin cần lấy bao gồm hãng sản xuất, mẫu xe, mức tiêu thụ nhiên liệu trong thành phố và trọng lượng không tải.



- tất cả dữ liệu trong [MOCK_Product.json](MOCK_Product.json) được generate từ trang web có tên là https://www.mockaroo.com/ 
- Nếu câu truy vấn của bạn không trả về kết quả mong muốn, hãy chỉnh sửa dữ liệu để kiểm tra tính đúng đắn của câu truy vấn.