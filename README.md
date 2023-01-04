# IPValidator
IP Validator using C# with .Net Core 6.0 (LTS)

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