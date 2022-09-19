using FluentAssertions;
using Transportpris.Transportberegner;
using Xunit;

namespace Transportpris.Tests;

public class PrisTester
{
    [Theory]
    [InlineData(4, 9, 0)]
    [InlineData(4, 15, 50)]
    [InlineData(6, 9, 75)]
    [InlineData(6, 30, 100)]
    [InlineData(5, 10, 100)]
    public void DifferentDistancesAndWeightsReturnDifferentPrices(int distance, int weight, int expectedResult)
    {
        //Arrange
        var prisBeregner = new Pris();
        
        //Act
        var pris = prisBeregner.pris(distance, weight);
        
        //Assert
        pris.Should().Be(expectedResult);
    }

}