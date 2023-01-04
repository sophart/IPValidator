namespace IPAddressValidator;

public class IPAddressValidator
{
    public static bool Validate(string ipAddress)
    {
        var octets = ipAddress.Split(".");
        
        // IPv4 address must contain 4 octet
        // return false if it has less than or more than 4
        if (octets.Length != 4) return false;

        // check if there are any invalid octets
        var isThereAnyInvalidOctet = octets.Any(oct =>
        {
            // each octet contains only 1-3 digits
            // return false in case it is bigger than 3
            if (oct.Length > 3) return true;

            // each octet has at least 1 digits
            // if it has more than 1 digit and 
            // the first digit is 0, it is invalid
            if (oct.Length > 1 && oct[0].ToString().Equals("0")) return false;

            int octetInDecimalFormat;

            // each octet should be parsable to decimal (base 10)
            // if the octet is not parsable, it is invalid
            if (!int.TryParse(oct, out octetInDecimalFormat)) return true;

            // each octet in decimal (base 10) must be in range of 0 to 255
            // if it is out of that range, it is invalid
            if (octetInDecimalFormat < 0 || octetInDecimalFormat > 255) return true;

            // if all the conditions above failed
            // the octet is valid
            return false;
        });
        
        // if it is true that one of the octet is invalid
        // return from the lambda expression return false
        // or if the lambda return false,
        // the IP is valid, then return true
        return !isThereAnyInvalidOctet;
    }
}