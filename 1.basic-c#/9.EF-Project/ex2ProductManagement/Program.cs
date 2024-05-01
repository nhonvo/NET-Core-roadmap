BusineesLogic b = new BusineesLogic();
b.DoSomeThing();


// Eager loading:loads all related entities along with the main entity in a single database query.

// var customers = context.Customers
//     .Include(c => c.Orders)
//     .ThenInclude(o => o.OrderDetails)
//     .ToList();
// // Load multiple related: related loads multiple related entities of the same type.

// var orders = context.Orders
//     .Include(o => o.Customer)
//     .Include(o => o.OrderDetails)
//     .ToList();
// // Load related of related: of related loads entities that are related to related entities.

// var orders11 = context.Orders
//     .Include(o => o.Customer)
//     .ThenInclude(c => c.Address)
//     .Include(o => o.OrderDetails)
//     .ThenInclude(od => od.Product)
//     .ToList();
// // Explicit loading: loads related entities only when they are explicitly requested.

// var order = context.Orders.FirstOrDefault(o => o.Id == 1);
// if (order != null)
// {
//     context.Entry(order)
//         .Reference(o => o.Customer)
//         .Load();
// }
// // Explicit loading extend: loads related entities only when they are explicitly requested.

// var order111 = context.Orders.FirstOrDefault(o => o.Id == 1);
// if (order111 != null)
// {
//     context.Entry(order111)
//         .Reference(o => o.Customer)
//         .Load();
//     context.Entry(order111.Customer)
//         .Collection(c => c.Orders)
//         .Load();
// }
// // Lazy loading: loads related entities only when they are accessed for the first time.

// var order2 = context.Orders.FirstOrDefault(o => o.Id == 1);
// if (order2 != null)
// {
//     var customer = order.Customer;
// }