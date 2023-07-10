using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose the below option");
                Console.WriteLine("1 - MyRegex");
                Console.WriteLine("2 - Name");
                Console.WriteLine("3 - LastName");
                int choise = Convert.ToInt32(Console.ReadLine());
                RegexNew regexNew = new RegexNew();
                switch (choise)
                {
                    case 1:
                        regexNew.MyRegex();
                        break;
                    case 2:
                        regexNew.CheckName("Rohya");
                        break;
                    case 3:
                        regexNew.LastName("Pawar");
                        break;

                   
                }
                
            }
            
        }
    }
}
