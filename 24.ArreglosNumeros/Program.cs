namespace _24.ArreglosNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear arreglo llamado "numeros" de 100 elementos asignar el número 10 en cada una de las posiciones del arreglo. Leer el contenido de cada elemento y escribirlo en pantalla.

            int[] numeros = new int[100];

            for (int i = 0; i < 100; i++)
            {
                numeros[i] = 10;
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Posición {i}: {numeros[i]}");
            }
        }
    }
}
