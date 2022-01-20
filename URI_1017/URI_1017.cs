using System;

namespace URI1017
{
    internal static class URI
    {
        private static void Main(string[] args)
        {
            int spentHour, avgSpeed;
            spentHour = Convert.ToInt32(Console.ReadLine());
            avgSpeed = Convert.ToInt32(Console.ReadLine());
            double fuelSpent = spentHour * avgSpeed / 12.00;
            Console.WriteLine("{0:F3}", fuelSpent);
        }
    }
}