using _1.Entity_Framework_Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace _1.Entity_Framework_Core.FluentAPIConfig;

public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
{
    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {
       // config order with order detail
        builder.HasOne(od => od.Order)
                        .WithMany(o => o.OrderDetails)
                        .HasForeignKey(od => od.OrderId);

        builder.HasOne(od => od.Product)
                        .WithMany(p => p.OrderDetails)
                        .HasForeignKey(od => od.OrderId);

        builder.HasKey(sc => new { sc.OrderId, sc.ProductId });
        // .HasNoKey();

    }
}
