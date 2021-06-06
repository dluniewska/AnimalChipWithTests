using AnimalChip.Data;
using AnimalChip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalChip.IntegrationTests
{
    public static class Utilities
    {
        public static void InitializeDbForTests(ApplicationDbContext db)
        {
            db.Animal.AddRange(GetSeedingAnimals());
            db.SaveChanges();
        }

        public static void ReinitializeDbForTests(ApplicationDbContext db)
        {
            db.Animal.RemoveRange(db.Animal);
            InitializeDbForTests(db);
        }

        public static List<Animal> GetSeedingAnimals()
        {
            return new List<Animal>()
            {
                new Animal(){ Name ="Cat", BirthDate= DateTime.Now, Breed = "Cat", Chip="666666", Contact = "666666666", Email="test@test", Kind="Cat" },
                new Animal(){ Name ="Dog", BirthDate= DateTime.Now, Breed = "Dog", Chip="555555", Contact = "555555555", Email="test@test", Kind="Dog" },
                new Animal(){ Name ="Rat", BirthDate= DateTime.Now, Breed = "Rat", Chip="777777", Contact = "777777777", Email="test@test", Kind="Rat" }
            };
        }
    }
}