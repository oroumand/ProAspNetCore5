using System;
using System.Text.RegularExpressions;

namespace Session10.UnitTesting.Domain
{
    public class StringHelper
    {
        public DateTime LastExecutionDate { get; set; }
        public bool IsNumber(string input)
        {
            var regeX = new Regex(@"\d+");
            LastExecutionDate = DateTime.Now;
            if (regeX.IsMatch(input))
            {
                return true;
            }
            return false;
        }

        public int ToInt(string input)
        {
            // ""
            // "123123"
            // "asfsad"
            // "123456789012345678903456789"
            int output;
            if(!int.TryParse(input,out output))
            {
                throw new Exception("Bad input number");
            }
            return output;
        }

    }
}
