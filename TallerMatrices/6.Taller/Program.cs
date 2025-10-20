namespace _6.Taller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Crear una aplicación en C# que permita realizar las siguientes acciones: 
             Crear una matriz de n filas por m columnas 
             Llenar la matriz con números aleatorios del 1 al 3 (investigar la función random en C#) 
             Mostrar la matriz generada 
             Mostrar por pantalla cuantas veces fue ingresado el número 1, el número 2, y el 
            número 3, y cuál de los tres números fue repetido más veces.
             */

            Console.WriteLine("Ingrese el número de filas:");
            int filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas:");
            int columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];
            Random random = new Random();
            int contador1 = 0;
            int contador2 = 0;
            int contador3 = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = random.Next(1, 4);
                }
            }

            Console.WriteLine("Matriz generada:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz[i, j]} ");

                    if (matriz[i, j] == 1)
                        contador1++;
                    else if (matriz[i, j] == 2)
                        contador2++;
                    else if (matriz[i, j] == 3)
                        contador3++;
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Número 1 aparece: {contador1} veces");
            Console.WriteLine($"Número 2 aparece: {contador2} veces");
            Console.WriteLine($"Número 3 aparece: {contador3} veces");

            int maximo = contador1 > contador2 ? contador1 : contador2;
            maximo = maximo > contador3 ? maximo : contador3;

            string numeroMasRepetido = contador1 == maximo ? "1" : (contador2 == maximo ? "2" : "3");

            Console.WriteLine($"El número más repetido es: {numeroMasRepetido}");
        }
    }
}
