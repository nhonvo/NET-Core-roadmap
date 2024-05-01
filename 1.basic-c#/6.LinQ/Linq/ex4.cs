var numbers = new List<int> { 5, 1, 5, 1, 3, 3, 3, 3 };

var items = numbers.GroupBy(x => x)
                            .Select(x => new
                            {
                                Key = x.Key,
                                Count = x.Count()
                            });
                            
foreach (var group in items)
{
    Console.WriteLine($"group key {group.Key} count {group.Count}");
}