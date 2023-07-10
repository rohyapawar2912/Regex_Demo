using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Demo
{
    // a Regex ( regular Expression) is a pattern that is used to check whether a give string matches that
    public class RegexNew
    {
        static string pattern = "^cen$";
        public void MyRegex()
        {
            // we have created object of class
            // we have a parameter pattern in given class constructor
            Regex regex = new Regex(pattern);
            // is match return true if its mateches the string otherwise it return flase
            if (regex.IsMatch("Rohya"))
            {
                Console.WriteLine("string is match the pattern");
            }
            else
            {
                Console.WriteLine("string does not match the pattern");
            }

        }
        public void CheckName(string name)
        {
            //
            string myName = "^[A-Z][a-z]{3,}?$";
            if (Regex.IsMatch(name, myName))
            {
                Console.WriteLine(" string is match the pattern");
            }
            else 
            {
                Console.WriteLine(" string  does not match the pattern");
            }
        }
        public void LastName(string lastName)
        {
            string myLastName = "^[A-z][a-z]{3,}?$";
            if (Regex.IsMatch(lastName, myLastName))
            {
                Console.WriteLine(" string is match the pattern");
            }
            else
            {
                Console.WriteLine(" string does not match the pattern ");
            }
        }
        
    }
}
