namespace _1.Taller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por pantalla la suma de los elementos de cada columna.

            int[,] matriz = new int[10, 20];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    matriz[i, j] = i + j;
                }
            }

            for (int j = 0; j < 20; j++)
            {
                int sumaColumna = 0;
                for (int i = 0; i < 10; i++)
                {
                    sumaColumna = sumaColumna + matriz[i, j];
                }
                Console.WriteLine($"Columna {j}: {sumaColumna}");
            }
        }
    }
}
