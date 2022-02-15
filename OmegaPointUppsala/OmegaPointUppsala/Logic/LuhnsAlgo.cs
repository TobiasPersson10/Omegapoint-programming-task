using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaPointUppsala
{
    /// <summary>
    /// Class to perform a validity check on LuhnsAlgorithm
    /// </summary>
    public class LuhnsAlgo
    {
        /// <summary>
        /// Check if number completes Luhns Algorithm. Checks if suggested control digit is correct by calculating it from scratch.
        /// </summary>
        /// <param name="numberList"></param>
        /// <returns>True if it completes Luhn's Algorithm, false if not</returns>
        public static bool ChecksLuhnsAlgorithm(List<int> numberList)
        {
            bool isValid = false;
            int shortSum = SumOfAllDigitsExceptControlDigit(numberList);
            int longSum = SumOfAllDigits(numberList);
            int controlDigit = (10 - (shortSum % 10)) % 10;

            if ((longSum % 10 == 0) && (longSum - shortSum == controlDigit))
            {
                isValid = true;
            }
            return isValid;
        }

        /// <summary>
        /// Helper-method to calculate the correct control digit
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>sum of numbers except control digit</returns>
        private static int SumOfAllDigitsExceptControlDigit(List<int> numbers)
        {
            var shorterList = new List<int>();
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                shorterList.Add(numbers[i]);
            }
            int DoubSum = 0;
            int OrgSum = 0;
            for (int i = shorterList.Count - 2; i >= 0; i -= 2)
            {
                OrgSum += shorterList[i];
            }
            for (int i = shorterList.Count - 1; i >= 0; i -= 2)
            {
                int dig = shorterList[i] * 2;
                DoubSum += dig % 10;
                DoubSum += dig / 10;
            }
            return OrgSum + DoubSum;
        }

        /// <summary>
        /// Second helper-method to calculate the correct control digit
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>sum of all numbers</returns>
        private static int SumOfAllDigits(List<int> numbers)
        {
            int DoubSum = 0;
            int OrgSum = 0;
            for (int i = numbers.Count - 1; i >= 0; i -= 2)
            {
                OrgSum += numbers[i];
            }
            for (int i = numbers.Count - 2; i >= 0; i -= 2)
            {
                int dig = numbers[i] * 2;
                DoubSum += dig % 10;
                DoubSum += dig / 10;
            }
            return OrgSum + DoubSum;
        }
    }
}
