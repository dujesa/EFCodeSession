﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaymentManager.Data.Entities;

namespace PaymentManager.Data.Migrations
{
    [DbContext(typeof(PaymentManagerDbContext))]
    partial class PaymentManagerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PaymentManager.Data.Entities.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Iban")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisteredAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Balance = 100m,
                            Iban = "1234567890",
                            RegisteredAt = new DateTime(2020, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Balance = 92100m,
                            Iban = "298765432",
                            RegisteredAt = new DateTime(2019, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Balance = 0m,
                            Iban = "76584932234",
                            RegisteredAt = new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            Balance = 14500m,
                            Iban = "1234567890",
                            RegisteredAt = new DateTime(2010, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            Balance = 1324m,
                            Iban = "89876542345",
                            RegisteredAt = new DateTime(2017, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 4
                        });
                });

            modelBuilder.Entity("PaymentManager.Data.Entities.Models.CardPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("PaymentId");

                    b.ToTable("CardPayments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 99.99m,
                            CardId = 1,
                            CreatedAt = new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentId = 1
                        },
                        new
                        {
                            Id = 2,
                            Amount = 100m,
                            CardId = 3,
                            CreatedAt = new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentId = 1
                        },
                        new
                        {
                            Id = 3,
                            Amount = 637m,
                            CardId = 3,
                            CreatedAt = new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentId = 2
                        },
                        new
                        {
                            Id = 4,
                            Amount = 33.7m,
                            CardId = 2,
                            CreatedAt = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentId = 3
                        },
                        new
                        {
                            Id = 5,
                            Amount = 7000m,
                            CardId = 1,
                            CreatedAt = new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentId = 3
                        });
                });

            modelBuilder.Entity("PaymentManager.Data.Entities.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ExecutedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentStatus")
                        .HasColumnType("int");

                    b.Property<int>("ReceiverCardId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverCardId");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Rodendanska cestitka",
                            ExecutedAt = new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentStatus = 1,
                            ReceiverCardId = 2
                        },
                        new
                        {
                            Id = 2,
                            Description = "Rodendanska cestitka za dogodine",
                            ExecutedAt = new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentStatus = 0,
                            ReceiverCardId = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "Povrat sredstava",
                            ExecutedAt = new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentStatus = 3,
                            ReceiverCardId = 4
                        },
                        new
                        {
                            Id = 4,
                            Description = "Greskom odradena uplata",
                            ExecutedAt = new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentStatus = 2,
                            ReceiverCardId = 3
                        });
                });

            modelBuilder.Entity("PaymentManager.Data.Entities.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oib")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Marko",
                            LastName = "Markovic",
                            Oib = "98765678345"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Marjan",
                            LastName = "Marjanovic",
                            Oib = "6783947345"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Ivo",
                            LastName = "Ivic",
                            Oib = "98767898765"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Pero",
                            LastName = "Peric",
                            Oib = "234567887633"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Luka",
                            LastName = "Lukovic",
                            Oib = "67876432554"
                        });
                });

            modelBuilder.Entity("PaymentManager.Data.Entities.Models.Card", b =>
                {
                    b.HasOne("PaymentManager.Data.Entities.Models.User", "User")
                        .WithMany("Cards")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PaymentManager.Data.Entities.Models.CardPayment", b =>
                {
                    b.HasOne("PaymentManager.Data.Entities.Models.Card", "Card")
                        .WithMany("CardPayments")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PaymentManager.Data.Entities.Models.Payment", "Payment")
                        .WithMany("SenderCardPayments")
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("PaymentManager.Data.Entities.Models.Payment", b =>
                {
                    b.HasOne("PaymentManager.Data.Entities.Models.Card", "ReceiverCard")
                        .WithMany()
                        .HasForeignKey("ReceiverCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReceiverCard");
                });

            modelBuilder.Entity("PaymentManager.Data.Entities.Models.Card", b =>
                {
                    b.Navigation("CardPayments");
                });

            modelBuilder.Entity("PaymentManager.Data.Entities.Models.Payment", b =>
                {
                    b.Navigation("SenderCardPayments");
                });

            modelBuilder.Entity("PaymentManager.Data.Entities.Models.User", b =>
                {
                    b.Navigation("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}
