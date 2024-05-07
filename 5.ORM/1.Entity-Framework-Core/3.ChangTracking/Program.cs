// Change Tracking has 5 status: Added, Modified, Deleted, Unchanged, Detached(Not tracking by ef)
using Microsoft.EntityFrameworkCore;
// Added
using (var context = new AppDbContext())
{
    var newProduct = new Product { Id = 19, Name = "Milk" };
    context.Products.Add(newProduct);
    Console.WriteLine($"State of newProduct: {context.Entry(newProduct).State}");
    context.SaveChanges();
}
// Modified
using (var context = new AppDbContext())
{
    var product = context.Products.FirstOrDefault(u => u.Id == 11);
    if (product != null)
    {
        product.Name = "Jane Doe";
        Console.WriteLine($"State of product: {context.Entry(product).State}");
        context.SaveChanges();
    }
}
// Deleted
using (var context = new AppDbContext())
{
    var product = context.Products.FirstOrDefault(u => u.Id == 1);
    if (product != null)
    {
        context.Products.Remove(product);
        Console.WriteLine($"State of product: {context.Entry(product).State}");
        context.SaveChanges();
    }
}
// Detached entity
using (var context = new AppDbContext())
{
    var product = context.Products.FirstOrDefault(u => u.Id == 1);
    // At this point, the entity is being tracked by the context.
    if (product != null)
    {
        // Detach the entity from the context
        context.Entry(product).State = EntityState.Detached;

        // At this point, the entity is detached and no longer tracked by the context
        Console.WriteLine($"State of product after detachment: {context.Entry(product).State}"); 
        // Should output: Detached

        // Reattach the detached entity to the context
        context.Products.Attach(product);

        // Mark the entity as modified if you want to save changes
        context.Entry(product).State = EntityState.Modified;

        // Save changes to apply the modification to the database
        context.SaveChanges();
    }
}



