namespace Y2023D01.Tests;

public class TrebuchetTest
{
    [Fact]
    public void GetNumbers_FromText_ReturnTwelve()
    {
        //Arrange
        var sut = new Trebuchet();
        //Act
        var actual = sut.GetNumbers("1abc2");
        //Assert
        Assert.Equal(12, actual);
        
    }

    [Theory]
    [InlineData("1abc2", 12)]
    //[InlineData("pqr3stu8vwx", 38)]
    //[InlineData("a1b2c3d4e5f", 15)]
    //[InlineData("treb7uchet", 77)]
    public void GetNumbers_FromText_ReturnValue(string text, int expected)
    {
        //Arrange
        var sut = new Trebuchet();
        //Act
        var actual = sut.GetNumbers(text);
        //Assert
        Assert.Equal(expected, actual);
    }
    
        
}