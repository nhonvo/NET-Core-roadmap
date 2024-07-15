# Tính tổng diện tích các phòng trong từng căn nhà

-   Cho một danh sách các căn nhà, mỗi căn nhà có các thông tin về địa chỉ và danh sách các phòng trong đó.
-   Bạn cần tính tổng diện tích của các phòng trong từng căn nhà.
-   Kết quả sẽ được lưu vào một dictionary với key là địa chỉ của từng căn nhà và value là tổng diện tích của các phòng trong căn nhà đó.

```csharp
using Dumpify;

List<House> houses = new List<House>
{
    new House
    {
        Address = "123 Main St",
        Rooms = new List<Room>
        {
            new Room { Name = "Living Room", Area = 300 },
            new Room { Name = "Kitchen", Area = 150 },
            new Room { Name = "Bedroom", Area = 200 }
        }
    },
    new House
    {
        Address = "456 Elm St",
        Rooms = new List<Room>
        {
            new Room { Name = "Living Room", Area = 350 },
            new Room { Name = "Bedroom", Area = 180 }
        }
    }
};

Dictionary<string, double> totalAreaPerHouse = houses.ToDictionary(
                                                        house => house.Address,
                                                        house => house.Rooms.Sum(room => room.Area)
                                                      );
totalAreaPerHouse.Dump();

public class Room
{
    public string Name { get; set; }
    public double Area { get; set; }
}

public class House
{
    public string Address { get; set; }
    public List<Room> Rooms { get; set; }
}
```