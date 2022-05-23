using System;

namespace ClassesAndObjects.HR
{
    public abstract class Employee : IEmployee, IComparable
    {
        private int id;
        private string firstName;
        private string lastName;
        public string email;

        public int numberOfHoursWorked;
        private double wage;
        public double? hourlyRate;

        public DateTime birthDay;

        public static double taxRate = 0.15;
        private const double maxAmountHoursWorked = 1000;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public double Wage
        {
            get { return wage; }
            set
            {
                if (value < 0)
                {
                    wage = 0;
                }
                else
                {
                    wage = value;
                }
            }
        }

        public Employee(string first, string last, string em, DateTime bd, double? rate)
        {
            FirstName = first;
            LastName = last;
            email = em;
            birthDay = bd;
            hourlyRate = rate ?? 10;
        }

        // Overloaded constructor - constructors with the same name but with different parameters
        // The other constructor is invoked using 'this' keyword
        // Rate of 0 passed in
        //public Employee(string first, string last, string em, DateTime bd, EmployeeType emType) : this(first, last, em, bd, emType, 0)
        //{

        //}

        public void PerformWork()
        {
            numberOfHoursWorked++;

            Console.WriteLine($"{FirstName} {LastName} is now working!");
        }

        public void StopWorking()
        {
            Console.WriteLine($"{FirstName} {LastName} has stopped working!");
        }

        //public double ReceiveWage()
        //{
        //    //wage = numberOfHoursWorked * hourlyRate;
        //    double wageBeforeTax = numberOfHoursWorked * hourlyRate.Value;
        //    double taxAmount = wageBeforeTax * taxRate;

        //    wage = wageBeforeTax - taxAmount;

        //    Console.WriteLine($"The wage for {numberOfHoursWorked} hours of work is {wage}.");
        //    numberOfHoursWorked = 0;

        //    return wage;
        //}

        public abstract double ReceiveWage();

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: {FirstName}\nLast name: {LastName}\nEmail: {email}\nBirthday: {birthDay.ToShortDateString()}\nTax rate: {taxRate}");
        }

        public static void DisplayTaxRate()
        {
            Console.WriteLine($"The current tax rate is {taxRate}.");
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName} {LastName} received a generic bonus of 100!");
        }

        public int CompareTo(object obj)
        {
            var otherEmployee = (Employee)obj;

            if (Id > otherEmployee.Id)
            {
                return 1;
            }
            else if (Id < otherEmployee.Id)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
