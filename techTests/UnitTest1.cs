using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace techTeamTests
{
    public class UnitTest1
        : IClassFixture<WebApplicationFactory<aprTechTeam.Startup>>
    {
        private readonly WebApplicationFactory<aprTechTeam.Startup> _factory;

        public UnitTest1(WebApplicationFactory<aprTechTeam.Startup> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/")]
        [InlineData("/Home/Index")]
        [InlineData("/Home/Danny")]
        [InlineData("/Home/Edgar")]
        [InlineData("/Home/Raul")]
        [InlineData("/Home/Kevin")]
        [InlineData("/Home/Tamiris")]
        [InlineData("/Home/Contact")]

        public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            //Assert
            response.EnsureSuccessStatusCode(); // Status code 200 - 299
            Assert.Equal("text/html; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }


    }
}
