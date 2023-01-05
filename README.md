# IPv4 Validator
IPv4 Validator using C# with .Net Core 6.0 (LTS).

The IPv4 address can be validated using: 
```c# 
IPAddressValidator.Validate(string ipAddress)
``` 
or 
```c#
IPAddressValidator.ValidateRegex(string ipAddress)
```

## Rules Used to Consider the Valid IP
- IP must contain exactly 4 octets
- Each octet must have at least 1 and not more than 3 digits
- Each octet that has more than 1 digit, the first digit must not be 0
- Each octet should be parsable to decimal
- Each octet after parsed as decimal, the value should be in range from 0 to 255

## Sample Inputs

|IP Address|Expected Result|Reason
|----------|:-------------:|------
|`192.168.2.1`|`true`|
|`192.168.2.01`|`false`|One or more octets have leading 0. Should be invalid.
|`0.168.2.01`|`false`|One or more octets have leading 0. Should be invalid.
|`02.168.2.01`|`false`|One or more octets have leading 0. Should be invalid.
|`0.168.0.1`|`true`|
|`192.168.1`|`false`| Has only 3 octets. Should be invalid.    
|`0192.168.2.1`|`false`|One or more octets have leading 0. Should be invalid.
|`256.168.2.1`|`false`|One or more octets are bigger than 255. Should be invalid.
|`255.255.255.255`|`true`|
|`256.255.255.255`|`false`|One or more octets are bigger than 255. Should be invalid.
|`0.0.0.0`|`true`|
|`1.1.1.1`|`true`|
|`1.-1.1.1`|`false`|One or more octets are negative. Should be invalid.

## Unit Testing
This project contains unit testing using NUnit Framework version 3.13.3