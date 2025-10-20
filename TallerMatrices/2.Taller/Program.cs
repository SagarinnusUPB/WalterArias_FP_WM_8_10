namespace _2.Taller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa 
            caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la
            primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la
            matriz con el intercambio de filas.
            */

            Console.WriteLine("Ingrese el número de filas:");
            int filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas:");
            int columnas = int.Parse(Console.ReadLine());

            char[,] matriz = new char[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine($"Ingrese un carácter en la posición [{i}, {j}]:");
                    matriz[i, j] = char.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz original:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }

            for (int j = 0; j < columnas; j++)
            {
                char temp = matriz[0, j];
                matriz[0, j] = matriz[filas - 1, j];
                matriz[filas - 1, j] = temp;
            }

            Console.WriteLine("Matriz con intercambio de filas:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
