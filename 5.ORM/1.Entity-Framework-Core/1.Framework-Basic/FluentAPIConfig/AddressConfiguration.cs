using _1.Entity_Framework_Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace _1.Entity_Framework_Core.FluentAPIConfig;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasOne(c => c.Customer)
                  .WithOne(ad => ad.Address)
                  .HasForeignKey<Address>(ad => ad.CustomerId)
                  .OnDelete(DeleteBehavior.ClientSetNull);
    }
}

