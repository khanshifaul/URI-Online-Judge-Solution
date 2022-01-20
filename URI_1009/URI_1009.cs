using System;
namespace URI1009
{
    internal static class URI
    {
        private static void Main(string[] args)
        {
            string sellerName;
            double salary, bonus, totalSalary;

            sellerName = Console.ReadLine();
            salary = Convert.ToDouble(Console.ReadLine());
            bonus = Convert.ToDouble(Console.ReadLine());
            bonus = bonus * 15 / 100;
            totalSalary = (salary + bonus);

            Console.WriteLine("TOTAL = R$ {0:F2}", totalSalary);
        }
    }
}