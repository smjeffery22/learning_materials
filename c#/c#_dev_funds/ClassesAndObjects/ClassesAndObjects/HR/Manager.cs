using System;
namespace ClassesAndObjects.HR
{
    public class Manager: Employee
    {
        public Manager(string first, string last, string em, DateTime bd, double? rate):base(first, last, em, bd, rate)
        {

        }

        public void AttendManagementMeeting()
        {
            numberOfHoursWorked++;

            Console.WriteLine($"Manager { FirstName } { LastName } is now attending a long meeting that could have been an email");
        }

        public override void GiveBonus()
        {
            if (numberOfHoursWorked > 5)
            {
                Console.WriteLine($"{FirstName} {LastName} received a generic bonus of 500!");
            }
            else
            {
                Console.WriteLine($"{FirstName} {LastName} received a generic bonus of 250!");
            }
        }

        public override double ReceiveWage()
        {
            double wageBeforeTax = numberOfHoursWorked * hourlyRate.Value;
            double taxAmount = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"The wage for {numberOfHoursWorked} hours of work is {Wage}.");
            numberOfHoursWorked = 0;

            return Wage;
        }
    }
}
