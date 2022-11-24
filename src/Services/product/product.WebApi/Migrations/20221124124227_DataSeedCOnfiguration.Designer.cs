﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using product.Infrastructure.Repository;

#nullable disable

namespace product.WebApi.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20221124124227_DataSeedCOnfiguration")]
    partial class DataSeedCOnfiguration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("product.Domain.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("productCategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryId");

                    b.Property<string>("productDescription")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("ProductDescription");

                    b.Property<string>("productName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ProductName");

                    b.Property<decimal>("unitPrice")
                        .HasColumnType("decimal(18,6)");

                    b.HasKey("Id");

                    b.HasIndex("productCategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            productCategoryId = 1,
                            productDescription = "carbonate drink",
                            productName = "Coke-Cola",
                            unitPrice = 200m
                        },
                        new
                        {
                            Id = 2,
                            productCategoryId = 1,
                            productDescription = "carbonate drink",
                            productName = "Pescp-Cola",
                            unitPrice = 200m
                        },
                        new
                        {
                            Id = 3,
                            productCategoryId = 1,
                            productDescription = "carbonate drink",
                            productName = "Fanta",
                            unitPrice = 200m
                        },
                        new
                        {
                            Id = 4,
                            productCategoryId = 1,
                            productDescription = "Alcohol drink",
                            productName = "Gulder-beer",
                            unitPrice = 200m
                        },
                        new
                        {
                            Id = 5,
                            productCategoryId = 1,
                            productDescription = "Brande",
                            productName = "Red-Label",
                            unitPrice = 200m
                        });
                });

            modelBuilder.Entity("product.Domain.Models.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryDescription")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryDescription = "All types of drinks including wine, brande, etc",
                            CategoryName = "Drink"
                        },
                        new
                        {
                            Id = 2,
                            CategoryDescription = "Consumerable or eddiable items",
                            CategoryName = "Provisions"
                        });
                });

            modelBuilder.Entity("product.Domain.Models.Product", b =>
                {
                    b.HasOne("product.Domain.Models.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("productCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("product.Domain.Models.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
