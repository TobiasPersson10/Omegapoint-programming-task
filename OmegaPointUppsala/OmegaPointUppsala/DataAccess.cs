using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OmegaPointUppsala
{
    /// <summary>
    /// Class to fetch data
    /// </summary>
    public class DataAccess
    {
        /// <summary>
        /// Reads lines from textfile, one by one to the EOF. Calls for validity check for each line.
        /// </summary>
        public static void ReadFromFile()
        {
            ValidityCheck valCheck = new ValidityCheck();
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"AllNumbers.txt");
            StreamReader sr = new(path);

            string input;
            while ((input = sr.ReadLine()) != null)
            {
                valCheck.IsValidNumber(input);
            }
        }
        
    }
}
