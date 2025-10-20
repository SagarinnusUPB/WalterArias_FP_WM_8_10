namespace _10.factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita calcular la factorial de un número dado por el usuario. (5! = 1*2*3*4*5)

            Console.WriteLine("Ingrese un número:");
            int numero = int.Parse(Console.ReadLine());

            int factorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine($"El factorial de {numero} es: {factorial}");
        }
    }
}
