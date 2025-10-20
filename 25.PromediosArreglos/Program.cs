namespace _25.PromediosArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo que permita solicitar 10 números, los cuales serán almacenados en un arreglo unidimensional, al final, debe visualizar el promedio de esos números.

            double[] numeros = new double[10];
            double suma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Ingrese el número {i + 1}:");
                numeros[i] = double.Parse(Console.ReadLine());
                suma = suma + numeros[i];
            }

            double promedio = suma / 10;

            Console.WriteLine($"El promedio de los números es: {promedio}");
        }
    }
}
