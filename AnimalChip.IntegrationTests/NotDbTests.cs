using AnimalChip.ModelCRUDwithoutDatabase;
using AnimalChip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AnimalChip.IntegrationTests
{
    public class NotDbTests
    {
        [Fact]
        public void AddPAnimalToList_AddedAnimal()
        {
            Animal animal = new Animal { Name = "Mouse", Breed = "Mouse", Chip = "111111" };
            List<Animal> animals = new List<Animal>();

            NotDb.addAnimal(animals, animal);

            Assert.True(animals.Count == 1);
            Assert.Contains<Animal>(animal, animals);
        }

        [Fact]
        public void AddAnimalToList_NullName_ShouldFail()
        {
            Animal animal = new Animal { Name = "", Breed = "Breed", Chip = "Chip"};
            List<Animal> animals = new List<Animal>();

            Assert.Throws<ArgumentException>(animal.Name, () => NotDb.addAnimal(animals, animal));
        }

        [Fact]
        public void AddAnimalToList_NullBreed_ShouldFail()
        {
            Animal animal = new Animal { Name = "Name", Breed = "", Chip = "Chip" };
            List<Animal> animals = new List<Animal>();

            Assert.Throws<ArgumentException>(animal.Breed, () => NotDb.addAnimal(animals, animal));
        }

        [Fact]
        public void AddAnimalToList_NullChip_ShouldFail()
        {
            Animal animal = new Animal { Name = "Name", Breed = "Breed", Chip = "" };
            List<Animal> animals = new List<Animal>();

            Assert.Throws<ArgumentException>(animal.Chip, () => NotDb.addAnimal(animals, animal));
        }

        [Fact]
        public void AddAnimalsToList_AddedAnimals()
        {
            List<Animal> animals = new List<Animal>();

            NotDb.addAnimals(animals);

            Assert.True(animals.Count == 3);

        }

        [Fact]
        public void DeleteAnimalFromList_ShowAnimalsNameAndDeletes()
        {
            List<Animal> animals = new List<Animal>();
            NotDb.addAnimals(animals);

            var response = NotDb.deleteAnimal(animals, 0);

            Assert.True(animals.Count == 2);
            Assert.Equal("Dog", animals[0].Name);
            Assert.Equal("Usunięte zostanie zwierzę o numerze 0 o nazwie: Cat", response);
        }

        [Theory]
        [InlineData("C", "Cow", "123456")]
        [InlineData("Wo", "Wolf", "654321")]
        public void AddAnimalToList_NameIsLessThan3CharsLenght_ShouldFail(string Name, string Breed, string Chip)
        {
            Animal animal = new Animal { Name = Name, Breed = Breed, Chip = Chip };
            List<Animal> animals = new List<Animal>();

            Assert.Throws<ArgumentException>(Name, () => NotDb.addAnimal(animals, animal));
        }
    }
}
