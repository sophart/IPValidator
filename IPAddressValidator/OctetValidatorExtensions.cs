namespace IPAddressValidator;

public static class OctetValidatorExtensions
{
    public static bool HasValidNumberOfDigits(this string octet)
    {
        // each octet contains only 1-3 digits
        return octet.Length <= 3 && octet.Length >= 1;
    }

    public static bool HasNoLeadingZero(this string octet)
    {
        // if octet has only 1 digit
        // even if it is zero, it is valid
        if (octet.Length == 1) return true;
        
        // if octet has more than 1 digit and 
        // the first digit is 0, it is invalid
        return !octet[0].ToString().Equals("0");
    }

    public static bool IsParsableToDecimal(this string octet, out int octetInDecimalFormat)
    {
        // each octet should be parsable to decimal (base 10)
        // if the octet is not parsable, it is invalid
        return int.TryParse(octet, out octetInDecimalFormat);
    }

    public static bool IsInValidRange(this string octet, int octetInDecimalFormat)
    {
        // each octet in decimal (base 10) must be in range of 0 to 255
        // if it is out of that range, it is invalid
        return octetInDecimalFormat >= 0 && octetInDecimalFormat <= 255;
    }
}