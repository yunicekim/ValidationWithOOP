using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YKAssignment5.YKUtilityClasses
{
    public static class YKValidations
    {
        //Write a Boolean method that validates a Canadian Postal Code pattern(A3A 3A3), 
        //ensuring the first letter is one of the valid 18 letters, 
        //and the remaining letters are one of the valid 20 letters.
        //Accept either upper case or lower case and the space is optional.
        //If the string is null or empty, return true.
        public static bool ValidateCanadianPostalCode(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return true;
            }
            else
            {
                Regex rx = new Regex(@"^[ABCEGHJKLMNPRSTVXY][0-9][ABCEFHJKLMNPRSTVWXYZ] ?[0-9][ABCEFHJKLMNPRSTVWXYZ][0-9]$", RegexOptions.IgnoreCase);
                return rx.IsMatch(input);
            }
        }

        //Write a Boolean method that extracts the digits from a string 
        //representing a US Zip Code and 
        //confirms that it contains either 5 or 9 digits.  
        //This should be a one-liner.
        public static bool ValidateUPZipCode(string input)
        {
            return YKStringUtilities.RemovePunctuation(input).Length == 5 || YKStringUtilities.RemovePunctuation(input).Length == 9;
        }

        //Write a Boolean method that extracts the digits from a string 
        //representing a phone number and 
        //confirms that it contains exactly 10 digits.
        public static bool ValidatePhoneNumber(string input)
        {
            return YKStringUtilities.RemovePunctuation(input).Length == 10;
        }
    }
}
