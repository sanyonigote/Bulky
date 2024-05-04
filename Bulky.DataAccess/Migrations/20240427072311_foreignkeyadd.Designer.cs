﻿// <auto-generated />
using System;
using Bulky.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bulky.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240427072311_foreignkeyadd")]
    partial class foreignkeyadd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bulky.Models.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<int?>("DisplayOrder")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            DisplayOrder = 9,
                            Name = "Aman"
                        },
                        new
                        {
                            CategoryId = 2,
                            DisplayOrder = 7,
                            Name = "Faizal"
                        },
                        new
                        {
                            CategoryId = 3,
                            DisplayOrder = 6,
                            Name = "GT"
                        });
                });

            modelBuilder.Entity("Bulky.Models.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Author = "Maria Hoey and Peter Hoey",
                            CategoryId = 1,
                            Description = "A delightfully strange collection of linked stories pondering just how little people truly know about animals.",
                            ISBN = "978-1-60309-502-0",
                            ImageUrl = "",
                            ListPrice = 90.0,
                            Price = 87.0,
                            Price100 = 67.0,
                            Price50 = 67.0,
                            Title = "Animal Stories"
                        },
                        new
                        {
                            ProductId = 2,
                            Author = " Jess Fink",
                            CategoryId = 2,
                            Description = "Sexy and charming This is pornography with a heart",
                            ISBN = "978-1-60309-535-8",
                            ImageUrl = "",
                            ListPrice = 56.0,
                            Price = 52.0,
                            Price100 = 43.0,
                            Price50 = 45.0,
                            Title = "Chester 5000"
                        },
                        new
                        {
                            ProductId = 3,
                            Author = "Rich Koslowski",
                            CategoryId = 2,
                            Description = " If superheroes were real, they’d be a lot like pro athletes. But when supers start mysteriously dropping dead, all the agents and managers in the world may not be able to save them...",
                            ISBN = "978-1-60309-515-0",
                            ImageUrl = "",
                            ListPrice = 90.0,
                            Price = 89.0,
                            Price100 = 67.0,
                            Price50 = 78.0,
                            Title = "F.A.R.M. System"
                        },
                        new
                        {
                            ProductId = 4,
                            Author = "Eddie Campbell",
                            CategoryId = 3,
                            Description = "The first modern serial killer strikes his first victims, and reluctant Inspector Abberline is assigned the case of a lifetime.",
                            ISBN = "UPC 827714016215",
                            ImageUrl = "",
                            ListPrice = 90.0,
                            Price = 56.0,
                            Price100 = 43.0,
                            Price50 = 45.0,
                            Title = "Hell: Master Edition "
                        },
                        new
                        {
                            ProductId = 5,
                            Author = "Jeffrey Brown",
                            CategoryId = 3,
                            Description = "This pocket-sized volume is to The Transformers what Avenue Q is to Sesame Street -- a mocking, fawning, idiotic, adoring paean to a pop culture phenomenon inseparable from the artist’s person. Although allegory without substance, all action and no moral, it’s delightful fluff",
                            ISBN = "978-1-891830-91-4",
                            ImageUrl = "",
                            ListPrice = 89.0,
                            Price = 78.0,
                            Price100 = 56.0,
                            Price50 = 76.0,
                            Title = "Incredible Change-Bots One"
                        });
                });

            modelBuilder.Entity("Bulky.Models.Models.Product", b =>
                {
                    b.HasOne("Bulky.Models.Models.Category", "Category")
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