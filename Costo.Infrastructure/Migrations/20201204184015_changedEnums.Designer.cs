﻿// <auto-generated />
using System;
using Costo.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Costo.Infrastructure.Migrations
{
    [DbContext(typeof(CostoContext))]
    [Migration("20201204184015_changedEnums")]
    partial class changedEnums
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Costo.Domain.Entities.BankAccount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountTypeString")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AccountType");

                    b.Property<decimal>("Balance")
                        .HasColumnType("money");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconString")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Icon");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("Costo.Domain.Entities.SavingsGoal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("GoalValue")
                        .HasColumnType("money");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Value")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("SavingsGoals");
                });

            modelBuilder.Entity("Costo.Domain.Entities.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BankAccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("TransactionCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TransactionTypeString")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TransactionType");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Value")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("BankAccountId");

                    b.HasIndex("TransactionCategoryId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Costo.Domain.Entities.TransactionCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconString")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Icon");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TransactionCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("TransactionCategoryId");

                    b.ToTable("TransactionCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5e8bd641-7c28-4023-99ac-990ab3e7fe5e"),
                            CreateDate = new DateTime(2020, 12, 4, 19, 40, 15, 300, DateTimeKind.Local).AddTicks(65),
                            Description = "...",
                            IconString = "Money",
                            Name = "Wypłata",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("d8fda30b-e535-4120-ad49-14323f2463f1"),
                            CreateDate = new DateTime(2020, 12, 4, 19, 40, 15, 303, DateTimeKind.Local).AddTicks(2813),
                            Description = "...",
                            IconString = "Money",
                            Name = "Przychód",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("a84f0a9f-b271-4d31-a7bd-e0a56176e954"),
                            CreateDate = new DateTime(2020, 12, 4, 19, 40, 15, 303, DateTimeKind.Local).AddTicks(2847),
                            Description = "...",
                            IconString = "Money",
                            Name = "Wydatek",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("28ff0e24-606a-4a05-bf60-f4aabda6dab6"),
                            CreateDate = new DateTime(2020, 12, 4, 19, 40, 15, 303, DateTimeKind.Local).AddTicks(2852),
                            Description = "...",
                            IconString = "Money",
                            Name = "Zakupy spożywcze",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("75b6b4c5-72be-42b7-83df-93a21a3d74fc"),
                            CreateDate = new DateTime(2020, 12, 4, 19, 40, 15, 303, DateTimeKind.Local).AddTicks(2856),
                            Description = "...",
                            IconString = "Money",
                            Name = "Transport",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("741a8a7a-57b1-4226-a8b6-29a0ed39160e"),
                            CreateDate = new DateTime(2020, 12, 4, 19, 40, 15, 303, DateTimeKind.Local).AddTicks(2859),
                            Description = "...",
                            IconString = "Money",
                            Name = "Zdrowie",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("4ea5a64a-c89a-451a-900f-867b9d34f1cc"),
                            CreateDate = new DateTime(2020, 12, 4, 19, 40, 15, 303, DateTimeKind.Local).AddTicks(2862),
                            Description = "...",
                            IconString = "Money",
                            Name = "Rozrywka",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("dc8c3b63-d9a4-4e59-b83b-6a9181011572"),
                            CreateDate = new DateTime(2020, 12, 4, 19, 40, 15, 303, DateTimeKind.Local).AddTicks(2866),
                            Description = "...",
                            IconString = "Money",
                            Name = "Dom",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("ad97c73f-8841-4574-814d-c05f78e2a9c9"),
                            CreateDate = new DateTime(2020, 12, 4, 19, 40, 15, 303, DateTimeKind.Local).AddTicks(2878),
                            Description = "...",
                            IconString = "Money",
                            Name = "Restauracje",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Costo.Domain.Entities.Transaction", b =>
                {
                    b.HasOne("Costo.Domain.Entities.BankAccount", "BankAccount")
                        .WithMany("Transactions")
                        .HasForeignKey("BankAccountId");

                    b.HasOne("Costo.Domain.Entities.TransactionCategory", "TransactionCategory")
                        .WithMany()
                        .HasForeignKey("TransactionCategoryId");

                    b.Navigation("BankAccount");

                    b.Navigation("TransactionCategory");
                });

            modelBuilder.Entity("Costo.Domain.Entities.TransactionCategory", b =>
                {
                    b.HasOne("Costo.Domain.Entities.TransactionCategory", null)
                        .WithMany("SubCategories")
                        .HasForeignKey("TransactionCategoryId");
                });

            modelBuilder.Entity("Costo.Domain.Entities.BankAccount", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Costo.Domain.Entities.TransactionCategory", b =>
                {
                    b.Navigation("SubCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
