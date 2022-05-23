using System;
namespace ClassesAndObjects.HR
{
    public class StoreManager: Employee
    {
        public StoreManager(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        {

        }

        public void AttendManagementMeeting()
        {
            numberOfHoursWorked++;

            Console.WriteLine($"Manager { FirstName } { LastName } is now attending a long meeting that could have been an email");
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
