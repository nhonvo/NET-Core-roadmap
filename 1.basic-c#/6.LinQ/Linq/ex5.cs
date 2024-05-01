List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
var result = numbers.GroupBy(x => x % 2)
                    .Select(x => new
                    {
                        x.Key,
                        sum = x.Sum()
                    });
foreach (var number in result)
{
    System.Console.WriteLine(number.Key + " " + number.sum);
}