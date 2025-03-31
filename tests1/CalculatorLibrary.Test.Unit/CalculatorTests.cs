using CalculatorLibrary;
using FluentAssertions;
using Xunit.Abstractions;

namespace CalculatorLibrary.Test.Unit;

public class CalculatorTests : IDisposable
{
    private readonly Calculator _sut = new();
    private readonly ITestOutputHelper _testOutputHelper;

    public CalculatorTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
        _testOutputHelper.WriteLine($"Hello from ctor");
    }

    [Theory]
    [InlineData(4, 5, 9)]
    [InlineData(0, 0, 0)]
    public void Add_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers(int a, int b, int expected)
    {
        var result = _sut.Add(a, b);
        //act

        //assert
        // Assert.Equal(expected, result);
        result.Should().Be(expected);
    }

    [Fact]
    public void Add_ShouldSubtractTwoNumbers_WhenTwoNumbersAreIntegers()
    {
        var result = _sut.Subtract(5, 4);
        //act
        _testOutputHelper.WriteLine($"Hello from subtract method");
        //assert
        Assert.Equal(1, result);
    }

    public void Dispose()
    {
        _testOutputHelper.WriteLine($"Hello from Dispose");
    }
}