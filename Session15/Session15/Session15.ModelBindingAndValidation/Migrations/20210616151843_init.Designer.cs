﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Session15.ModelBindingAndValidation.Models;

namespace Session15.ModelBindingAndValidation.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20210616151843_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Session15.ModelBindingAndValidation.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Category01"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Category02"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Category03"
                        });
                });

            modelBuilder.Entity("Session15.ModelBindingAndValidation.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Description Product 01",
                            Name = "Product01",
                            Price = 1000000
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Description Product 02",
                            Name = "Product02",
                            Price = 2000000
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "Description Product 03",
                            Name = "Product03",
                            Price = 3000000
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Description = "Description Product 04",
                            Name = "Product04",
                            Price = 4000000
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Description Product 05",
                            Name = "Product05",
                            Price = 5000000
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "Description Product 06",
                            Name = "Product06",
                            Price = 6000000
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = "Description Product 07",
                            Name = "Product07",
                            Price = 7000000
                        });
                });

            modelBuilder.Entity("Session15.ModelBindingAndValidation.Models.Product", b =>
                {
                    b.HasOne("Session15.ModelBindingAndValidation.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
