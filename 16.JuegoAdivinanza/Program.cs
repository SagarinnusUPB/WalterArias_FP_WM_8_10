namespace _16.JuegoAdivinanza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribe un algoritmo en el que el ordenador elija un número aleatorio entre 1 y 100. El usuario debe adivinar el número, y el programa debe decirle si su intento es demasiado alto, demasiado bajo o correcto. Usa un ciclo while para seguir pidiendo intentos hasta que el usuario adivine el número. 
            
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);

            int intento = 0;

            while (intento != numeroSecreto)
            {
                Console.WriteLine("Adivine el número entre 1 y 100:");
                intento = int.Parse(Console.ReadLine());

                if (intento > numeroSecreto)
                {
                    Console.WriteLine("El número es demasiado alto");
                }
                else if (intento < numeroSecreto)
                {
                    Console.WriteLine("El número es demasiado bajo");
                }
                else
                {
                    Console.WriteLine("¡Correcto! Adivinó el número");
                }
            }
        }
    }
}
