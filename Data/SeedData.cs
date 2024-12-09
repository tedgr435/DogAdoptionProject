﻿
using Microsoft.EntityFrameworkCore;
using DogAdoptionProject.Models;
namespace DogAdoptionProject.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new DogAdoptionProjectContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DogAdoptionProjectContext>>());
            //Seed Users
            if (context == null || context.User == null)
            {
                throw new NullReferenceException(
                    "Null BlazorWebAppMoviesContext or Student DbSet");
            }

            if (context.User.Any())
            {
                return;
            }

            context.User.AddRange(
                new User
                {
                    Username = "Anne",
                    Password = "password",
                    Email = "123@abc.com",
                    Level = 1, 
                },
               new User
               {
                   Username = "Simone",
                   Password = "password",
                   Email = "123@abc.com",
                   Level = 0,
               },
                new User
                {
                    Username = "Ken",
                    Password = "password",
                    Email = "123@abc.com",
                    Level = 1,
                },
                 new User
                 {
                     Username = "Dalton",
                     Password = "password",
                     Email = "123@abc.com",
                     Level = 0,

                 });

            //Seed Dogs
            if (context == null || context.Dog == null)
            {
                throw new NullReferenceException(
                    "Null BlazorWebAppMoviesContext or Student DbSet");
            }

            if (context.Dog.Any())
            {
                return;
            }

            context.Dog.AddRange(
                new Dog
                {

                    Name = "Anne",
                    Description = "Dog1.jpg",
                    Status = "Available",
                    Type = "Great Dane",
                },
               new Dog
               {

                   Name = "Ted",
                   Description = "Dog2.jpg",
                   Status = "Available",
                   Type = "Golden Retriever",
               },
                new Dog
                {

                    Name = "Max",
                    Description = "Dog3.jpg",
                    Status = "Available",
                    Type = "Pug",
                },
                 new Dog
                 {

                     Name = "Spot",
                     Description = "Dog4.jpg",
                     Status = "Available",
                     Type = "Poodle",
                 },
                 new Dog
                 {

                     Name = "Fido",
                     Description = "Dog5.jpg",
                     Status = "Available",
                     Type = "Golden Retriever",
                 },
                 new Dog
                 {

                     Name = "Ace",
                     Description = "Dog6.jpg",
                     Status = "Available",
                     Type = "Great Dane",
                 },
                 new Dog
                 {

                     Name = "Minnie",
                     Description = "Dog7.jpg",
                     Status = "Available",
                     Type = "Golden Retriever",
                 },
                 new Dog
                 {

                     Name = "Max",
                     Description = "Dog8.jpg",
                     Status = "Available",
                     Type = "Pug",
                 });

            //Seed Applications
            if (context == null || context.Application == null)
            {
                throw new NullReferenceException(
                    "Null BlazorWebAppMoviesContext or Student DbSet");
            }

            if (context.Application.Any())
            {
                return;
            }

            context.Application.AddRange(
                new Application
                {
                    dogId = 1,
                    userId = 1,
                    Status = "Approved",
                    House = "Large",
                    Name = "Roger",
                    Description = "",
                    Dependents = "",
                },
               new Application
               {
                   dogId = 2,
                   userId = 2,
                   Status = "Pending",
                   House = "Large",
                   Name = "Ales",
                   Description = "",
                   Dependents = "",
               },
                new Application
                {
                    dogId = 3,
                    userId = 3,
                    Status = "Approved",
                    House = "Large",
                    Name = "Mane",
                    Description = "",
                    Dependents = "",
                },
                 new Application
                 {
                     dogId = 3,
                     userId = 4,
                     Status = "Rejected",
                     House = "Large",
                     Name = "Richard",
                     Description = "",
                     Dependents = "",
                 });


            context.SaveChanges();
        }
    }
}



