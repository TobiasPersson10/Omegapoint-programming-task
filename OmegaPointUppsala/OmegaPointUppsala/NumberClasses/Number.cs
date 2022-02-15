using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaPointUppsala
{
    /// <summary>
    /// Base-class for numbers
    /// </summary>
    public class Number
    {
        public string Nr { get; set; }
        public NumberType Type { get; set; }

        public Number(string nr, NumberType type)
        {
            Nr = nr;
            Type = type;
        }

        public enum NumberType
        {
            PersonalNumber
        }
     }
}
