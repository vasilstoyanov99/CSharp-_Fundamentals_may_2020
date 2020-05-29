using System;
using System.IO;

namespace _08.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            string modelOfTheBiggestKeg = "";
            double maxVolume = double.MinValue;

            for (int currKeg = 1; currKeg <= numberOfKegs; currKeg++)
            {
                string currKegModel = Console.ReadLine();
                double currKegRadius = double.Parse(Console.ReadLine());
                int currKegHeight = int.Parse(Console.ReadLine());
                double currKegVolume = Math.PI * Math.Pow(currKegRadius, 2) * currKegHeight;

                if (maxVolume < currKegVolume)
                {
                    modelOfTheBiggestKeg = currKegModel;
                    maxVolume = currKegVolume;
                }
            }

            Console.WriteLine(modelOfTheBiggestKeg);
        }
    }
}
