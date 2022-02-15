using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaPointUppsala
{
    /// <summary>
    /// See if string is a valid number by different checks
    /// </summary>
    public class ValidityCheck
    {
        private readonly List<Number> numberList = new List<Number>();

        /// <summary>
        /// Check if input is NotEmptyOrNullOrWhiteSpace, then do validity checks for the number.
        /// </summary>
        /// <param name="number"></param>
        public void IsValidNumber(string number)
        {
            if(IsNullOrEmpty(number))
            {
                PrintToConsole.PrintEmpty();
            }
            else
            {
                if (IsNumber(number) && CompletesLuhn(number))
                {
                    PrintToConsole.PrintValid(number, numberList);
                }
                else
                {
                    PrintToConsole.PrintInvalid(number);
                }
            }
        }

        /// <summary>
        /// Check if it is a correct number of specific type
        /// </summary>
        /// <param name="number"></param>
        /// <returns>true if it is a valid number, false if its not</returns>
        private bool IsNumber(string number)
        {
            if (IsPersonalNumber(number))
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// Check if number is a personal number
        /// </summary>
        /// <param name="numberInput"></param>
        /// <returns>true if personal number, false if not</returns>
        private bool IsPersonalNumber(string numberInput)
        {
            string[] formats = { "yyMMdd", "yyyyMMdd" };
            string birthDate = numberInput[0..^4].TrimEnd('-').TrimEnd('+');
            if (DateTime.TryParseExact(birthDate, formats, new CultureInfo("se-SE"), DateTimeStyles.None, out _))
            {
                Number number = new PersonalNumber(numberInput, Number.NumberType.PersonalNumber);
                numberList.Add(number);
                return true;
            }
            return false;
        }

        
        /// <summary>
        /// Check if input is NotEmpty, NotNull and has not only whitespaces.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>true if input is null,empty or whitespace, false if not</returns>
        private static bool IsNullOrEmpty(string input)
        {
            bool res = string.IsNullOrWhiteSpace(input);
            return res;
        }

        /// <summary>
        /// Modifies raw string and checks for valid Luhns Algorithm
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static bool CompletesLuhn(string number)
        {
            StringModificationer stringModificationer = new StringModificationer();
            List<int> numberList = stringModificationer.TrimAndConvert(number);
            return LuhnsAlgo.ChecksLuhnsAlgorithm(numberList);
        }

        
    }
}
