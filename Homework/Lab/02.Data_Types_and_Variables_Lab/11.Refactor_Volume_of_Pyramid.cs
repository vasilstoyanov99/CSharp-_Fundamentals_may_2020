using System;

namespace _11.Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Length: ");
            double pyramidLenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double pyramidWidth = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double pyramidHeigth = double.Parse(Console.ReadLine());
            double pyramidVolume = (pyramidHeigth * pyramidLenght * pyramidWidth) / 3;
            Console.WriteLine($"Pyramid Volume: {pyramidVolume:f2}");

        }
    }
}
