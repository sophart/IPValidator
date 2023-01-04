// See https://aka.ms/new-console-template for more information

var ipAddresses = new[]
{
    "192.168.2.1",
    "192.168.2.01",
    "0.168.2.01	",
    "02.168.2.01",
    "256.168.2.1",
    "192.168.1",
    "255.255.255.255",
    "0.0.0.0",
    "1.1.1.1",
    "1.-1.1.1"
};

foreach (var address in ipAddresses)
{
    Console.WriteLine($"{address} is valid: {IPAddressValidator.IPAddressValidator.Validate(address)}");
}
