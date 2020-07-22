﻿// <auto-generated />
using System;
using BalanceModule.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BalanceModule.Migrations
{
    [DbContext(typeof(BalanceDbContext))]
    [Migration("20200404035617_AddBalanceTypeForBalanceCategory")]
    partial class AddBalanceTypeForBalanceCategory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BalanceModule.Models.Balances.Balance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BalanceCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BalanceDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BalanceType")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("PaymentMethodId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<int?>("SellerId")
                        .HasColumnType("int");

                    b.Property<int?>("StoreId")
                        .HasColumnType("int");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<long?>("UserModifiedId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BalanceCategoryId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("StoreId");

                    b.ToTable("Balance");
                });

            modelBuilder.Entity("BalanceModule.Models.Balances.BalanceCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BalanceType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<long?>("UserModifiedId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("BalanceCategory");
                });

            modelBuilder.Entity("BalanceModule.Models.Carriers.Carrier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(400)");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<long?>("UserModifiedId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Carrier");
                });

            modelBuilder.Entity("BalanceModule.Models.Categories.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("BalanceModule.Models.CostTypes.CostType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<long?>("UserModifiedId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("CostType");
                });

            modelBuilder.Entity("BalanceModule.Models.Costs.Cost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("CostDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CostTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("PaymentMethodId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<int?>("SellerId")
                        .HasColumnType("int");

                    b.Property<int?>("StoreId")
                        .HasColumnType("int");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<long?>("UserModifiedId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CostTypeId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("StoreId");

                    b.ToTable("Cost");
                });

            modelBuilder.Entity("BalanceModule.Models.Customers.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerCode")
                        .HasColumnType("varchar(50)");

                    b.Property<byte?>("CustomerTypeId")
                        .HasColumnType("tinyint");

                    b.Property<decimal?>("DebtAmount")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("Gender")
                        .HasColumnType("char(1)");

                    b.Property<DateTime?>("LastOrder")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Note")
                        .HasColumnType("varchar(200)");

                    b.Property<decimal?>("PaidAmount")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("TaxCode")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<decimal?>("TotalSales")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("BalanceModule.Models.Employees.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<long?>("UserModifiedId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("BalanceModule.Models.OrderItems.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DiscountAmount")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<long?>("UserModifiedId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("BalanceModule.Models.OrderNotes.OrderNote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DisplayToCustomer")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<long?>("UserModifiedId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("OrderNote");
                });

            modelBuilder.Entity("BalanceModule.Models.Orders.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("OrderDebt")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("OrderDiscount")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<decimal?>("OrderPaid")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int");

                    b.Property<decimal>("OrderTax")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<int?>("OrderType")
                        .HasColumnType("int");

                    b.Property<int?>("PaymentMethodId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SaleDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SellerId")
                        .HasColumnType("int");

                    b.Property<int?>("StoreId")
                        .HasColumnType("int");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<long?>("UserModifiedId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("SellerId");

                    b.HasIndex("StoreId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("BalanceModule.Models.PaymentMethods.PaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<long?>("UserModifiedId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("PaymentMethod");
                });

            modelBuilder.Entity("BalanceModule.Models.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("AllowNegativeInventory")
                        .HasColumnType("bit");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool?>("FollowInventory")
                        .HasColumnType("bit");

                    b.Property<bool?>("ManageBySerial")
                        .HasColumnType("bit");

                    b.Property<int?>("MaxStockQuantity")
                        .HasColumnType("int");

                    b.Property<int?>("MinStockQuantity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductManufacturerId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductStatusId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<bool?>("PublishedPOS")
                        .HasColumnType("bit");

                    b.Property<int?>("TaxCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductManufacturerId");

                    b.HasIndex("ProductStatusId");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("TaxCategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("BalanceModule.Models.Products.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("Product_Category_Mapping");
                });

            modelBuilder.Entity("BalanceModule.Models.Products.ProductManufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProductManufacturer");
                });

            modelBuilder.Entity("BalanceModule.Models.Products.ProductStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProductStatus");
                });

            modelBuilder.Entity("BalanceModule.Models.Products.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProductType");
                });

            modelBuilder.Entity("BalanceModule.Models.Products.TaxCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TaxCategory");
                });

            modelBuilder.Entity("BalanceModule.Models.Shipments.Shipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarrierId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeliveryDateUtc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ShippedDateUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Shipper")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<long?>("UserModifiedId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CarrierId");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("Shipment");
                });

            modelBuilder.Entity("BalanceModule.Models.Stores.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyAddress")
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CompanyPhoneNumber")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyVat")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.Property<long?>("UserModifiedId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("BalanceModule.Models.Balances.Balance", b =>
                {
                    b.HasOne("BalanceModule.Models.Balances.BalanceCategory", "BalanceCategory")
                        .WithMany()
                        .HasForeignKey("BalanceCategoryId");

                    b.HasOne("BalanceModule.Models.Employees.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("BalanceModule.Models.PaymentMethods.PaymentMethod", "PaymentMethod")
                        .WithMany()
                        .HasForeignKey("PaymentMethodId");

                    b.HasOne("BalanceModule.Models.Stores.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("BalanceModule.Models.Costs.Cost", b =>
                {
                    b.HasOne("BalanceModule.Models.CostTypes.CostType", "CostType")
                        .WithMany()
                        .HasForeignKey("CostTypeId");

                    b.HasOne("BalanceModule.Models.Employees.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("BalanceModule.Models.PaymentMethods.PaymentMethod", "PaymentMethod")
                        .WithMany()
                        .HasForeignKey("PaymentMethodId");

                    b.HasOne("BalanceModule.Models.Stores.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("BalanceModule.Models.OrderItems.OrderItem", b =>
                {
                    b.HasOne("BalanceModule.Models.Orders.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BalanceModule.Models.Products.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BalanceModule.Models.OrderNotes.OrderNote", b =>
                {
                    b.HasOne("BalanceModule.Models.Orders.Order", "Order")
                        .WithOne("OrderNote")
                        .HasForeignKey("BalanceModule.Models.OrderNotes.OrderNote", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BalanceModule.Models.Orders.Order", b =>
                {
                    b.HasOne("BalanceModule.Models.Customers.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BalanceModule.Models.PaymentMethods.PaymentMethod", "PaymentMethod")
                        .WithMany()
                        .HasForeignKey("PaymentMethodId");

                    b.HasOne("BalanceModule.Models.Employees.Employee", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerId");

                    b.HasOne("BalanceModule.Models.Stores.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("BalanceModule.Models.Products.Product", b =>
                {
                    b.HasOne("BalanceModule.Models.Products.ProductManufacturer", "ProductManufacturer")
                        .WithMany()
                        .HasForeignKey("ProductManufacturerId");

                    b.HasOne("BalanceModule.Models.Products.ProductStatus", "ProductStatus")
                        .WithMany()
                        .HasForeignKey("ProductStatusId");

                    b.HasOne("BalanceModule.Models.Products.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId");

                    b.HasOne("BalanceModule.Models.Products.TaxCategory", "TaxCategory")
                        .WithMany()
                        .HasForeignKey("TaxCategoryId");
                });

            modelBuilder.Entity("BalanceModule.Models.Products.ProductCategory", b =>
                {
                    b.HasOne("BalanceModule.Models.Categories.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId");

                    b.HasOne("BalanceModule.Models.Products.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("BalanceModule.Models.Shipments.Shipment", b =>
                {
                    b.HasOne("BalanceModule.Models.Carriers.Carrier", "Carrier")
                        .WithMany()
                        .HasForeignKey("CarrierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BalanceModule.Models.Orders.Order", null)
                        .WithOne("Shipment")
                        .HasForeignKey("BalanceModule.Models.Shipments.Shipment", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
