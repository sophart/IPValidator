namespace IPAddressValidator;

public class IPAddressValidator
{
    public static bool Validate(string ipAddress)
    {
        // ip address that has less or more than 4 octets
        // consider invalid
        if (!ipAddress.HasFourOctets(out string[] octets)) return false;

        // if there are no invalid octets in the ip address
        // the ip consider valid
        return !octets.Any(
            octet => !octet.HasValidNumberOfDigits() // one or more octets has 0 or more than 3 digits
                     || !octet.HasNoLeadingZero() // one or more octets has leading zero
                     || !octet.IsParsableToDecimal(out int octetInDecimalFormat) // one or more octets are not parsable to decimal
                     || !octet.IsInValidRange(octetInDecimalFormat) // one or more octets is less than 0 or larger than 255
                     );
    }
}