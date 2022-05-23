using System;
namespace ClassesAndObjects.HR
{
    public class Researcher: Employee
    {
        public Researcher(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        {

        }

        public void ResearchNewPieTastes(int researchHours)
        {
            numberOfHoursWorked += researchHours;

            Console.WriteLine($"Researcher { FirstName } { LastName } has invented a new pie taste!");
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

    public class JuniorResearcher : Researcher
    {
        public JuniorResearcher(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        {

        }
    }
}
