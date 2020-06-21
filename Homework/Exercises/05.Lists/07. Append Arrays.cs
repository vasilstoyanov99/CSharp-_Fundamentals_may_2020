//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace _07.Append_Arrays
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();
//            StringBuilder list = new StringBuilder();
//            List<int> result = new List<int>();
//            int spaceCounter = 0; // to reset!
//            byte isValueFound = 0;
//            List<char> temp = new List<char>();
//            for (int i = input.Length - 1; i >= 0; i--)
//            {

//                if (input[i] == ' ')
//                {
//                    spaceCounter++;
//                }
//                if (input[i] != ' ')
//                {
//                    if (input[i] == '|')
//                    {
//                        if (spaceCounter >= 2 && isValueFound == 0)
//                        {
//                            temp.Reverse();
//                            for (int k = 0; k < temp.Count - 1; k++)
//                            {
//                                result.Add(int.Parse(temp[k].ToString()));
//                            }
//                            temp.Clear();
//                            isValueFound = 1;
//                            continue;
//                        }
//                    }
//                    if (input[i] != '|')
//                    {
//                        temp.Add(input[i]);
//                    }
//                    if (input[i] == '|' && isValueFound == 1 || i == 0 || temp.Contains(input[input.Length - 1]) && temp.Count > 1)
//                    {
//                        temp.Reverse();
//                        for (int k = 0; k < temp.Count; k++)
//                        {
//                            result.Add(int.Parse(temp[k].ToString()));
//                        }
//                        temp.Clear();
//                        spaceCounter = 0;
//                    }
//                }
//            }

//            Console.WriteLine(String.Join(" ", result));
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;

namespace appendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var apendArrays = new List<int>();
            var input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                var splittedInput = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < splittedInput.Length; j++)
                {
                    apendArrays.Add(int.Parse(splittedInput[j]));
                }
            }
            Console.WriteLine(string.Join(" ", apendArrays));
        }
    }
}
