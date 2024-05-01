var numbers = Enumerable.Range(1, 10).ToList();

int pageSize = 3;

int totalPages = (int)Math.Ceiling((double)numbers.Count / pageSize);

for (int i = 0; i < totalPages; i++)
{
    Console.WriteLine("Page index {0}:", i);

    var page = numbers.Skip(i * pageSize).Take(pageSize);

    foreach (var number in page)
    {
        Console.WriteLine(number);
    }

    Console.WriteLine();
}
