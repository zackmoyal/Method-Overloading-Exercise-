namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isDollarorDollars)
        {
            var sum = num1 + num2;

            if (isDollarorDollars == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isDollarorDollars == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isDollarorDollars == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }

        static void Main(string[] args)
        {
            var sumInt = Add(3, 4);
            var sumDecimal = Add(5.322m, 2.843m);
            var countingMoney = Add(1, 0, true);

            Console.WriteLine($"The sum of the integers is {sumInt}.");
            Console.WriteLine($"The sum of the decimals is {sumDecimal}.");
            Console.WriteLine(countingMoney);
        }
    }
}
