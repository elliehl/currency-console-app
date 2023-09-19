using FluentAssertions;
using Test123;

namespace RateClassTest;

public class RateCalculatorTests
{

    private RateCalculator _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new RateCalculator();
    }

    [TestCase("gbp", "eur", 10, 11.6)]
    [TestCase("eur", "gbp", 10, 8.6)]
    [TestCase("usd", "eur", 10, 9)]
    public void ConvertCurrency_ShouldReturnCorrectConvertedValue(string startingCurrency, string targetCurrency, double value, double expectedValue)

    {
        // Act
        var result = _sut.ConvertCurrency(startingCurrency, targetCurrency, value);

        // Assert
        result.Should().Be(expectedValue);
    }

    [TestCase("abc")]
    [TestCase("123")]
    [TestCase("gbpp")]
    public void ConvertCurrency_ShouldReturnZero_WhenStartingCurrencyIsInvalid(string startingCurrency)

    {
        // Act
        var result = _sut.ConvertCurrency(startingCurrency, "eur", 10);

        // Assert
        result.Should().Be(0);
    }
}
