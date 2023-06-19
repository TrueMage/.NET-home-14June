namespace home_14June
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task#1 Сред.Ариф
            Console.WriteLine("T#1");
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result = " + (a + b + c) / 3);
            #endregion

            #region task#2 Pow
            Console.WriteLine("\nT#2 Pow");
            Console.Write("num = ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("exp = ");
            int exp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{num}^{exp} = " + Math.Pow(num, exp));
            #endregion

            #region task#3 Convert UAHUSDEUR
            Console.WriteLine("\nT#3 UAH TO USD/EUR");
            Console.Write("UAH = ");
            int money = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"USD {Math.Round(money / 36.96, 2)} EUR {Math.Round(money / 40.36, 2)}");
            #endregion

            #region task#4 Miles
            Console.WriteLine("\nT#4 MILES");
            Console.Write("km = ");
            double km = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Miles = {Math.Round(km * 0.621, 2)} Nautical miles = {Math.Round(km * 0.5399, 2)}");
            #endregion

            #region task#5 Procent
            Console.WriteLine("\nT#5 Procent");
            Console.Write("P = ");
            int P = Convert.ToInt32(Console.ReadLine());

            Console.Write("N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n{P}% - {N} = {Math.Round(N * (P * 0.01), 2)}");
            #endregion

            #region task#6 Convert FCF
            Console.WriteLine("\nT#3 Temperature");
            Console.Write("C° = ");
            int c2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("F° = " + ((c2 * 9 / 5) + 32));

            Console.Write("\nF° = ");
            int f = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("C° = " + ((f - 32) * 5 / 9));
            #endregion
        }
    }
}