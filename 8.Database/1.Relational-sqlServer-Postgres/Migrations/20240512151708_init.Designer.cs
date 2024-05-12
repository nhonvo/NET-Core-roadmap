﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using _1.Relational_sqlServer_Postgres;

#nullable disable

namespace _1.Relational_sqlServer_Postgres.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240512151708_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateRelease")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateRelease = new DateTime(2002, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Principal"
                        },
                        new
                        {
                            Id = 2,
                            DateRelease = new DateTime(2002, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Implement"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
