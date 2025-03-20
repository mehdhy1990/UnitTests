using CalculatorLibrary;

namespace TestProject1;

public class UnitTest1
{
  
    
    
    private readonly Calculator _sut = new();
    private readonly Guid _guid = Guid.NewGuid();
    [Fact]
    public void Add_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers()
    {
        //arrange
        var calculator = new Calculator();

        var result = calculator.Add(4, 5);
        //act

        //assert
        Assert.Equal(9,result);

    }
    }
