using Microsoft.EntityFrameworkCore;

namespace AnimalShelterAPI.Models
{
  public class AnimalShelterAPIContext : DbContext
  {
    public AnimalShelterAPIContext(DbContextOptions<AnimalShelterAPIContext> options)
        : base(options)
    {
    }

    // protected override void OnModelCreating(ModelBuilder builder)
    // {
    //   builder.Entity<Animal>()
    //   .HasData(
    //     new Animal { AnimalId = 1, Name = "Doggy", Species = "Dog", Age = 13, Gender = "Female", Description = "sweet old granny" },
    //     new Animal { AnimalId = 2, Name = "Dax", Species = "Dog", Age = 8, Gender = "Male", Description = "people pleaser" },
    //     new Animal { AnimalId = 3, Name = "Bruce", Species = "Dog", Age = 4, Gender = "Male", Description = "big teddy bear" },
    //     new Animal { AnimalId = 4, Name = "Kiki", Species = "Cat", Age = 6, Gender = "Female", Description = "explorer" },
    //     new Animal { AnimalId = 5, Name = "Pepper", Species = "Cat", Age = 7, Gender = "Female", Description = "hates crowds" },
    //     new Animal { AnimalId = 6, Name = "Ramona", Species = "Cat", Age = 6, Gender = "Female", Description = "super friendly" }
    //   );
    // }
    public DbSet<Animal> Animals { get; set; }
  }
}