using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaPointUppsala
{
    /// <summary>
    /// Prints output to console
    /// </summary>
    public class PrintToConsole
    {
        /// <summary>
        /// Takes input and kind of number and prints it
        /// </summary>
        /// <param name="input"></param>
        /// <param name="numberList"></param>
        public static void PrintValid(string input, List<Number> numberList)
        {
            string num = numberList.Where(x => x.Nr == input).Select(x => x.Type).FirstOrDefault().ToString().ToLower();
            Console.WriteLine($"{input}\t is a valid {num}\n");
        }

        /// <summary>
        /// Takes input for INVALID number and prints it
        /// </summary>
        /// <param name="input"></param>
        public static void PrintInvalid(string input)
        {
            Console.WriteLine($"{input}\t is not a valid number\n");
        }

        /// <summary>
        /// Print if input is empty, null or got only whitespaces
        /// </summary>
        /// <param name="input"></param>
        public static void PrintEmpty()
        {
            Console.WriteLine($"The input was null or empty or contained just whitespaces");
        }
    }
}
