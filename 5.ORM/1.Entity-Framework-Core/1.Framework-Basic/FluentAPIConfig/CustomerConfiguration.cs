using _1.Entity_Framework_Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace _1.Entity_Framework_Core.FluentAPIConfig;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{

    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasMany(c => c.Orders)
                        .WithOne(o => o.Customer)
                        .HasForeignKey(o => o.CustomerId);
    }
}
