namespace IPAddressValidator;

public static class OctetValidatorExtensions
{
    public static bool HasValidNumberOfDigits(this string octet)
    {
        // octet must have only 1-3 digits
        return octet.Length <= 3 && octet.Length >= 1;
    }

    public static bool HasNoLeadingZero(this string octet)
    {
        // if octet has only 1 digit
        // zero should consider valid
        if (octet.Length == 1) return true;
        
        // if octet has more than 1 digit and 
        // the first digit is not 0, it is valid
        return !octet[0].ToString().Equals("0");
    }

    public static bool IsParsableToDecimal(this string octet, out int octetInDecimalFormat)
    {
        // octet should be parsable to decimal (base 10)
        return int.TryParse(octet, out octetInDecimalFormat);
    }

    public static bool IsInValidRange(this string octet, int octetInDecimalFormat)
    {
        // octet in decimal (base 10) must be in range from 0 to 255
        return octetInDecimalFormat >= 0 && octetInDecimalFormat <= 255;
    }
}