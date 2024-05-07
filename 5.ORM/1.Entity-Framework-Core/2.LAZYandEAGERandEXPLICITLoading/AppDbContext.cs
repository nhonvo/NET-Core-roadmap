using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Tag> Tag { get; set; }
    public DbSet<Address> Addresss { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connect = "Server=truongnhon;Database=loadingdb;Trusted_Connection=true; MultipleActiveResultSets=true; TrustServerCertificate=True";
        optionsBuilder.UseSqlServer(connect);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
                    .HasOne(c => c.Address)
                    .WithOne(o => o.User)
                    .HasForeignKey<Address>(ad => ad.UserId);

        modelBuilder.Entity<User>()
                    .HasMany(c => c.Posts)
                    .WithOne(o => o.User)
                    .HasForeignKey(o => o.UserId);

        // config order with order detail
        modelBuilder.Entity<Tag>()
                    .HasOne(od => od.Post)
                    .WithMany(o => o.Tags)
                    .HasForeignKey(od => od.PostId);

        modelBuilder.Entity<Tag>()
                    .HasOne(t => t.Post)
                    .WithMany(p => p.Tags)
                    .HasForeignKey(t => t.PostId);

        modelBuilder.Entity<User>()
                    .HasData(
                        new User { Id = 1, Name = "User 1" },
                        new User { Id = 2, Name = "User 2" }
                    );

        modelBuilder.Entity<Address>()
                    .HasData(
                        new Address { Id = 1, UserId = 1, Detail = "Address 1" },
                        new Address { Id = 2, UserId = 2, Detail = "Address 2" }
                    );

        modelBuilder.Entity<Post>()
                    .HasData(
                        new Post { Id = 1, UserId = 1, Title = "Title 1" },
                        new Post { Id = 2, UserId = 1, Title = "Title 1.2" },
                        new Post { Id = 3, UserId = 2, Title = "Title 2" }
                    );

        modelBuilder.Entity<Tag>()
                    .HasData(
                        new Tag { Id = 1, PostId = 1, Name = "Tag 1" },
                        new Tag { Id = 2, PostId = 1, Name = "Tag 1.2" },
                        new Tag { Id = 3, PostId = 2, Name = "Tag 2" }
                    );
    }
}

public class Address
{
    public int Id { get; set; }
    public string Detail { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Address Address { get; set; }
    public ICollection<Post> Posts { get; set; }
}

public class Post
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public string Title { get; set; }
    public ICollection<Tag> Tags { get; set; }
}

public class Tag
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int PostId { get; set; }
    public Post Post { get; set; }
}


