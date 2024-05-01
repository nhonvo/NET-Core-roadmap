
class Program
{
    static int SumOfOddNumbers(List<int> numbers)
    {
        return numbers.Where(i => i % 2 == 0).Sum();
    }
    static List<string> DistinctRepeatedWords(List<string> words)
    {
        return words.GroupBy(x => x)
                        .Where(x => x.Count() > 1)
                        .Select(x => x.Key)
                        .ToList();
    }
    static Dictionary<string, decimal> TotalPriceByCategory(List<Product> products)
    {
        return products.GroupBy(p => p.Category)
                        .ToDictionary(g => g.Key, g => g.Sum(p => p.Price));
    }
    static (DateTime earliestDate, DateTime latestDate) GetEarliestAndLatestDates(List<DateTime> dates)
    {
        DateTime earliestDate = dates.Max();
        DateTime latestDate = dates.Min();
        return (earliestDate, latestDate);
    }
    static List<int> TopFiveHighestNumbers(List<int> numbers)
    {
        return numbers.OrderDescending().Take(5).ToList();
    }
    static string LongestWord(List<string> words)
    {
        return words.OrderByDescending(x => x.Length).FirstOrDefault().ToString();
    }
    static List<string> CustomersInCitiesStartingWithA(List<Customer> customers)
    {
        return customers.Where(c => c.City.ToUpper().StartsWith('A'))
                                                               .Select(x => x.Name)
                                                               .ToList();
    }
    static Dictionary<int, int> CountOfEachNumber(List<int> numbers)
    {
        int sum = 0;
        return numbers.GroupBy(x => x)
                     .ToDictionary(g => g.Key, g => sum = g.Count());
    }
    static Dictionary<string, decimal> AveragePriceByCategory(List<Product> products)
    {
        return products.GroupBy(p => p.Category)
                                                  .ToDictionary(g => g.Key, g => g.Average(p => p.Price));
    }
    static List<string> WordsContainingZ(List<string> words)
    {
        return words.Where(x => x.ToLower().Contains('z')).ToList();
    }
    public static void Main(string[] args)
    {

        List<int> numbers = new List<int>() { 1, 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // int SumOfOddNumbers(List<int> numbers) 
        // Given a list of integers, write a method to return the sum of all odd numbers in the list.
        int sum = SumOfOddNumbers(numbers);
        System.Console.WriteLine(sum);
        // List<string> DistinctRepeatedWords(List<string> words) -
        // Given a list of strings, write a method to return the distinct words that appear more than once in the list.
        List<string> words = new List<string>() { "dog", "dog", "fish", "pig", "zuka" };
        var distinctWords = DistinctRepeatedWords(words);
        foreach (var d in distinctWords)
        {
            System.Console.WriteLine(d);
        }
        // Dictionary«string, decimal > TotalPriceByCategory(List<Product> products)'
        // Given a list of products with a "Category" & "Price" property, write a method to return a dictionary where the
        // keys are the category names and the values are the total price of all products in that category.
        List<Product> products = new List<Product>()
        {
            new Product {  Category = "Category 1", Price = 10.0m },
            new Product {  Category = "Category 1", Price = 17.0m },
            new Product {  Category = "Category 2", Price = 21.0m },
            new Product {  Category = "Category 3", Price = 5.0m },
            new Product {  Category = "Category 3", Price = 1.5m }
        };

        var totalPriceByCategory = TotalPriceByCategory(products);

        foreach (KeyValuePair<string, decimal> pair in totalPriceByCategory)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
        // (DateTime earliestDate, DateTime latestDate) GetEar1iestAndLatestDates(List<DateTime> dates)'
        // Given a list of dates, write a method to return the earliest and latest dates in the list.
        List<DateTime> dates = new List<DateTime>
        {
            new DateTime(2022, 1, 1),
            new DateTime(2023, 3, 10),
            new DateTime(2021, 6, 15),
            new DateTime(2022, 8, 25),
            new DateTime(2023, 12, 31)
        };


        var (earliestDate, latestDate) = GetEarliestAndLatestDates(dates);
        System.Console.WriteLine("earliestDate: {0} latestDate: {1}", earliestDate, latestDate);
        // List<int> TopFiveHighestNumbers(List<int> numbers r
        // Given a list of integers, write a method to return the top 5 highest numbers in the list.

        // List<int> number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> topFiveHighestNumbers = TopFiveHighestNumbers(numbers);
        foreach (int number in topFiveHighestNumbers)
        {
            System.Console.Write("{0} ", number);
        }
        System.Console.WriteLine();
        // string LongestWord(List<string> words) *
        // Given a list of strings, write a method to return the longest word in the list.

        // List<string> words = new List<string>() { "dog", "dog", "fish", "pig" };
        string longestWord = LongestWord(words);
        System.Console.WriteLine("LongestWord: {0}", longestWord);
        // List<string> CustomersInCitiesStartingWithA(List<Customer> customers) -
        // Given a list of customers with a "City" property, write a method to return the names of customers who live in
        // cities that start with the letter
        List<Customer> customers = new List<Customer>(){
            new Customer{ Name = "Nhon", City = "HCM"},
            new Customer{ Name = "David", City = "America"},
            new Customer{ Name = "David1", City = "America1"},
            new Customer{ Name = "Lena", City = "UK"}
        };

        List<string> customersInCitiesStartingWithA = CustomersInCitiesStartingWithA(customers);
        foreach (string customer in customersInCitiesStartingWithA)
        {
            System.Console.WriteLine("Name: {0} ", customer);
        }
        // Dictionary<int,int> CountOfEachNumber(List<int> numbers)'
        // Given a list of integers, write a method to return a dictionary where the keys are the numbers in the list and
        // the values are the number of times each number appears in the list.
        //   var totalPriceByCategory = products.GroupBy(p => p.Category)
        //                                    .ToDictionary(g => g.Key, g => g.Sum(p => p.Price));

        // List<int> number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Dictionary<int, int> countOfEachNumber = CountOfEachNumber(numbers);
        foreach (KeyValuePair<int, int> pair in countOfEachNumber)
        {
            Console.WriteLine("Number: {0} - Count:{1}", pair.Key, pair.Value);
        }
        // - Dictionary«string, decimal > AveragePriceByCategory(List<Product> products) •
        // Given a list of products with a "Price" property, write a method to return a dictionary where the keys are the
        // category names and the values are the average price of products in that category.
        Dictionary<string, decimal> averagePriceByCategory = AveragePriceByCategory(products);
        foreach (KeyValuePair<string, decimal> pair in averagePriceByCategory)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
        // List<stringy WordsContainingZ(List<string> words) -
        // Given a list of strings, write a method to return the words in the list that contain the letter "z"
        List<string> wordsContainingZ = WordsContainingZ(words);
        foreach (var item in wordsContainingZ)
        {
            System.Console.WriteLine("word: {0}", item);
        }

    }
}
