namespace IPAddressValidator;

internal static class IPAddressValidatorExtensions
{
    public static bool HasFourOctets(this string ipAddress, out string[] octets)
    {
        octets = ipAddress.Split(".");
        
        // IPv4 address must contain 4 octet
        // return false if it has less or more than 4
        return octets.Length == 4;
    }
}