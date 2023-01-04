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

Console.WriteLine("-----------------------------------------");
Console.WriteLine("Validate with My Algorithm Implementation");
Console.WriteLine("-----------------------------------------");
foreach (var address in ipAddresses)
{
    Console.WriteLine($"{address} is valid: {IPAddressValidator.IPAddressValidator.Validate(address)}");
}

Console.WriteLine("");

Console.WriteLine("-------------------");
Console.WriteLine("Validate with Regex");
Console.WriteLine("-------------------");
foreach (var address in ipAddresses)
{
    Console.WriteLine($"{address} is valid: {IPAddressValidator.IPAddressValidator.ValidateRegex(address)}");
}