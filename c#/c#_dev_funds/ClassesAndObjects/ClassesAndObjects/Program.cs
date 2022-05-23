using System;
using ClassesAndObjects.Accounting;
using ClassesAndObjects.HR; // Need to include this since Employee class is under a different namespace

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating an employee");
            Console.WriteLine("--------------------");

            Developer jeffery = new Developer("Jeffery", "Park", "parkjon8@gmail.com", new DateTime(1992, 6, 22), 25);
            StoreManager john = new StoreManager("John", "Nam", "namjohn920@gmail.com", new DateTime(1990, 9, 11), 30);
            //Employee e = new Employee(); // error => no constructor that takes 0 argument

            // Both testEmployee and john are pointing to the same object in memory
            //  Two references pointing to the same object
            //Employee testEmployee = john;
            //testEmployee.firstName = "Sigi"; // Cannot assign value since firstName is changed to private
            //testEmployee.FirstName = "Sigi";

            //Employee mysteryPerson = null;
            //mysteryPerson.DisplayEmployeeDetails(); // error

            Manager sigi = new Manager("Sigi", "Lee", "sig@sigsig.sig", new DateTime(1992, 7, 28), 30);

            JuniorResearcher bobJunior = new JuniorResearcher("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);

            Employee.DisplayTaxRate();

            jeffery.hourlyRate = 32;

            jeffery.PerformWork();
            jeffery.PerformWork();
            jeffery.PerformWork();
            jeffery.PerformWork();
            jeffery.ReceiveWage();
            jeffery.DisplayEmployeeDetails();

            Console.WriteLine();
            Console.WriteLine("Creating an employee");
            Console.WriteLine("--------------------");

            john.PerformWork();
            john.PerformWork();
            john.PerformWork();
            john.PerformWork();
            john.ReceiveWage();
            john.DisplayEmployeeDetails();

            Console.WriteLine();

            //jeffery.taxRate = 0.02; // does not work
            Employee.taxRate = 0.02; // changes taxRate for all objects
            Employee.DisplayTaxRate();

            Customer customer = new Customer();

            Console.WriteLine();
            Console.WriteLine("Creating an employee");
            Console.WriteLine("--------------------");

            sigi.PerformWork();
            sigi.PerformWork();
            sigi.PerformWork();
            sigi.PerformWork();
            sigi.ReceiveWage();
            sigi.DisplayEmployeeDetails();
            sigi.AttendManagementMeeting();

            Console.WriteLine();

            bobJunior.ResearchNewPieTastes(10);
            bobJunior.ReceiveWage();

            Console.WriteLine();

            jeffery.GiveBonus();
            sigi.GiveBonus();
        }
    }
}
