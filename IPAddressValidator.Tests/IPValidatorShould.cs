namespace IPAddressValidator.Tests;

public class IPValidatorShould
{
    [Test]
    [Category("IPv4 Validators")]
    [TestCase("192.168.2.1", ExpectedResult = true, TestName = "[192.168.2.1] should be valid.")]
    [TestCase("192.168.2.01", ExpectedResult = false, TestName = "[192.168.2.01] has leading 0. Should be invalid.")]
    [TestCase("0.168.2.01", ExpectedResult = false, TestName = "[0.168.2.01] has leading 0. Should be invalid.")]
    [TestCase("02.168.2.01", ExpectedResult = false, TestName = "[02.168.2.01] has leading 0. Should be invalid.")]
    [TestCase("0.168.0.1", ExpectedResult = true, TestName = "[0.168.0.1] should be valid.")]
    [TestCase("192.168.1", ExpectedResult = false, TestName = "[192.168.1] has only 3 octets. Should be invalid.")]
    [TestCase("0192.168.2.1", ExpectedResult = false, TestName = "[0192.168.2.1] has leading 0. Should be invalid.")]
    [TestCase("256.168.2.1", ExpectedResult = false, TestName = "[256.168.2.1] One or more octets is bigger than 255. Should be invalid.")]
    [TestCase("255.255.255.255", ExpectedResult = true, TestName = "[255.255.255.255] should be valid.")]
    [TestCase("256.255.255.255", ExpectedResult = false, TestName = "[256.255.255.255] One or more octet is bigger than 255. Should be invalid.")]
    [TestCase("0.0.0.0", ExpectedResult = true, TestName = "[0.0.0.0] should be valid.")]
    [TestCase("1.1.1.1", ExpectedResult = true, TestName = "[1.1.1.1] should be valid.")]
    [TestCase("1.-1.1.1", ExpectedResult = false, TestName = "[1.-1.1.1] one or more octet is negative. Should be invalid.")]
    public bool ReturnExpectedResultIfItIsValidOrNot(string ipAddress)
    {
        return IPAddressValidator.Validate(ipAddress);
    }
}