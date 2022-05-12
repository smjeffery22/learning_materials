using System.Timers;

namespace TimerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Timers.Timer myTimer = new System.Timers.Timer(2000);

            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;

            myTimer.Start();

            Console.WriteLine("Press enter to remove the red event.");
            Console.ReadLine();

            // unregister MyTimer_Elapsed1 event handler
            myTimer.Elapsed -= MyTimer_Elapsed1;

            Console.ReadLine();
        }

        private static void MyTimer_Elapsed1(object? sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Elapsed1: {e.SignalTime:HH:mm:ss.fff}");
        }

        private static void MyTimer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Elapsed: {e.SignalTime:HH:mm:ss.fff}");
        }
    }
}