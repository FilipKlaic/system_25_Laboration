namespace Y2015D01.Tests;

public class FloorTests
{
    //metodnamn_scenario_returnar
    [Fact]
    public void Check_HowManyTimes_SantaHasMoved()
    {
        //Arrange
        var sut = new Floor();
        //Act
        var actual = sut.Check("(())");
        //Assert
        Assert.Equal(0, actual);

    }




    [Theory]
    [InlineData("(())", 0)]
    [InlineData("()()", 0)]
    [InlineData("(((", 3)]
    [InlineData("(()(()(", 3)]
    [InlineData("))(((((", 3)]
    [InlineData("())", -1)]
    [InlineData("))(", -1)]
    [InlineData(")))", -3)]
    [InlineData(")())())", -3)]
    public void Check_WhichFloor_SantaHasMovedTo(string floor, int expected)
    {
        //Arrange
        var sut = new Floor();


        //Act
        var actual = sut.Check(floor);


        //Assert
        Assert.Equal(expected, actual);
    }

    // Del 2

    [Theory]
    [InlineData(")", 1)]
    [InlineData("()())", 5)]
    public void ChangedValue_OfSecondDirection_ReturnsPositive(string floor, int expected)
    {
        //Arrange
        var sut = new Floor();
        //Act
        var actual = sut.ChangedValue(floor);
        //Assert
        Assert.Equal(expected, actual);
    }

}