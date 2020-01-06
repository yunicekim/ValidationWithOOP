using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YKAssignment5.YKUtilityClasses
{
    public static class YKStringUtilities
    {
        //accepts a string as a parameter.  
        public static string Capitalize(string input)
        {
            //Have it drop the whole string to lower case, 
            input = input.Trim().ToLower();

            //If the original string was null, return null. 

            if (input == "")
            {
                return null;
            }

            string[] capArray = input.Split(' ');
            string result = "";

            for (int i = 0; i < capArray.Length; i++)
            {
                /*
                char[] chArray = capArray[i].ToArray();
                chArray[0] = char.ToUpper(chArray[0]);
                */
                string temp = capArray[i];

                for (int j = 0; j<capArray[i].Length; j++)
                {
                    if (j == 0)
                    {
                        //then capitalize the first letter of every word.  
                        result += temp[0].ToString().ToUpper();
                    }
                    else
                    {
                        result += temp[j];
                    }
                }

                if (i != capArray.Length - 1)
                {
                    result += " ";
                }
            }
            /*
            string result = "";
            foreach (string item in capArray)
            {
                result += item;
            }
            */
            //Return the capitalized string.  
            return result;
        }

        //Write a static string method that accepts a string parameter and 
        //returns a string with just the digits from it.
        public static string RemovePunctuation(string input)
        {
            input = YKNumericUtilities.MakeNumber(input);
            return input;
        }

        //Write a static string method that accepts a string with 7 or 10 digits and 
        //reformats it into either the 123-1234 or 123-123-1234 pattern.
        public static string FormatPhoneNumber(string input)
        {
            return RemovePunctuation(input).Insert(3, "-").Insert(7,"-");
        }

        //Write a static string method that accepts a string representing a Canadian Postal Code, 
        public static string FormatCanadianPostalCode(string input)
        {
            //If the original string is null, just return null.
            if (input == "")
            {
                return null;
            }
            //shifts it to upper case 
            input = input.Trim().ToUpper();
            
            //and inserts the space if it is missing (and the length permits doing so).  
            if (!input.Contains(' '))
            {
                input = input.Insert(3, " ");
            }

            return input;
        }

        //Write a static string method that accepts a string with 5 or 9 digits 
        public static string FormatUSZipCode(string input)
        {
            if (input == "")
            {
                return null;
            }

            input = input.Trim();

            if (input.Length == 5)
            {
                //and reformats it into 
                return input;
            }
            else if (input.Length == 9)
            {
                //either the 12345 or 12345-1234 pattern.
                return input.Insert(5, "-");
            }
            else
            {
                return null;
            }
        }

        //Create a string method called FullName that 
        //accepts two strings (any case): 
        public static string MakeFullName(string firstName, string lastName)
        {
            firstName = Capitalize(firstName.Trim());
            lastName = Capitalize(lastName.Trim());

            //one the first name, one the last name, and 
            if (lastName != "")
            {
                if (firstName != "")
                {
                    //returns the full name, capitalized, in the form: Turton, David.
                    return lastName + ", " + firstName;
                }
                else
                {
                    //i.If only one of the names is provided, just return that, with no punctuation.
                    return lastName;
                }
            }
            else
            {
                if (firstName != null)
                {
                    //i.If only one of the names is provided, just return that, with no punctuation.
                    return firstName;
                }
                else
                {
                    //ii.If neither name is provided, return null
                    return null;
                }
            }
            
        }

    }
}
