namespace _4.Taller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Crea un algoritmo que represente un tablero de juego de 5x5 donde se coloquen 3 "X" en 
            posiciones aleatorias. Luego, el algoritmo le debe permitir al usuario intentar adivinar la 
            posición de una "X". 
            El algoritmo debe permitir: 
             Usar la función Random para colocar las "X" en la matriz. 
             Realizar 3 intentos para ingresar coordenadas y verificar si ha acertado. 
             Al final sacar un mensaje de éxito o error. Si el mensaje es de éxito mostrar la 
            posición de la X en la matriz. Si el mensaje es de error, mostrar la matriz. 
             */

            int[,] tablero = new int[5, 5];
            Random random = new Random();
            int aciertos = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    tablero[i, j] = 0;
                }
            }

            int contadorX = 0;
            while (contadorX < 3)
            {
                int fila = random.Next(0, 5);
                int columna = random.Next(0, 5);

                if (tablero[fila, columna] != 1)
                {
                    tablero[fila, columna] = 1;
                    contadorX++;
                }
            }

            for (int intento = 0; intento < 3; intento++)
            {
                Console.WriteLine($"Intento {intento + 1}:");
                Console.WriteLine("Ingrese la fila (0-4):");
                int fila = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la columna (0-4):");
                int columna = int.Parse(Console.ReadLine());

                if (tablero[fila, columna] == 1)
                {
                    aciertos++;
                    Console.WriteLine("¡Acertó! Encontró una X");
                }
                else
                {
                    Console.WriteLine("No hay X en esa posición");
                }
            }

            if (aciertos > 0)
            {
                Console.WriteLine($"¡Éxito! Acertó {aciertos} X(s)");
                Console.WriteLine("Posiciones de las X:");
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (tablero[i, j] == 1)
                        {
                            Console.WriteLine($"X en posición [{i}, {j}]");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Error: No acertó ninguna X");
                Console.WriteLine("Tablero:");
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(tablero[i, j] == 1 ? "X " : "- ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
