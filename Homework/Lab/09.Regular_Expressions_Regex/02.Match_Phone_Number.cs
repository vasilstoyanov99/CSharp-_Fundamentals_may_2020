using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"( |)\+[3][5][9]( |-)[2]\2\d{3}\2\d{4}\b");
            MatchCollection validNumbers = regex.Matches(input);

            var matchedPhoneNumbers = validNumbers.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(String.Join(", ", matchedPhoneNumbers));
        }
    }
}
