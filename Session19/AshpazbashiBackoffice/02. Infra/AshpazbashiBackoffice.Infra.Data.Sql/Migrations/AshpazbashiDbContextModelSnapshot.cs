﻿// <auto-generated />
using System;
using AshpazbashiBackoffice.Infra.Data.Sql.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AshpazbashiBackoffice.Infra.Data.Sql.Migrations
{
    [DbContext(typeof(AshpazbashiDbContext))]
    partial class AshpazbashiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AshpazbashiBackoffice.Core.Domain.Recipes.Recipe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ReceipImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ReceipImageId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("AshpazbashiBackoffice.Core.Domain.Recipes.RecipeImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhysicalPath")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("RecipeImages");
                });

            modelBuilder.Entity("AshpazbashiBackoffice.Core.Domain.Recipes.RecipeTag", b =>
                {
                    b.Property<Guid>("RecipeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TagId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RecipeId", "TagId");

                    b.HasIndex("TagId");

                    b.HasIndex("TagId1");

                    b.ToTable("RecipeTags");
                });

            modelBuilder.Entity("AshpazbashiBackoffice.Core.Domain.Tags.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("AshpazbashiBackoffice.Core.Domain.Recipes.Recipe", b =>
                {
                    b.HasOne("AshpazbashiBackoffice.Core.Domain.Recipes.RecipeImage", "ReceipImage")
                        .WithMany()
                        .HasForeignKey("ReceipImageId");

                    b.OwnsMany("AshpazbashiBackoffice.Core.Domain.Recipes.Ingredient", "Ingredients", b1 =>
                        {
                            b1.Property<Guid>("RecipeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Title")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Value")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("RecipeId", "Id");

                            b1.ToTable("Ingredient");

                            b1.WithOwner()
                                .HasForeignKey("RecipeId");
                        });

                    b.Navigation("Ingredients");

                    b.Navigation("ReceipImage");
                });

            modelBuilder.Entity("AshpazbashiBackoffice.Core.Domain.Recipes.RecipeTag", b =>
                {
                    b.HasOne("AshpazbashiBackoffice.Core.Domain.Recipes.Recipe", null)
                        .WithMany("RecipeTags")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AshpazbashiBackoffice.Core.Domain.Tags.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AshpazbashiBackoffice.Core.Domain.Tags.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId1");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("AshpazbashiBackoffice.Core.Domain.Recipes.Recipe", b =>
                {
                    b.Navigation("RecipeTags");
                });
#pragma warning restore 612, 618
        }
    }
}