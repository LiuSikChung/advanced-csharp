using AsynchronousProgramming.EventArgs;
using System;
using System.Threading;

namespace AsynchronousProgramming
{
    class Program
    {
        public static bool isFinished = false;

        static void Main(string[] args)
        {
            var primeNumberCalculator = new PrimeNumberCalculator();
            primeNumberCalculator.CalculatePrimeCompleted += PrimeNumberCalculator_CalculatePrimeCompleted;
            primeNumberCalculator.ProgressChanged += PrimeNumberCalculator_ProgressChanged;

            primeNumberCalculator.CalculatePrimeAsync(1234567, Guid.NewGuid());

            // thread synchronization
            while (isFinished == false);

            Console.WriteLine("Main finished !!");
        }

        private static void PrimeNumberCalculator_ProgressChanged(System.ComponentModel.ProgressChangedEventArgs e)
        {
            
        }

        private static void PrimeNumberCalculator_CalculatePrimeCompleted(object sender, CalculatePrimeCompletedEventArgs e)
        {
            Console.WriteLine(e.IsPrime);

            isFinished = true;
        }
    }
}
