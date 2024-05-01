
//
var fruits = new List<string> {
    "apple",
    "banana",
    "orange",
    "pineapple",
    "pineappl1",
    "mango"
};

var groupedByLength = fruits.GroupBy(f => f.Length);

foreach (var group in groupedByLength)
{
    Console.WriteLine($"group key {group.Key}");
    foreach (var item in group)
    {
        Console.WriteLine(item);
    }
}