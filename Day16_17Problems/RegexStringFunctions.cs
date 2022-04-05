using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Day16_17Problems
{
    internal class RegexStringFunctions
    {
        public void patternString(string firstName, string fullName, string contactNumber, string date)
        {
            string pattern = "Hello firstName";
            string patternName = Regex.Replace(pattern, @"\bfirstName\b", firstName);
            string FullName = "We have your full name as fullName in our System";
            string patternFullName = Regex.Replace(FullName, @"\bfullName\b", fullName);
            string CnNo = "Your contact Number is 91-xxxxxxxxxx";
            string patternContact = Regex.Replace(CnNo, @"\bxxxxxxxxxx\b", contactNumber);
            string Date = "Please, let us Know in case of clarification. xx-xx-xxxx ";
            string patternDate = Regex.Replace(Date, @"\bxx-xx-xxxx\b", date);
            Console.WriteLine(patternName + " " + patternFullName + " " + patternContact + " " + patternDate);
        }
    }
}
