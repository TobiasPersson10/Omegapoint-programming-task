using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaPointUppsala
{
    /// <summary>
    /// Performs modifications on a string
    /// </summary>
    public class StringModificationer
    {
        /// <summary>
        /// Trim and convert string to list of ints by calling helper methods
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<int> TrimAndConvert(string input)
        {
            string trimmedInput = TrimNumber(input);
            return ConvertStringToIntList(trimmedInput);
        }

        /// <summary>
        /// Removes non-digits and century (from 12-digit number)
        /// </summary>
        /// <param name="input"></param>
        /// <returns>String without non-digits and century-years</returns>
        private string TrimNumber(string input)
        {
            string onlyDigitsLong = RemoveNonDigits(input);
            return RemoveCentury(onlyDigitsLong);
        }

        /// <summary>
        /// Removes non-digits
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string RemoveNonDigits(string input)
        {
            return new(input.Where(x => char.IsDigit(x)).ToArray());
        }

        /// <summary>
        /// Removes century years 
        /// </summary>
        /// <param name="allDigits"></param>
        /// <returns></returns>
        private string RemoveCentury(string allDigits)
        {
            if (allDigits.Length == 12)
            {
                allDigits = allDigits[2..];
            }
            return allDigits;
        }

        /// <summary>
        /// Convert string to a list of ints. 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static List<int> ConvertStringToIntList(string str)
        {
            int digit;
            List<int> intList = new();
            for (int i = 0; i < str.Length; i++)
            {
                digit = Convert.ToInt32(str.Substring(i, 1));
                intList.Add(digit);
            }
            return intList;
        }
    }
}
