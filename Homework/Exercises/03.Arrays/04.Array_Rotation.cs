using System;
using System.Linq;

namespace _04.Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            short[] inputArray = Console.ReadLine().Split().Select(short.Parse).ToArray();
            byte numberOfRotations = byte.Parse(Console.ReadLine());
            short[] copyOfInputArray = new short[inputArray.Length];
            Array.Copy(inputArray, copyOfInputArray, inputArray.Length);

            for (int currRotation = 0; currRotation < numberOfRotations; currRotation++)
            {
                byte inputArrayIndex = 0;
                byte inputArrayIndex2 = 1;

                for (int currIndexRotation = 0; currIndexRotation < inputArray.Length; currIndexRotation++)
                {
                    if (inputArrayIndex2 == inputArray.Length)
                    {
                        inputArrayIndex2 = 0;
                    }

                    inputArray[inputArrayIndex] = copyOfInputArray[inputArrayIndex2];
                    inputArrayIndex++;
                    inputArrayIndex2++;
                }

                Array.Copy(inputArray, copyOfInputArray, inputArray.Length);
            }

            Console.WriteLine(String.Join(" ", inputArray));
        }
    }
}
