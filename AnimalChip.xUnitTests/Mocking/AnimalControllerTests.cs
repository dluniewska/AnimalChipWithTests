using AnimalChip.Controllers;
using AnimalChip.Data;
using AnimalChip.Mocking;
using AnimalChip.Models;
using Microsoft.AspNetCore.Identity;
using Moq;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace AnimalChip.xUnitTests.Mocking
{
    public class AnimalControllerTests
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IAnimalsStorage storage;


        [Fact]
        public async void DeleteAnimal_WhenCalled_DeleteAnimalFromDatabase()
        {
            var storage = new Mock<IAnimalsStorage>();
            var controller = new AnimalsController(_context, _userManager, storage.Object);

            await controller.DeleteConfirmed(1);

            storage.Verify(s => s.DeleteAnimal(1));
        }

        [Fact]
        public async void CreateAnimal_WhenCalled_CreateAnimalInDatabase()
        {
            var animal = new Animal() { Name = "Mouse", Kind = "Mouse", Breed = "Mouse", 
                Chip = "111111", BirthDate = DateTime.Now, Contact = "111111111" };
            var storage = new Mock<IAnimalsStorage>();
            var controller = new AnimalsController(_context, _userManager, storage.Object);

            var result = controller.Create(animal);
            Assert.NotNull(result);
            result.Equals(HttpStatusCode.OK);

        }
        [Fact]
        public async Task Index_GetAnimal_ReturnsOk()
        {

            //arrange
            var animalsController = new AnimalsController(_context, _userManager, storage);
            //act
            var animals = animalsController.IndexYourAnimal();
            //assert

            //Assert.IsType<PageResult>(animals);
            animals.Equals(HttpStatusCode.OK);
        }

        [Fact]
        public async void Index_WhenCalled_ReturnsAnimalList()
        {
            var storage = new Mock<IAnimalsStorage>();
            var controller = new AnimalsController(_context, _userManager, storage.Object);

            await controller.Index();

            storage.Verify(s => s.GetAnimals());
        }
    }
}
