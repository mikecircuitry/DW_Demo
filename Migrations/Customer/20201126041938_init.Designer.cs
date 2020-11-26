﻿// <auto-generated />
using System;
using DW_Demo.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DW_Demo.Migrations.Customer
{
    [DbContext(typeof(CustomerContext))]
    [Migration("20201126041938_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DW_Demo.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerID");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Pork Belly",
                            CreateDate = new DateTime(2020, 11, 25, 23, 19, 38, 117, DateTimeKind.Local).AddTicks(9813),
                            CustomerID = 1,
                            Name = "Home",
                            State = "NY",
                            StreetAddress = "123 Test Way Drive",
                            Zip = "11111"
                        },
                        new
                        {
                            Id = 2,
                            City = "Pork Belly",
                            CreateDate = new DateTime(2020, 11, 25, 23, 19, 38, 118, DateTimeKind.Local).AddTicks(252),
                            CustomerID = 2,
                            Name = "Home",
                            State = "NY",
                            StreetAddress = "123 Test Way Drive",
                            Zip = "11111"
                        },
                        new
                        {
                            Id = 3,
                            City = "Pork Belly",
                            CreateDate = new DateTime(2020, 11, 25, 23, 19, 38, 118, DateTimeKind.Local).AddTicks(263),
                            CustomerID = 2,
                            Name = "School",
                            State = "NY",
                            StreetAddress = "314 University Way",
                            Zip = "22222"
                        },
                        new
                        {
                            Id = 4,
                            City = "Pork Belly",
                            CreateDate = new DateTime(2020, 11, 25, 23, 19, 38, 118, DateTimeKind.Local).AddTicks(266),
                            CustomerID = 3,
                            Name = "Secret Lab",
                            State = "NY",
                            StreetAddress = "360 redacted street",
                            Zip = "33333"
                        },
                        new
                        {
                            Id = 5,
                            City = "Pork Belly",
                            CreateDate = new DateTime(2020, 11, 25, 23, 19, 38, 118, DateTimeKind.Local).AddTicks(268),
                            CustomerID = 3,
                            Name = "Home",
                            State = "NY",
                            StreetAddress = "123 Test Way Drive",
                            Zip = "11111"
                        });
                });

            modelBuilder.Entity("DW_Demo.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2020, 11, 25, 23, 19, 38, 114, DateTimeKind.Local).AddTicks(2087),
                            Email = "Johnny@testlabs.com",
                            Name = "Johnny Test"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2020, 11, 25, 23, 19, 38, 116, DateTimeKind.Local).AddTicks(6142),
                            Email = "Susan@testlabs.com",
                            Name = "Susan Test"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2020, 11, 25, 23, 19, 38, 116, DateTimeKind.Local).AddTicks(6173),
                            Email = "Mary@testlabs.com",
                            Name = "Mary Test"
                        });
                });

            modelBuilder.Entity("DW_Demo.Models.Address", b =>
                {
                    b.HasOne("DW_Demo.Models.Customer", null)
                        .WithMany("Addresses")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DW_Demo.Models.Customer", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}
