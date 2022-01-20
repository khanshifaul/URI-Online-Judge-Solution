using System;
namespace URI1008
{
    internal static class URI
    {
        private static void Main(string[] args)
        {
            int idNumber, workedHour;
            double salaryPerHour, totalSalary;

            idNumber = Convert.ToInt32(Console.ReadLine());
            workedHour = Convert.ToInt32(Console.ReadLine());
            salaryPerHour = Convert.ToDouble(Console.ReadLine());

            totalSalary = (workedHour * salaryPerHour);

            Console.WriteLine("NUMBER = {0}", idNumber);
            Console.WriteLine("SALARY = U$ {0:F2}", totalSalary);
        }
    }
}