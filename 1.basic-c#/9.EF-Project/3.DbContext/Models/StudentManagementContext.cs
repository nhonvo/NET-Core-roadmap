using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public class StudentManagementContext : DbContext
{
    public StudentManagementContext()
    {
    }

    public StudentManagementContext(DbContextOptions<StudentManagementContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Class>();
    }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Score> Scores { get; set; }


}