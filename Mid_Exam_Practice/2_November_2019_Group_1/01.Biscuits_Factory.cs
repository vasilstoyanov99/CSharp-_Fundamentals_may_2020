using System;
using System.Threading;

namespace _01.Biscuits_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsProducedPerWorkerPerDay = int.Parse(Console.ReadLine());
            int countOfTheWorkers = int.Parse(Console.ReadLine());
            int competingFactoryProductionForOneMonth = int.Parse(Console.ReadLine());
            double myCompanyProductionForOneMonth = 0;

            for (int currDay = 1; currDay <= 30; currDay++)
            {
                if (currDay % 3 == 0) 
                {
                    double productionForTheDay = (countOfTheWorkers * biscuitsProducedPerWorkerPerDay) * 0.75;
                    myCompanyProductionForOneMonth += Math.Floor(productionForTheDay);
                }
                else
                {
                    int productionForTheDay = (countOfTheWorkers * biscuitsProducedPerWorkerPerDay);
                    myCompanyProductionForOneMonth += productionForTheDay;
                }
            }

            Console.WriteLine($"You have produced {myCompanyProductionForOneMonth} biscuits for the past month.");

            if (myCompanyProductionForOneMonth > competingFactoryProductionForOneMonth)
            {
                double percentageMore = myCompanyProductionForOneMonth / competingFactoryProductionForOneMonth;
                percentageMore -= 1;
                percentageMore *= 100;

                Console.WriteLine($"You produce {percentageMore:f2} percent more biscuits.");
            }
            else
            {
                double difference = competingFactoryProductionForOneMonth - myCompanyProductionForOneMonth;
                double percentageLess = (difference / competingFactoryProductionForOneMonth) * 100;

                Console.WriteLine($"You produce {percentageLess:f2} percent less biscuits.");
            }
        }
    }
}
