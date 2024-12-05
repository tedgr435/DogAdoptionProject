using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DogAdoptionProject.Models;

namespace DogAdoptionProject.Data
{
    public class DogAdoptionProjectContext : DbContext
    {
        public DogAdoptionProjectContext (DbContextOptions<DogAdoptionProjectContext> options)
            : base(options)
        {
        }

        public DbSet<DogAdoptionProject.Models.Application> Application { get; set; } = default!;
        public DbSet<DogAdoptionProject.Models.Dog> Dog { get; set; } = default!;
        public DbSet<DogAdoptionProject.Models.User> User { get; set; } = default!;
    }
}
