using System.ComponentModel;
// Create a list of Product objects
List<Product> products = new List<Product>()
{
    new Product() { Id = 1, Name = "Product A", Category = "Category 1", Price = 9.99m, Quantity = 10 },
    new Product() { Id = 2, Name = "Product B", Category = "Category 1", Price = 19.99m, Quantity = 5 },
    new Product() { Id = 3, Name = "Product C", Category = "Category 2", Price = 4.99m, Quantity = 20 },
    new Product() { Id = 4, Name = "Product D", Category = "Category 2", Price = 14.99m, Quantity = 15 },
    new Product() { Id = 5, Name = "Product E", Category = "Category 2", Price = 24.99m, Quantity = 3 },
    new Product() { Id = 6, Name = "Product F", Category = "Category 3", Price = 12.49m, Quantity = 8 }
};


// 1.	Group products by category and get the total quantity and price for each category.
foreach (var item in products.GroupBy(x => x.Category).Select(x => new
{
    x.Key,
    total = x.Sum(x => x.Price),
    quantity = x.Sum(x => x.Quantity)
})) 
{
    System.Console.WriteLine(item.total + " " + item.quantity);
}
// 2.	Group products by category and price range (e.g. less than $10, between $10 and $20, etc.) and get the total quantity and price for each category-price range combination.
var priceRanges = new List<Tuple<string, decimal, decimal>>()
{
    Tuple.Create("Less than $10", 0m, 10m),
    Tuple.Create("$10 - $20", 10m, 20m),
    Tuple.Create("More than $20", 20m, decimal.MaxValue)
};

var categoryPriceRangeQuantitiesAndPrices = products.GroupBy(product => product.Category)
.SelectMany(group => priceRanges.Select(price => new
{
    Category = group.Key,
    PriceRange = price.Item1,
    TotalQuantity = group.Where(ptq => ptq.Price >= price.Item2 && ptq.Price < price.Item3)
        .Sum(p => p.Quantity),
    TotalPrice = group.Where(ptp => ptp.Price >= price.Item2 && ptp.Price < price.Item3)
        .Sum(p => p.Price * p.Quantity)
}));
// 3.	Group products by name and get the total quantity and price for each product.
var result2 = products.GroupBy(n => n.Name).Select(p => new
{
    p.Key,
    totalQuantity = p.Sum(p => p.Quantity),
    totalPrice = p.Sum(p => p.Price)
});

// 4.	Group products by category and get the average price for each category.

// 5.	Group products by category and get the highest and lowest prices for each category.

// 6.	Group products by category and get the number of products in each category.

// 7.	Group products by name and category and get the total quantity and price for each product-category combination.

// 8.	Group products by price range (e.g. less than $10, between $10 and $20, etc.) and get the total quantity and price for each price range.

// 9.	Group products by name and get the highest and lowest prices for each product.

// 10.	Group products by category and name and get the average price for each category-product combination.

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
