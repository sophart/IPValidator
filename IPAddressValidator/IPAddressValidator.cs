namespace IPAddressValidator;

public class IPAddressValidator
{
    public static bool Validate(string ipAddress)
    {
        if (!ipAddress.HasFourOctets(out string[] octets)) return false;

        return !octets.Any(
            octet => !octet.HasValidNumberOfDigits()
                     || !octet.HasNoLeadingZero()
                     || !octet.IsParsableToDecimal(out int octetInDecimalFormat)
                     || !octet.IsInValidRange(octetInDecimalFormat)
                     );
        
    }
}