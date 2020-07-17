using System;
using System.Text;

namespace _05.Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().TrimStart('0');
            int multiplyBy = int.Parse(Console.ReadLine());

            if (multiplyBy.ToString() == "0" || number == "")
            {
                Console.WriteLine(0);
                return;
            }

            int remainder = 0;
            StringBuilder result = new StringBuilder();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int resultToAdd = (int.Parse(number[i].ToString()) * multiplyBy + remainder);
                remainder = 0;

                if (resultToAdd > 9)
                {
                    remainder = resultToAdd / 10;
                    resultToAdd %= 10;
                }

                result.Append(resultToAdd);
            }

            if (remainder != 0)
            {
                result.Append(remainder);
            }

            StringBuilder toPrint = new StringBuilder();

            for (int i = result.Length - 1; i >= 0; i--)
            {
                toPrint.Append(result[i]);
            }

            Console.WriteLine(toPrint.ToString());
        }
    }
}
