namespace _14.Rango
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un algoritmo que cuente cuántos números pares hay en un rango de números del 1 al número n.

            Console.WriteLine("Ingrese el número n:");
            int n = int.Parse(Console.ReadLine());

            int contadorPares = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    contadorPares++;
                }
            }

            Console.WriteLine($"La cantidad de números pares del 1 al {n} es: {contadorPares}");
        }
    }
}
