namespace IPAddressValidator.Tests;

public class IPValidatorShould
{
    [Test]
    [Category("IPv4 Validators")]
    [TestCase("192.168.2.1", ExpectedResult = true)]
    [TestCase("192.168.2.01", ExpectedResult = false)]
    [TestCase("0.168.2.01", ExpectedResult = false)]
    [TestCase("02.168.2.01", ExpectedResult = false)]
    [TestCase("0.168.0.1", ExpectedResult = true)]
    [TestCase("192.168.1", ExpectedResult = false)]
    [TestCase("0192.168.2.1", ExpectedResult = false)]
    [TestCase("256.168.2.1", ExpectedResult = false)]
    [TestCase("255.255.255.255", ExpectedResult = true)]
    [TestCase("256.255.255.255", ExpectedResult = false)]
    [TestCase("0.0.0.0", ExpectedResult = true)]
    [TestCase("1.1.1.1", ExpectedResult = true)]
    [TestCase("1.-1.1.1", ExpectedResult = false)]
    public bool ReturnExpectedResultIfItIsValidOrNot(string ipAddress)
    {
        return IPAddressValidator.Validate(ipAddress);
    }
}