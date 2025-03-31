using FluentAssertions;

namespace CalculatorLibrary.Test.Unit;

public class ValueSampleTests
{
    private readonly ValueSample _sut = new();

    [Fact]
    public void StringAssertionsExample()
    {
        var fullName = _sut.FullName;

        fullName.Should().Be("Nick Chapsas");
    }

    [Fact]
    public void NumberAssertionsExample()
    {
        var age = _sut.Age;

        age.Should().Be(21);
    }

    [Fact]
    public void DateOfBirthAssertionsExample()
    {
        var dateOfBirth = _sut.DateOfBirth;

        dateOfBirth.Should().Be(new(2000, 6, 9));
    }

    [Fact]
    public void ObjectAssertionsExample()
    {
        var expected = new User()
        {
            FullName = "Nick Chapsas",
            Age = 21,
            DateOfBirth = new(2000, 6, 9)
        };
        var user = _sut.AppUser;
        user.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void EnumerableObjectAssertionsExample()
    {
        var expected = new User()
        {
            FullName = "Nick Chapsas",
            Age = 21,
            DateOfBirth = new(2000, 6, 9)
        };
        var users = _sut.Users.As<User[]>();

        users.Should().ContainEquivalentOf(expected);
    }

    [Fact]
    public void TestingIntenalMembersExample()
    {
        var number = _sut.InternalSecretNumber;
        number.Should().Be(42);
    }
}