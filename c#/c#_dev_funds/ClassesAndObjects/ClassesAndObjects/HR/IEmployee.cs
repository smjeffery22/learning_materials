using System;
namespace ClassesAndObjects.HR
{
    public interface IEmployee
    {
        double ReceiveWage();

        void GiveBonus();

        void PerformWork();

        void StopWorking();

        void DisplayEmployeeDetails();
    }
}
