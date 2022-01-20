using System;

namespace URI1014
{
    internal static class URI
    {
        private static void Main(string[] args)
        {
            int X = Convert.ToInt32(Console.ReadLine());
            double Y = Convert.ToDouble(Console.ReadLine());
            double Consumption = X / Y;
            Console.WriteLine("{0:F3} km/l", Consumption);
        }
    }
}