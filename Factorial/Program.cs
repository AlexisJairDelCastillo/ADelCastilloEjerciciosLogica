namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int factorial;

            Console.WriteLine("Introduce un numero entero: ");
            num = Convert.ToInt32(Console.ReadLine());

            factorial = FactorialNum(num);

            Console.WriteLine($"El factorial de {num} es: {factorial}");
            Console.ReadKey();
        }

        public static int FactorialNum(int num)
        {
            int factorial = 1;

            for(int i = 2; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}