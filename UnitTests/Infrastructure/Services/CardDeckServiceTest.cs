using System.Linq;
using Xunit;
using AutoFixture;
using AutoFixture.AutoMoq;
using Infrastructure.Services;

namespace UnitTests.Infrastructure.Services
{
    public class CardDeckServiceTest
    {
        [Fact]
        public void GetTotalCards()
        {
            var fixture = new Fixture().Customize(new AutoMoqCustomization());
            // Create a variable of the type
            var service = fixture.Create<CardDeckService>();
            // Get the result
            var results = service.GetCardDeck();
            // Check if Not Null
            Assert.NotNull(results);
            // Compare
            Assert.Equal(52, results.Count());
        }
    }
}
