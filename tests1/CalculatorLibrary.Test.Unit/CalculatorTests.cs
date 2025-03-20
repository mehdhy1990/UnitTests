using CalculatorLibrary;
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

    [Fact]
    public void Add_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers()
    {
        //arrange
        var calculator = new Calculator();

        var result = calculator.Add(4, 5);
        //act

        //assert
        Assert.Equal(9, result);
    }  
    [Fact]
    public void Add_ShouldSubtractTwoNumbers_WhenTwoNumbersAreIntegers()
    {
        //arrange
        var calculator = new Calculator();

        var result = calculator.Subtract(5, 4);
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