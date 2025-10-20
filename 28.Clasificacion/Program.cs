using System.Runtime.ConstrainedExecution;

namespace _28.Clasificacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Clasificación de números en una matriz
                Desarrolla una aplicación que realice las siguientes tareas:
                    1- Solicita al usuario que ingrese las dimensiones de una matriz(número de filas y columnas). 
                    2- Recorre la matriz y permite al usuario ingresar un número entero en cada posición. 
                    3- Una vez cargada la matriz, el programa debe contar cuántos de los números ingresados son positivos, cuántos son negativos y cuántos son ceros.
                    4- Finalmente, muestra por pantalla los totales obtenidos para cada categoría(positivos, negativos y ceros).
            */

            Console.WriteLine("Ingrese el número de filas:");
            int filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas:");
            int columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine($"Ingrese el número en la posición [{i}, {j}]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int positivos = 0;
            int negativos = 0;
            int ceros = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] > 0)
                    {
                        positivos++;
                    }
                    else if (matriz[i, j] < 0)
                    {
                        negativos++;
                    }
                    else
                    {
                        ceros++;
                    }
                }
            }

            Console.WriteLine($"Números positivos: {positivos}");
            Console.WriteLine($"Números negativos: {negativos}");
            Console.WriteLine($"Números ceros: {ceros}");
        }
    }
}
