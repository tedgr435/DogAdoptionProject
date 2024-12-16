
using Microsoft.EntityFrameworkCore;
using DogAdoptionProject.Models;
using static System.Net.Mime.MediaTypeNames;
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
                    //Id = 1,
                    Username = "Anne",
                    Password = "password",
                    Email = "123@abc.com",
                    Level = 1,
                },
               new User
               {
                   //Id = 2,
                   Username = "Simone",
                   Password = "password",
                   Email = "123@abc.com",
                   Level = 0,
               },
                new User
                {
                    //Id = 3,
                    Username = "Ken",
                    Password = "password",
                    Email = "123@abc.com",
                    Level = 1,
                },
                 new User
                 {
                     //Id = 4,
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
                    //Id = 1,
                    Name = "Anne",
                    pictureUrl = "Dog1.jpg",
                    Description = "",
                    Status = "Available",
                    Type = "Great Dane",
                },
               new Dog
               {
                   //Id = 2,
                   Name = "Ted",
                   pictureUrl = "Dog2.jpg",
                   Description = "",
                   Status = "Available",
                   Type = "Golden Retriever",
               },
                new Dog
                {
                    //Id = 3,
                    Name = "Max",
                    pictureUrl = "Dog3.jpg",
                    Description = "",
                    Status = "Available",
                    Type = "Pug",
                },
                 new Dog
                 {
                     //Id = 4,
                     Name = "Spot",
                     pictureUrl = "Dog4.jpg",
                     Description = "",
                     Status = "Available",
                     Type = "Poodle",
                 },
                 new Dog
                 {
                     //Id = 5,
                     Name = "Fido",
                     pictureUrl = "Dog5.jpg",
                     Description = "",
                     Status = "Available",
                     Type = "Golden Retriever",
                 },
                 new Dog
                 {
                     //Id = 6,
                     Name = "Ace",
                     pictureUrl = "Dog6.jpg",
                     Description = "",
                     Status = "Available",
                     Type = "Great Dane",
                 },
                 new Dog
                 {
                     //Id = 7,
                     Name = "Minnie",
                     pictureUrl = "Dog7.jpg",
                     Description = "",
                     Status = "Available",
                     Type = "Golden Retriever",
                 },
                 new Dog
                 {
                     //Id = 8,
                     Name = "Max",
                     pictureUrl = "Dog8.jpg",
                     Description = "",
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
                new Models.Application
                {
                    dogId = 10,
                    userId = 9,
                    Status = "Approved",
                    House = "Large",
                    Name = "Roger",
                    Description = "Home visit",
                    Dependents = "",
                },
               new Models.Application
               {
                   dogId = 11,
                   userId = 10,
                   Status = "Pending",
                   House = "Large",
                   Name = "Ales",
                   Description = "",
                   Dependents = "",
               },
                new Models.Application
                {
                    dogId = 12,
                    userId = 11,
                    Status = "Approved",
                    House = "Large",
                    Name = "Mane",
                    Description = "",
                    Dependents = "",
                },
                 new Models.Application
                 {
                     dogId = 12,
                     userId = 12,
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



