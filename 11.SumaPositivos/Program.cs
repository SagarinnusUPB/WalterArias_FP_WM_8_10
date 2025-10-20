namespace _11.SumaPositivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla el total de la suma de los números ingresados. 

            int suma = 0;
            int numero = 0;

            while (numero >= 0)
            {
                Console.WriteLine("Ingrese un número entero positivo:");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 0)
                {
                    suma = suma + numero;
                }
            }

            Console.WriteLine($"Total de la suma: {suma}");
        }
    }
}
