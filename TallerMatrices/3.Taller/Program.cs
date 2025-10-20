namespace _3.Taller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de 
            5x5 llena de números aleatorios. 
            El algoritmo debe permitir: 
             Usa la función Random para generar los números aleatorios. 
             Crea un arreglo adicional para almacenar la frecuencia de cada número. 
             Mostrar la matriz y el nuevo arreglo con la frecuencia de cada número 
             */

            int[,] matriz = new int[5, 5];
            int[] frecuencia = new int[11];
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = random.Next(1, 11);
                }
            }

            Console.WriteLine("Matriz generada:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                    frecuencia[matriz[i, j]]++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("Frecuencia de cada número:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Número {i}: {frecuencia[i]} veces");
            }
        }
    }
}
