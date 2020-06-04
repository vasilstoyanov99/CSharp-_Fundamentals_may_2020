using System;
using System.Linq;

namespace _04.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();
            string reversed = "";

            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversed += (array[i] + " ");
            }

            Console.WriteLine(reversed);
        }
    }
}
