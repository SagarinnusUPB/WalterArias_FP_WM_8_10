namespace _12.Primeros99Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar algoritmo que permita obtener la suma de todos los números impares hasta el 99. 
            int suma = 0;

            for (int i = 1; i <= 99; i += 2)
            {
                suma = suma + i;
            }

            Console.WriteLine($"La suma de todos los números impares hasta 99 es: {suma}");
        }
    }
}
