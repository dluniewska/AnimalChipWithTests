using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Threading.Tasks;
using Xunit;

namespace AnimalChip.IntegrationTests
{
    public class BasicTests : IClassFixture<WebApplicationFactory<AnimalChip.Startup>>
    {
        private readonly WebApplicationFactory<AnimalChip.Startup> _factory;

        public BasicTests(WebApplicationFactory<AnimalChip.Startup> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/")]
        [InlineData("Animals/YourAnimals")]
        [InlineData("Animals/Delete")]
        [InlineData("Animals/Edit")]
        [InlineData("Animals/Details")]
        [InlineData("Animals/Create")]
        [InlineData("Home/Index")]
        [InlineData("Animals/Index")]

        public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            Assert.Equal("text/html; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }

    }
}
