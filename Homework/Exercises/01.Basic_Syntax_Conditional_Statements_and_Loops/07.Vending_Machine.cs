using System;

namespace _07.Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalMoney = 0.00;
            bool isEnd = false;

            while (input != "Start")
            {
                double insertedCoin = double.Parse(input);
                switch (insertedCoin)
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1:
                    case 2:
                        totalMoney += insertedCoin;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {insertedCoin}");
                        break;
                }
                input = Console.ReadLine();
            }

            if (input == "Start")
            {
                string wantedProduct = Console.ReadLine();

                while (wantedProduct != "End")
                {
                    switch (wantedProduct)
                    {
                        case "Nuts":
                            if (totalMoney >= 2.0)
                            {
                                totalMoney -= 2.0;
                                Console.WriteLine($"Purchased nuts");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Water":
                            if (totalMoney >= 0.7)
                            {
                                totalMoney -= 0.7;
                                Console.WriteLine($"Purchased water");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Crisps":
                            if (totalMoney >= 1.5)
                            {
                                totalMoney -= 1.5;
                                Console.WriteLine($"Purchased crisps");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Soda":
                            if (totalMoney >= 0.8)
                            {
                                totalMoney -= 0.8;
                                Console.WriteLine($"Purchased soda");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Coke":
                            if (totalMoney >= 1.0)
                            {
                                totalMoney -= 1.0;
                                Console.WriteLine($"Purchased coke");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid product");
                            break;
                    }

                    wantedProduct = Console.ReadLine();
                }
            }

            Console.WriteLine($"Change: {totalMoney:f2}");
        }
    }
}
