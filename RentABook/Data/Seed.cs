﻿using RentABook.Models;

namespace RentABook.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new List<Book>()
                    {
                        new Book()
                        {
                            Author = "Chinua Achebe",
                            Country = "Nigeria",
                            ImageLink = "images/things-fall-apart.jpg",
                            Language = "English",
                            Link = "https://en.wikipedia.org/wiki/Things_Fall_Apart\n",
                            Page = 209,
                            Title = "Things Fall Apart",
                            Year = 1958,
                            PriceId = 2,

                        },
                        new Book()
                        {
                            Author = "Chinua Achebe",
                            Country = "Nigeria",
                            ImageLink = "images/things-fall-apart.jpg",
                            Language = "English",
                            Link = "https://en.wikipedia.org/wiki/Things_Fall_Apart\n",
                            Page = 209,
                            Title = "Things Fall Apart",
                            Year = 1958,
                            PriceId = 3
                        },
                        new Book()
                        {

                            Author = "Hans Christian Andersen",
                            Country = "Denmark",
                            ImageLink = "images/fairy-tales.jpg",
                            Language = "Danish",
                            Link = "https://en.wikipedia.org/wiki/Fairy_Tales_Told_for_Children._First_Collection.\n",
                            Page = 784,
                            Title = "Fairy tales",
                            Year = 1836,
                            PriceId = 4
                        },
                        new Book()
                        {
                            Author = "Dante Alighieri",
                            Country = "Italy",
                            ImageLink = "images/the-divine-comedy.jpg",
                            Language = "Italian",
                            Link = "https://en.wikipedia.org/wiki/Divine_Comedy\n",
                            Page = 928,
                            Title = "The Divine Comedy",
                            Year = 1315,
                            PriceId = 5
                        },
                        new Book()
                        {
                            Author = "Unknown",
                            Country = "Sumer and Akkadian Empire",
                            ImageLink = "images/the-epic-of-gilgamesh.jpg",
                            Language = "Akkadian",
                            Link = "https://en.wikipedia.org/wiki/Epic_of_Gilgamesh\n",
                            Page = 160,
                            Title = "The Epic Of Gilgamesh",
                            Year = -1700,
                            PriceId = 6
                        },
                        new Book()
                        {
                            Author = "Unknown",
                            Country = "Achaemenid Empire",
                            ImageLink = "images/the-book-of-job.jpg",
                            Language = "Hebrew",
                            Link = "https://en.wikipedia.org/wiki/Book_of_Job\n",
                            Page = 176,
                            Title = "The Book Of Job",
                            Year = -600,
                            PriceId = 7

                        },

                        new Book()
                        {
                            Author = "Unknown",
                            Country = "India/Iran/Iraq/Egypt/Tajikistan",
                            ImageLink = "images/one-thousand-and-one-nights.jpg",
                            Language = "Arabic",
                            Link = "https://en.wikipedia.org/wiki/One_Thousand_and_One_Nights\n",
                            Page = 288,
                            Title = "One Thousand and One Nights",
                            Year = 1200,
                            PriceId = 8
                        },

                        new Book()
                        {
                            Author = "Unknown",
                            Country = "Iceland",
                            ImageLink = "images/njals-saga.jpg",
                            Language = "Old Norse",
                            Link = "https://en.wikipedia.org/wiki/Nj%C3%A1ls_saga\n",
                            Page = 384,
                            Title = "Nj\u00e1l's Saga",
                            Year = 1350,
                            PriceId = 8
                        },
                        new Book()
                        {
                            Author = "Jane Austen",
                            Country = "United Kingdom",
                            ImageLink = "images/pride-and-prejudice.jpg",
                            Language = "English",
                            Link = "https://en.wikipedia.org/wiki/Pride_and_Prejudice\n",
                            Page = 226,
                            Title = "Pride and Prejudice",
                            Year = 1813,
                            PriceId = 9
                        },

                        new Book()
                        {
                            Author = "Honor\u00e9 de Balzac",
                            Country = "France",
                            ImageLink = "images/le-pere-goriot.jpg",
                            Language = "French",
                            Link = "https://en.wikipedia.org/wiki/Le_P%C3%A8re_Goriot\n",
                            Page = 443,
                            Title = "Le P\u00e8re Goriot",
                            Year = 1835,
                            PriceId = 10
                        },

                        new Book()
                        {
                            Author = "Samuel Beckett",
                            Country = "Republic of Ireland",
                            ImageLink = "images/molloy-malone-dies-the-unnamable.jpg",
                            Language = "French, English",
                            Link = "https://en.wikipedia.org/wiki/Molloy_(novel)\n",
                            Page = 256,
                            Title = "Molloy, Malone Dies, The Unnamable, the trilogy",
                            Year = 1952,
                            PriceId = 11
                        },

                        new Book()
                        {
                            Author = "Giovanni Boccaccio",
                            Country = "Italy",
                            ImageLink = "images/the-decameron.jpg",
                            Language = "Italian",
                            Link = "https://en.wikipedia.org/wiki/The_Decameron\n",
                            Page = 1024,
                            Title = "The Decameron",
                            Year = 1351,
                            PriceId = 12
                        },
                        new Book()
                        {
                            Author = "Jorge Luis Borges",
                            Country = "Argentina",
                            ImageLink = "images/ficciones.jpg",
                            Language = "Spanish",
                            Link = "https://en.wikipedia.org/wiki/Ficciones\n",
                            Page = 224,
                            Title = "Ficciones",
                            Year = 1965,
                            PriceId= 1,

                        }

                    });
                    context.Prices.AddRange(new List<Price>()
                    {
                        new Price() {
                            Id = 1,
                            OriginalPrice = 10,
                            DiscountRatio = 0.2f,
                            DiscountedPrice = 8,


                        },
                            new Price() {
                            Id = 2,
                            OriginalPrice = 20,
                            DiscountRatio = 0.25f,
                            DiscountedPrice = 8,
                        },

                            new Price() {
                            Id = 3,
                            OriginalPrice = 30,
                            DiscountRatio = 0.2f,
                            DiscountedPrice = 8,
                        },
                            new Price() {
                            Id = 4,
                            OriginalPrice = 50,
                            DiscountRatio = 0.2f,
                            DiscountedPrice = 8,
                        },
                             new Price() {
                            Id = 5,
                            OriginalPrice = 80,
                            DiscountRatio = 0.2f,
                            DiscountedPrice = 8,
                        },
                            new Price() {
                            Id = 6,
                            OriginalPrice = 90,
                            DiscountRatio = 0.4f,
                            DiscountedPrice = 8,


                        },
                            new Price() {
                            Id = 7,
                            OriginalPrice = 20,
                            DiscountRatio = 0.2f,
                            DiscountedPrice = 8,
                        },

                            new Price() {
                            Id = 8,
                            OriginalPrice = 40,
                            DiscountRatio = 0.25f,
                            DiscountedPrice = 8,
                        },
                            new Price() {
                            Id = 9,
                            OriginalPrice = 32,
                            DiscountRatio = 0.2f,
                            DiscountedPrice = 8,
                        },
                             new Price() {
                            Id = 10,
                            OriginalPrice = 28,
                            DiscountRatio = 0.2f,
                            DiscountedPrice = 8,
                        },
                            new Price() {
                            Id = 11,
                            OriginalPrice = 65,
                            DiscountRatio = 0.4f,
                            DiscountedPrice = 8,
                        },
                            new Price() {
                            Id = 12,
                            OriginalPrice = 12,
                            DiscountRatio = 0.3f,
                            DiscountedPrice = 8,
                        },
                             new Price() {
                            Id = 13,
                            OriginalPrice = 45,
                            DiscountRatio = 0.3f,
                            DiscountedPrice = 8,
                        }

                    });




                }
            }
        }
    }
}



