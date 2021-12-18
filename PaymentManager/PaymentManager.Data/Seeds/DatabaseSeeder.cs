using Microsoft.EntityFrameworkCore;
using PaymentManager.Data.Entities.Enums;
using PaymentManager.Data.Entities.Models;
using System;
using System.Collections.Generic;

namespace PaymentManager.Data.Seeds
{
    public class DatabaseSeeder
    {
        public static void Execute(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(new List<User>
                {
                    new User
                    {
                        Id = 1,
                        FirstName = "Marko",
                        LastName = "Markovic",
                        Oib = "98765678345",
                    },
                    new User
                    {
                        Id = 2,
                        FirstName = "Marjan",
                        LastName = "Marjanovic",
                        Oib = "6783947345",
                    },
                    new User
                    {
                        Id = 3,
                        FirstName = "Ivo",
                        LastName = "Ivic",
                        Oib = "98767898765",
                    },
                    new User
                    {
                        Id = 4,
                        FirstName = "Pero",
                        LastName = "Peric",
                        Oib = "234567887633",
                    },
                    new User
                    {
                        Id = 5,
                        FirstName = "Luka",
                        LastName = "Lukovic",
                        Oib = "67876432554",
                    }
                });

            builder.Entity<Card>()
                .HasData(new List<Card>
                {
                    new Card
                    {
                        Id = 1,
                        Iban = "1234567890",
                        Balance = 100m,
                        RegisteredAt = new DateTime(2020, 2, 12),
                        UserId = 1,
                    },
                    new Card
                    {
                        Id = 2,
                        Iban = "298765432",
                        Balance = 92100m,
                        RegisteredAt = new DateTime(2019, 3, 14),
                        UserId = 2,
                    },
                    new Card
                    {
                        Id = 3,
                        Iban = "76584932234",
                        Balance = 0m,
                        RegisteredAt = new DateTime(2021, 10, 2),
                        UserId = 3,
                    },
                    new Card
                    {
                        Id = 4,
                        Iban = "1234567890",
                        Balance = 14500m,
                        RegisteredAt = new DateTime(2010, 11, 11),
                        UserId = 4,
                    },
                    new Card
                    {
                        Id = 5,
                        Iban = "89876542345",
                        Balance = 1324m,
                        RegisteredAt = new DateTime(2017, 5, 6),
                        UserId = 4,
                    },
                });

            builder.Entity<Payment>()
                .HasData(new List<Payment>
                {
                    new Payment
                    {
                        Id = 1,
                        Description = "Rodendanska cestitka",
                        ExecutedAt = new DateTime(2021, 5, 20),
                        ReceiverCardId = 2,
                        PaymentStatus = PaymentStatus.Complete,
                    },
                    new Payment
                    {
                        Id = 2,
                        Description = "Rodendanska cestitka za dogodine",
                        ExecutedAt = new DateTime(2022, 5, 20),
                        ReceiverCardId = 2,
                        PaymentStatus = PaymentStatus.Pending,
                    },
                    new Payment
                    {
                        Id = 3,
                        Description = "Povrat sredstava",
                        ExecutedAt = new DateTime(2020, 10, 5),
                        ReceiverCardId = 4,
                        PaymentStatus = PaymentStatus.Refunded,
                    },
                    new Payment
                    {
                        Id = 4,
                        Description = "Greskom odradena uplata",
                        ExecutedAt = new DateTime(2021, 12, 12),
                        ReceiverCardId = 3,
                        PaymentStatus = PaymentStatus.Abandoned,
                    }
                });

            builder.Entity<CardPayment>()
               .HasData(new List<CardPayment>
               {
                    new CardPayment
                    {
                        Id = 1,
                        CardId = 1,
                        CreatedAt = new DateTime(2021, 5, 14),
                        PaymentId = 1,
                    },
                    new CardPayment
                    {
                        Id = 2,
                        CardId = 3,
                        CreatedAt = new DateTime(2021, 1, 3),
                        PaymentId = 1,
                    },
                    new CardPayment
                    {
                        Id = 3,
                        CardId = 3,
                        CreatedAt = new DateTime(2021, 10, 21),
                        PaymentId = 2,
                    },
                    new CardPayment
                    {
                        Id = 4,
                        CardId = 2,
                        CreatedAt = new DateTime(2020, 1, 1),
                        PaymentId = 3,
                    },
                    new CardPayment
                    {
                        Id = 5,
                        CardId = 1,
                        CreatedAt = new DateTime(2021, 11, 11),
                        PaymentId = 3,
                    },
               });
        }
    }
}
