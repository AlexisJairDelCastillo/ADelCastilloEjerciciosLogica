namespace OrdenarArreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 10, 2, 8, 15, 6, 4 };

            foreach(var arregloEntrada in arreglo)
            {
                Console.WriteLine($"ArregloEntrada = " + arregloEntrada);
            }

            Console.WriteLine();

            OrdenarDescendentemente(arreglo);

            Console.WriteLine();

            foreach (var arregloSalida in arreglo)
            {
                Console.WriteLine("ArregloSalida = " + arregloSalida);
            }

            Console.ReadKey();
        }

        public static void OrdenarDescendentemente(int[] arreglo)
        {
            int n = arreglo.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (arreglo[j] < arreglo[j + 1])
                    {
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] =  temp;
                    }
                }
            }
        }
    }
}