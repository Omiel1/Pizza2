﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pizza2.Data;

#nullable disable

namespace Pizza2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221123134659_MenuStringName")]
    partial class MenuStringName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Pizza2.Models.IngridientViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("ContainsMeat")
                        .HasColumnType("bit");

                    b.Property<string>("IngridientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("IngridientPrice")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Ingridients");
                });

            modelBuilder.Entity("Pizza2.Models.MenuViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MenuItemPosition")
                        .HasColumnType("int");

                    b.Property<int>("PizzaId")
                        .HasColumnType("int");

                    b.Property<int>("menuId")
                        .HasColumnType("int");

                    b.Property<string>("menuName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("Pizza2.Models.OrderViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("OrderConfirmed")
                        .HasColumnType("bit");

                    b.Property<float>("OrderPrice")
                        .HasColumnType("real");

                    b.Property<int>("OrderTableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Pizza2.Models.PizzaIngridientsViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IngridientId")
                        .HasColumnType("int");

                    b.Property<int>("PizzaIngridientListId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PizzaIngridients");
                });

            modelBuilder.Entity("Pizza2.Models.PizzaViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IngridientsListId")
                        .HasColumnType("int");

                    b.Property<string>("PizzaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PizzaPrice")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("Pizza2.Models.ShoppingCartViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("PizzaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ShoppingCarts");
                });
#pragma warning restore 612, 618
        }
    }
}
