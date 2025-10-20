namespace _13.Aleatorios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde ingresar la cantidad de números que va a introducir.  
                El algoritmo debe escribir en pantalla: 
                La cantidad de números introducidos que son mayores que 0
                La cantidad de números introducidos menores que 0
                La cantidad de números iguales a 0.
            */

            Console.WriteLine("¿Cuántos números va a introducir?");
            int cantidad = int.Parse(Console.ReadLine());

            int mayores = 0;
            int menores = 0;
            int igualesCero = 0;

            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine($"Ingrese el número {i}:");
                int numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    mayores++;
                }
                else if (numero < 0)
                {
                    menores++;
                }
                else
                {
                    igualesCero++;
                }
            }

            Console.WriteLine($"Números mayores que 0: {mayores}");
            Console.WriteLine($"Números menores que 0: {menores}");
            Console.WriteLine($"Números iguales a 0: {igualesCero}");
        }
    }
}
