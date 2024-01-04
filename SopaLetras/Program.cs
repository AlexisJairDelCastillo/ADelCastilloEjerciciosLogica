namespace SopaLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            string palabraOrdenada;

            Console.WriteLine("Introduce una palabra: ");
            str = Console.ReadLine();

            palabraOrdenada = SopaLetra(str);

            Console.WriteLine($"La palabra ordenada alfabeticamente es: {palabraOrdenada}");
            Console.ReadKey();
        }

        public static string SopaLetra(string str)
        {
            char[] ordenAlfabetico = str.ToCharArray();

            Array.Sort(ordenAlfabetico);

            return new string(ordenAlfabetico);
        }
    }
}