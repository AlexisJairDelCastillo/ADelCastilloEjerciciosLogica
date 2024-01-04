namespace PalabraLarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str, str2;
            string palabraMasLarga;

            Console.WriteLine("Introduce la primera palabra: ");
            str = Console.ReadLine();
            Console.WriteLine("Introduce la segunda palabra: ");
            str2 = Console.ReadLine();

            palabraMasLarga = PalabraMasLarga(str, str2);

            Console.WriteLine($"La palabra mas larga es: {palabraMasLarga}");
            Console.ReadKey();
        }

        public static string PalabraMasLarga(string str, string str2)
        {
            if (str.Length > str2.Length)
            {
                return str;
            }
            else if(str2.Length > str.Length)
            {
                return str2;
            }
            else
            {
                return str2;
            }
        }
    }
}