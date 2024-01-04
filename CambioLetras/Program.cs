namespace CambioLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            string nuevaPalabra;

            Console.WriteLine("Introduce una palabra: ");
            str = Console.ReadLine();

            nuevaPalabra = CambiosLetras(str);

            Console.WriteLine($"La nueva palabra es: {nuevaPalabra}");
            Console.ReadKey();
        }

        public static string CambiosLetras(string str)
        {
            char[] caracter = str.ToCharArray();

            for (int i = 0; i < caracter.Length; i++)
            {
                int letra = (int)caracter[i];

                if (char.IsLetter(caracter[i]))
                {
                    char nuevaLetra = (char)(char.IsUpper(caracter[i]) ? ((letra - 'A' + 1) % 26) + 'A' : ((letra - 'a' + 1) % 26) + 'a');
                    caracter[i] = nuevaLetra;
                }
            }

            return new string(caracter);
        }
    }
}