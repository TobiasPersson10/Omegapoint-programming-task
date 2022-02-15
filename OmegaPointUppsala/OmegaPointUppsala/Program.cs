using System;
using System.IO;

namespace OmegaPointUppsala
{
    // Purpose: Programming task for 'Omegapoint Academy Professional Program' for Omegapoint Uppsala
    // Task:    Validate personalnumbers
    // Author:  Tobias Persson
    // Date:    2022-02-15


    /*                                 INSTRUCTIONS & EXPLANATION OF CODE                               */
    /*                                                                                                  */
    /*   In DataAccess.ReadFromFile(), there lies a reference to a textfile containing sample numbers.  */
    /*   Logic starts from "Logic\\ValidityCheck\\IsValidNumber"                                        */
    /*   When run, the program prints out each sample and whether it is a valid number.                 */
    /*   If it is valid, it also prints out which kind of number it is.                                 */

    public class Program
    {
        /// <summary>
        /// Gets input from textfile, by reading one line by one. Stops at EOF.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            DataAccess.ReadFromFile();
        }
    }
}
