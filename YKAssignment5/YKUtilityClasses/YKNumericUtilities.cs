using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YKAssignment5.YKUtilityClasses
{
    public static class YKNumericUtilities
    {
        //accepts a string parameter
        //return true if the parameter contains only a number.
        public static bool IsNumeric(string input)
        {
            return double.TryParse(input, out double result);
            /*
            if (input != "")
            {
                foreach (char c in input)
                {
                    if (c < '0' || c > '9')
                    {
                        return false;
                    }
                }

                return true;
            }
            

            return false;
            */
        }

        //accepts the other accepts an Object parameter.  
        //return true if the parameter contains only a number.
        public static bool IsNumeric(object input)
        {
            return IsNumeric(input.ToString());
        }
        

        //accepts a string
        //that does not contain a fractional portion (no decimal place).  
        public static bool IsInteger(string input)
        {
            return int.TryParse(input, out int result);
            /*
            if (input.Contains('.'))
            {
                return false;
            }

            //int result = 0;

            if (int.TryParse(input, out int result))
            {
                return true;
            }

            return false;
            */
        }

        //accepts one a double
        //that does not contain a fractional portion (no decimal place).  
        public static bool IsInteger(double input)
        {
            if ( input % 1 > 0 )
            {
                return false;
            }

            return true;
        }

        //accepts an object.
        //that does not contain a fractional portion (no decimal place).  

        //Users often enter currency symbols, commas, spaces and trailing dashes in numeric fields.
        //Create a string method that returns the string less everything except digits, the decimal place and a dash.
        //If there was a single dash (leading or trailing), put that as the first character.
        //If the result is numeric, return it as a string, else return null.
        public static string MakeNumber(string input)
        {
            int result = 0;

            Regex rx = new Regex(@"[$\-, ]+");
            /*
            string specialChar = @"$-, ";

            foreach (var item in specialChar)
            {
                if (input.Contains(item))
                {
                    if (input.Contains("-"))
                    {
                        input = input.Replace("-", String.Empty);
                        input = "-" + input;
                    }

                    input.Replace("$", String.Empty);
                    input.Replace(",", String.Empty);
                    input.Replace(" ", String.Empty);
                }
            }
            */
            
            if (rx.IsMatch(input))
            {
                if (input.Contains("-"))
                {
                    input = input.Replace("-", String.Empty);
                    input = "-" + input;
                }

                input = input.Replace("$", String.Empty);
                input = input.Replace(",", String.Empty);
                input = input.Replace(" ", String.Empty);
            }
            
            if (int.TryParse(input, out result))
            {
                return input;
            }

            return null;
        }

        //In the KeyPress event handler for a textbox, the KeyPressEventArgs “e” has two properties:
        //•	e.KeyChar – the character the user is trying to add to the textbox’s contents
        //•	e.Handled – if true, the character will not be added to the textbox’s contents
        //a.Create a void method that accepts a KeyPressEventArgument as a parameter.
        //If the property KeyChar is not a digit, set the property Handled to true.  
        public static void KeyPressEvent(KeyPressEventArgs e)
        {
            if (!IsNumeric(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
