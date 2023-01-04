using System.Numerics;
using System.Text.RegularExpressions;

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

    public static bool ValidateRegex(string ipAddress)
    {
        // Using Regex from: https://stackoverflow.com/a/36760050
        var rx = new Regex(@"^((25[0-5]|(2[0-4]|1\d|[1-9]|)\d)(\.(?!$)|$)){4}$");

        return rx.IsMatch(ipAddress);
    }
}