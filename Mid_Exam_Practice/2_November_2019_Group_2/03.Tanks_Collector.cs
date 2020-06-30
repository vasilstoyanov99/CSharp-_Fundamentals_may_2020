using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Tanks_Collector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tanksCollection = Console.ReadLine().Split(", ").ToList();
            byte commandsCount = byte.Parse(Console.ReadLine());

            for (int currCommand = 1; currCommand <= commandsCount; currCommand++)
            {
                string[] data = Console.ReadLine().Split(", ").ToArray();
                {
                    case "Add":
                        AddTank(tanksCollection, data);
                        break;
                    case "Remove":
                        RemoveTank(tanksCollection, data);
                        break;
                    case "Remove At":
                        RemoveTankAtIndex(tanksCollection, data);
                        break;
                    case "Insert":
                        InsertTankAtIndex(tanksCollection, data);
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", tanksCollection));

        }

        static void AddTank(List<string> tanksCollection, string[] data)
        {
            string tankName = data[1];

            if (tanksCollection.Contains(tankName))
            {
                Console.WriteLine("Tank is already bought");
                return;
            }
            else
            {
                tanksCollection.Add(tankName);
                Console.WriteLine("Tank successfully bought");
            }
        }

        static void RemoveTank(List<string> tanksCollection, string[] data)
        {
            string tankName = data[1];

            if (tanksCollection.Contains(tankName))
            {
                tanksCollection.Remove(tankName);
                Console.WriteLine("Tank successfully sold");
                return;
            }
            else
            {
                Console.WriteLine("Tank not found");
            }
        }

        static void RemoveTankAtIndex(List<string> tanksCollection, string[] data)
        {
            int tankIndex = int.Parse(data[1]);

            if (tankIndex >= 0 && tankIndex <= tanksCollection.Count - 1)
            {
                tanksCollection.RemoveAt(tankIndex);
                Console.WriteLine("Tank successfully sold");
                return;
            }
            else
            {
                Console.WriteLine("Index out of range");
            }
        }

        static void InsertTankAtIndex(List<string> tanksCollection, string[] data)
        {
            int tankIndex = int.Parse(data[1]);
            string tankName = data[2];

            bool isTankIndexInRange = tankIndex >= 0 && tankIndex <= tanksCollection.Count - 1;
            bool isTankNameInTheList = tanksCollection.Contains(tankName);

            if (!isTankIndexInRange)
            {
                Console.WriteLine("Index out of range");
                return;
            }

            if (isTankIndexInRange && !isTankNameInTheList)
            {
                tanksCollection.Insert(tankIndex, tankName);
                Console.WriteLine("Tank successfully bought");
                return;
            }

            if (isTankIndexInRange && isTankNameInTheList)
            {
                Console.WriteLine("Tank is already bought");
            }
        }
    }
}
