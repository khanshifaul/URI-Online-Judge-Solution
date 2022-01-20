/* In this problem, the task is to read a code of a product 1, the number of units of product 1, the price for one unit of product 1, the code of a product 2, the number of units of product 2 and the price for one unit of product 2. After this, calculate and show the amount to be paid. */

namespace URI1010
{
    public class Product
    {
        public int productCode, quantity;
        public double Price, totalPrice;
        public string[]? product;

        public void Total()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            product = Console.ReadLine().Split();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            productCode = int.Parse(product[0]);
            quantity = int.Parse(product[1]);
            Price = double.Parse(product[2]);
            totalPrice = quantity * Price;
        }
    }

    internal static class URI
    {
        private static void Main(string[] args)
        {
            double valueToPay;
            Product Product1 = new();
            Product1.Total();

            Product Product2 = new();
            Product2.Total();

            valueToPay = Product1.totalPrice + Product2.totalPrice;

            Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", valueToPay);
        }
    }
}