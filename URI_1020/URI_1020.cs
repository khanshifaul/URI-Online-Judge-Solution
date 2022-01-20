namespace URI1020
{
    internal static class URI
    {
        private static void Main(string[] args)
        {
            int age = Convert.ToInt32(Console.ReadLine());

            do
            {
                int ano = age / 365;
                Console.WriteLine("{0} ano(s)", ano);
                age -= ano * 365;
            } while (age >= 365);

            do
            {
                int mes = age / 30;
                Console.WriteLine("{0} mes(es)", mes);
                age -= mes * 30;
            } while (age >= 30);

            if (age < 30)
            {
                Console.WriteLine("{0} dia(s)", age);
            }
        }
    }
}