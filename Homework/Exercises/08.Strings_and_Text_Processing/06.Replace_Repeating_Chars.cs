using System;
using System.Text;

namespace _06.Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                int startIndex = i;
                int endIndex = 0;
                int counter = 0;
                bool check = false;

                for (int j = startIndex; j < input.Length; j++)
                {
                    if (j == input.Length - 1 && check == false)
                    {
                        endIndex = startIndex;
                        break;
                    }
                    if (j == input.Length - 1)
                    {
                        break;
                    }
                    if (input[j] == input[j + 1])
                    {
                        endIndex = j + 1;
                        counter++;
                        check = true;
                    }
                    else
                    {
                        if (counter == 0)
                        {
                            endIndex = startIndex;
                        }

                        break;
                    }
                }

                if (startIndex == endIndex)
                {
                    output.Append(input[i]);
                    continue;
                }
                else
                {
                    output.Append(input[i]);
                    i = endIndex;
                }
            }

            Console.WriteLine(output.ToString());
        }
    }
}
