using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SystemTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //UsingEnumerations();
            UsingAStruct();
        }

        private static void UsingAStruct()
        {
            Employee employee;
            employee.Name = "Jeffery";
            employee.Wage = 1250;
            employee.Work();
        }

        private static void UsingEnumerations()
        {
            EmployeeType employeeType = EmployeeType.Manager;
            StoreType storeType = StoreType.FullPieRestaurant;

            int baseWage = 1000;

            CalculateWage(baseWage, employeeType, storeType);
        }

        // Using custon-created types in parameters
        private static void CalculateWage(int baseWage, EmployeeType employeeType, StoreType storeType)
        {
            int calculatedWage = 0;

            if (employeeType == EmployeeType.Manager)
            {
                calculatedWage = baseWage * 3;
            }   else
            {
                calculatedWage *= 2;
            }

            if (storeType == StoreType.FullPieRestaurant)
            {
                calculatedWage += 500;
            }

            Console.WriteLine($"The calculated wage is {calculatedWage}.");
        }
    }
    
    struct Employee
    {
        public string Name;
        public int Wage;

        public void Work()
        {
            Console.WriteLine($"{Name} is now working!");
        }
    }

    enum EmployeeType
    {
        Sales, // 0
        Manager, // 1
        Research, // 2
        StoreManager // 3
    }

    enum StoreType
    {
        PieCorner = 10,
        Seating = 20,
        FullPieRestaurant = 100,
        Undefined = 99
    }
}