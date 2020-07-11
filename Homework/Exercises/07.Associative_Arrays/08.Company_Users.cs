using System;
using System.Collections.Generic;

namespace _08.Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> companiesEmployeeId = new SortedDictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string companyName = input.Split(" -> ")[0];
                string employeeId = input.Split(" -> ")[1];

                if (!companiesEmployeeId.ContainsKey(companyName))
                {
                    companiesEmployeeId.Add(companyName, new List<string>());
                    companiesEmployeeId[companyName].Add(employeeId);
                }
                else
                {
                    if (!companiesEmployeeId[companyName].Contains(employeeId))
                    {
                        companiesEmployeeId[companyName].Add(employeeId);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var pair in companiesEmployeeId)
            {
                Console.WriteLine(pair.Key);

                foreach (var employeeId in pair.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }
}
