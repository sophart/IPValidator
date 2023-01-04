namespace IPAddressValidator.Tests;

public class OctetValidatorShould
{
    [Test]
    [TestCase("192", ExpectedResult = true)]
    [TestCase("1920", ExpectedResult = false)]
    [TestCase("-1", ExpectedResult = false)]
    [TestCase("0", ExpectedResult = true)]
    [TestCase("255", ExpectedResult = true)]
    [TestCase("256", ExpectedResult = false)]
    public bool ReturnAsExpectedForOctetThatIsParsableToDecimalAndInValidRangeFrom0To255(string octet)
    {
        return octet.IsParsableToDecimal(out int octetInDecimal) && octet.IsInValidRange(octetInDecimal);
    }
    
    [Test]
    [TestCase("192", ExpectedResult = true)]
    [TestCase("1920", ExpectedResult = false)]
    [TestCase("-1", ExpectedResult = true)]
    [TestCase("0", ExpectedResult = true)]
    [TestCase("02", ExpectedResult = false)]
    [TestCase("255", ExpectedResult = true)]
    public bool ReturnAsExpectedForOctetThatHasNoLeadingAndHasValidNumberOfDigits(string octet)
    {
        return octet.HasNoLeadingZero() && octet.HasValidNumberOfDigits();
    }
}