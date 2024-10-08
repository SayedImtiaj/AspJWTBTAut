﻿// <auto-generated />
using System;
using AspJWTBTAut.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspJWTBTAut.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240604033332_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspJWTBTAut.Models.OrderDetail", b =>
                {
                    b.Property<int>("DetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("PlantId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("DetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("PlantId");

                    b.ToTable("OrderDetails");

                    b.HasData(
                        new
                        {
                            DetailId = 1,
                            OrderId = 1,
                            PlantId = 1,
                            Price = 255m,
                            Quantity = 1
                        },
                        new
                        {
                            DetailId = 2,
                            OrderId = 1,
                            PlantId = 2,
                            Price = 165m,
                            Quantity = 2
                        },
                        new
                        {
                            DetailId = 3,
                            OrderId = 2,
                            PlantId = 3,
                            Price = 400m,
                            Quantity = 3
                        });
                });

            modelBuilder.Entity("AspJWTBTAut.Models.OrderMaster", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId");

                    b.ToTable("OrderMasters");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            CustomerName = "Moin Khan",
                            IsComplete = true,
                            OrderDate = new DateTime(2024, 6, 4, 9, 33, 32, 242, DateTimeKind.Local).AddTicks(4997)
                        },
                        new
                        {
                            OrderId = 2,
                            CustomerName = "Shorob Ali",
                            IsComplete = false,
                            OrderDate = new DateTime(2024, 6, 3, 9, 33, 32, 243, DateTimeKind.Local).AddTicks(5544)
                        });
                });

            modelBuilder.Entity("AspJWTBTAut.Models.Plant", b =>
                {
                    b.Property<int>("PlantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlantId");

                    b.ToTable("Plants");

                    b.HasData(
                        new
                        {
                            PlantId = 1,
                            Name = "Mango"
                        },
                        new
                        {
                            PlantId = 2,
                            Name = "Jasmine"
                        },
                        new
                        {
                            PlantId = 3,
                            Name = "Aeromatic Jui"
                        });
                });

            modelBuilder.Entity("AspJWTBTAut.Models.OrderDetail", b =>
                {
                    b.HasOne("AspJWTBTAut.Models.OrderMaster", "OrderMaster")
                        .WithMany("OrderDetail")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AspJWTBTAut.Models.Plant", "Plant")
                        .WithMany("Details")
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
