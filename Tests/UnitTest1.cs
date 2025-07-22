using Xunit;

namespace pipelines_dotnet_core.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        int x = 5;
        int y = 5;

        // Act & Assert
        Assert.Equal(x, y);
    }
}