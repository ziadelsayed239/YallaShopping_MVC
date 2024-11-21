﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YallaShopping.DataAccess.Data;

#nullable disable

namespace YallaShopping.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241111170505_AddCompanyTable")]
    partial class AddCompanyTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-rc.2.24474.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator().HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("YallaShopping.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(29)
                        .HasColumnType("nvarchar(29)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Scifi"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "History"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Books"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOrder = 6,
                            Name = "Fashion"
                        });
                });

            modelBuilder.Entity("YallaShopping.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("YallaShopping.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.Property<string>("ImageURL")
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

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Billy Spark",
                            CategoryId = 1,
                            Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                            ISBN = "SWD9999001",
                            ImageURL = "",
                            ListPrice = 99.0,
                            Price = 90.0,
                            Price100 = 80.0,
                            Price50 = 85.0,
                            Title = "Fortune of Time"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Nancy Hoover",
                            CategoryId = 1,
                            Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                            ISBN = "CAW777777701",
                            ImageURL = "",
                            ListPrice = 40.0,
                            Price = 30.0,
                            Price100 = 20.0,
                            Price50 = 25.0,
                            Title = "Dark Skies"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Julian Button",
                            CategoryId = 1,
                            Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                            ISBN = "RITO5555501",
                            ImageURL = "",
                            ListPrice = 55.0,
                            Price = 50.0,
                            Price100 = 35.0,
                            Price50 = 40.0,
                            Title = "Vanish in the Sunset"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Abby Muscles",
                            CategoryId = 1,
                            Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                            ISBN = "WS3333333301",
                            ImageURL = "",
                            ListPrice = 70.0,
                            Price = 65.0,
                            Price100 = 55.0,
                            Price50 = 60.0,
                            Title = "Cotton Candy"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Ron Parker",
                            CategoryId = 1,
                            Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                            ISBN = "SOTJ1111111101",
                            ImageURL = "",
                            ListPrice = 30.0,
                            Price = 27.0,
                            Price100 = 20.0,
                            Price50 = 25.0,
                            Title = "Rock in the Ocean"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Laura Phantom",
                            CategoryId = 1,
                            Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                            ISBN = "FOT000000001",
                            ImageURL = "",
                            ListPrice = 25.0,
                            Price = 23.0,
                            Price100 = 20.0,
                            Price50 = 22.0,
                            Title = "Leaves and Wonders"
                        },
                        new
                        {
                            Id = 8,
                            Author = "John Smith",
                            CategoryId = 1,
                            Description = "Advanced concepts and patterns in C#.",
                            ISBN = "1000000002",
                            ImageURL = "",
                            ListPrice = 60.0,
                            Price = 55.0,
                            Price100 = 45.0,
                            Price50 = 50.0,
                            Title = "Advanced C# Techniques"
                        },
                        new
                        {
                            Id = 9,
                            Author = "Alex Johnson",
                            CategoryId = 1,
                            Description = "Learn JavaScript from scratch.",
                            ISBN = "1000000003",
                            ImageURL = "",
                            ListPrice = 40.0,
                            Price = 35.0,
                            Price100 = 25.0,
                            Price50 = 30.0,
                            Title = "JavaScript for Beginners"
                        },
                        new
                        {
                            Id = 10,
                            Author = "Mary Stone",
                            CategoryId = 1,
                            Description = "Deep dive into ASP.NET Core development.",
                            ISBN = "1000000004",
                            ImageURL = "",
                            ListPrice = 70.0,
                            Price = 65.0,
                            Price100 = 55.0,
                            Price50 = 60.0,
                            Title = "Mastering ASP.NET Core"
                        },
                        new
                        {
                            Id = 11,
                            Author = "Emily Davis",
                            CategoryId = 1,
                            Description = "Guide to using Entity Framework Core.",
                            ISBN = "1000000005",
                            ImageURL = "",
                            ListPrice = 45.0,
                            Price = 40.0,
                            Price100 = 30.0,
                            Price50 = 35.0,
                            Title = "Entity Framework Core Essentials"
                        },
                        new
                        {
                            Id = 12,
                            Author = "Robert C. Martin",
                            CategoryId = 1,
                            Description = "A handbook of agile software craftsmanship.",
                            ISBN = "1000000006",
                            ImageURL = "",
                            ListPrice = 90.0,
                            Price = 85.0,
                            Price100 = 75.0,
                            Price50 = 80.0,
                            Title = "Clean Code"
                        },
                        new
                        {
                            Id = 13,
                            Author = "Sarah Green",
                            CategoryId = 1,
                            Description = "Complete Python guide for beginners.",
                            ISBN = "1000000007",
                            ImageURL = "",
                            ListPrice = 55.0,
                            Price = 50.0,
                            Price100 = 40.0,
                            Price50 = 45.0,
                            Title = "Python Programming"
                        },
                        new
                        {
                            Id = 14,
                            Author = "Michael Allen",
                            CategoryId = 1,
                            Description = "An overview of AI concepts.",
                            ISBN = "1000000008",
                            ImageURL = "",
                            ListPrice = 80.0,
                            Price = 75.0,
                            Price100 = 65.0,
                            Price50 = 70.0,
                            Title = "Artificial Intelligence Basics"
                        },
                        new
                        {
                            Id = 15,
                            Author = "Rachel Lee",
                            CategoryId = 1,
                            Description = "Learn SQL for analyzing data.",
                            ISBN = "1000000009",
                            ImageURL = "",
                            ListPrice = 65.0,
                            Price = 60.0,
                            Price100 = 50.0,
                            Price50 = 55.0,
                            Title = "SQL for Data Analysis"
                        },
                        new
                        {
                            Id = 16,
                            Author = "David Clark",
                            CategoryId = 1,
                            Description = "Comprehensive guide on data structures.",
                            ISBN = "1000000010",
                            ImageURL = "",
                            ListPrice = 95.0,
                            Price = 90.0,
                            Price100 = 80.0,
                            Price50 = 85.0,
                            Title = "Data Structures and Algorithms"
                        },
                        new
                        {
                            Id = 17,
                            Author = "Anna White",
                            CategoryId = 1,
                            Description = "Step-by-step guide to machine learning.",
                            ISBN = "1000000011",
                            ImageURL = "",
                            ListPrice = 100.0,
                            Price = 95.0,
                            Price100 = 85.0,
                            Price50 = 90.0,
                            Title = "Machine Learning with Python"
                        },
                        new
                        {
                            Id = 18,
                            Author = "Chris Black",
                            CategoryId = 1,
                            Description = "Comprehensive guide to web development.",
                            ISBN = "1000000012",
                            ImageURL = "",
                            ListPrice = 75.0,
                            Price = 70.0,
                            Price100 = 60.0,
                            Price50 = 65.0,
                            Title = "Web Development Essentials"
                        },
                        new
                        {
                            Id = 19,
                            Author = "Tom Brown",
                            CategoryId = 1,
                            Description = "Complete guide to Java programming.",
                            ISBN = "1000000013",
                            ImageURL = "",
                            ListPrice = 85.0,
                            Price = 80.0,
                            Price100 = 70.0,
                            Price50 = 75.0,
                            Title = "Java Fundamentals"
                        },
                        new
                        {
                            Id = 20,
                            Author = "Linda Blue",
                            CategoryId = 1,
                            Description = "Learn Kotlin for Android app development.",
                            ISBN = "1000000014",
                            ImageURL = "",
                            ListPrice = 65.0,
                            Price = 60.0,
                            Price100 = 50.0,
                            Price50 = 55.0,
                            Title = "Kotlin for Android Developers"
                        },
                        new
                        {
                            Id = 21,
                            Author = "Nancy Grey",
                            CategoryId = 1,
                            Description = "Basics and applications of cloud computing.",
                            ISBN = "1000000015",
                            ImageURL = "",
                            ListPrice = 55.0,
                            Price = 50.0,
                            Price100 = 40.0,
                            Price50 = 45.0,
                            Title = "Understanding Cloud Computing"
                        },
                        new
                        {
                            Id = 22,
                            Author = "Paul Adams",
                            CategoryId = 1,
                            Description = "Guide to managing agile projects.",
                            ISBN = "1000000016",
                            ImageURL = "",
                            ListPrice = 60.0,
                            Price = 55.0,
                            Price100 = 45.0,
                            Price50 = 50.0,
                            Title = "Agile Project Management"
                        },
                        new
                        {
                            Id = 23,
                            Author = "Sophie Turner",
                            CategoryId = 1,
                            Description = "Practical guide to building apps with React.",
                            ISBN = "1000000017",
                            ImageURL = "",
                            ListPrice = 70.0,
                            Price = 65.0,
                            Price100 = 55.0,
                            Price50 = 60.0,
                            Title = "React.js in Practice"
                        },
                        new
                        {
                            Id = 24,
                            Author = "George Lane",
                            CategoryId = 1,
                            Description = "Basic principles of cybersecurity.",
                            ISBN = "1000000018",
                            ImageURL = "",
                            ListPrice = 80.0,
                            Price = 75.0,
                            Price100 = 65.0,
                            Price50 = 70.0,
                            Title = "Introduction to Cybersecurity"
                        },
                        new
                        {
                            Id = 25,
                            Author = "Emma Clark",
                            CategoryId = 1,
                            Description = "Techniques and tools for big data analysis.",
                            ISBN = "1000000019",
                            ImageURL = "",
                            ListPrice = 95.0,
                            Price = 90.0,
                            Price100 = 80.0,
                            Price50 = 85.0,
                            Title = "Big Data Analytics"
                        },
                        new
                        {
                            Id = 26,
                            Author = "William Brown",
                            CategoryId = 1,
                            Description = "Effective strategies for digital marketing.",
                            ISBN = "1000000020",
                            ImageURL = "",
                            ListPrice = 50.0,
                            Price = 45.0,
                            Price100 = 35.0,
                            Price50 = 40.0,
                            Title = "Digital Marketing Strategies"
                        });
                });

            modelBuilder.Entity("YallaShopping.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YallaShopping.Models.Product", b =>
                {
                    b.HasOne("YallaShopping.Models.Category", "Category")
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
