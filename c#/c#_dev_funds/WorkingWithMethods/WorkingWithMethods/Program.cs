using System;

namespace WorkingWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //UsingValueParameters();
            //UsingRefParameters();
            //UsingOutParameters();
            //UsingParams();
            //UsingOptionalParameters();
            UsingNamedArguments();
            UsingExpressionBodiedSynyax();
        }

        public static void UsingValueParameters()
        {
            int monthlyWage1 = 1800;
            int monthlyWage2 = 3500;
            int months1 = 12;
            int months2 = 8;
            int bonus = 300;

            //int yearlyWage = CalculateYearlyWage(monthlyWage, months);

            int yearlyWageForEmployee1 = CalculateYearlyWage(monthlyWage1, months1, bonus);
            Console.WriteLine($"Yearly wage for Employee 1: {yearlyWageForEmployee1}");

            int yearlyWageForEmployee2 = CalculateYearlyWage(monthlyWage2, months2, bonus);
            Console.WriteLine($"Yearly wage for Employee 2: {yearlyWageForEmployee2}");
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            if (monthlyWage < 2000)
            {
                bonus *= 2;
            }

            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            Console.WriteLine($"The employee got a bonus of {bonus}");

            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        public static void UsingRefParameters()
        {
            int monthlyWage1 = 1800;
            int monthlyWage2 = 3500;
            int months1 = 12;
            int months2 = 8;
            int bonus = 300;

            //int yearlyWage = CalculateYearlyWage(monthlyWage, months);

            int yearlyWageForEmployee1ByRef = CalculateYearlyWageByRef(monthlyWage1, months1, ref bonus);
            Console.WriteLine($"Yearly wage for Employee 1: {yearlyWageForEmployee1ByRef}");

            int yearlyWageForEmployee2ByRef = CalculateYearlyWageByRef(monthlyWage2, months2, ref bonus);
            Console.WriteLine($"Yearly wage for Employee 2: {yearlyWageForEmployee2ByRef}");
        }

        public static int CalculateYearlyWageByRef(int monthlyWage, int numberOfMonthsWorked, ref int bonus)
        {
            if (monthlyWage < 2000)
            {
                bonus *= 2;
            }

            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            Console.WriteLine($"The employee got a bonus of {bonus}");

            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        private static void UsingOutParameters()
        {
            int monthlyWage1 = 1800;
            int months1 = 12;
            int bonus;

            //int yearlyWage = CalculateYearlyWage(monthlyWage, months);

            int yearlyWageForEmployee1 = CalculateYearlyWageWithOut(monthlyWage1, months1, out bonus);
            Console.WriteLine($"Yearly wage for Employee 1: {yearlyWageForEmployee1}");
        }

        public static int CalculateYearlyWageWithOut(int monthlyWage, int numberOfMonthsWorked, out int bonus)
        {
            bonus = new Random().Next(1000); // generate random number smaller than 1000

            if (bonus < 500)
            {
                bonus *= 2;
            }

            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            Console.WriteLine($"The employee got a bonus of {bonus}");

            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        private static void UsingParams()
        {
            int monthlyWage1 = 1000, monthlyWage2 = 1234, monthlyWage3 = 1500, monthlyWage4 = 2500;
            int average = CalculateAverageWage(monthlyWage1, monthlyWage2, monthlyWage3, monthlyWage4);
                        
            Console.WriteLine($"The average wage is: {average}");
        }

        private static int CalculateAverageWage(params int[] wages)
        {
            int total = 0;
            int numberOfWages = wages.Length;

            for (int i = 0; i < numberOfWages; i++)
            {
                total += wages[i];
            }

            return total / numberOfWages;
        }

        private static void UsingOptionalParameters()
        {
            int monthlyWage1 = 1000;
            int months1 = 12;

            int yearlyWageForEmployee1 = CalculateYearlyWageWithOptional(monthlyWage1, months1);
            Console.WriteLine($"Yearly wage for Employee 1: {yearlyWageForEmployee1}");
        }

        public static int CalculateYearlyWageWithOptional(int monthlyWage, int numberOfMonthsWorked, int bonus = 0)
        {
            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");

            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        public static void UsingNamedArguments()
        {
            int monthlyWage = 1800;
            int months = 12;
            int bonus = 300;

            int yearlyWageForEmployee1 = CalculateYearlyWageWithNamed(bonus: bonus, monthlyWage: monthlyWage, numberOfMonthsWorked: months);
            Console.WriteLine($"Yearly wage for Employee 1: {yearlyWageForEmployee1}");
        }

        public static int CalculateYearlyWageWithNamed(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        public static void UsingExpressionBodiedSynyax()
        {
            int monthlyWage = 1800;
            int months = 12;
            int bonus = 300;

            int yearlyWageForEmployee1 = CalculateYearlyWageExpressionBodied(monthlyWage, months, bonus);
            Console.WriteLine($"Yearly wage for Employee 1: {yearlyWageForEmployee1}");
        }

        public static int CalculateYearlyWageExpressionBodied(int monthlyWage, int numberOfMonthsWorked, int bonus) => monthlyWage * numberOfMonthsWorked + bonus;
       
        //public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        //{
        //    //Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
        //    if (numberOfMonthsWorked == 12)
        //    {
        //        return monthlyWage * (numberOfMonthsWorked + 1);
        //    }

        //    return monthlyWage * numberOfMonthsWorked;
        //}

        //public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, double bonus)
        //{
        //    //Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");

        //    return monthlyWage * numberOfMonthsWorked + bonus;
        //}
    }
}
