namespace _6._1.Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas entre dos números ingresados por el usuario. Las operaciones disponibles serán: suma, resta, multiplicación y división, las cuales se ejecutarán según la opción seleccionada por el usuario.

            Console.WriteLine("Ingrese el primer número:");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione la operación:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            string opcion = Console.ReadLine();

            double resultado = 0;

            if (opcion == "1")
            {
                resultado = numero1 + numero2;
                Console.WriteLine("Resultado: " + resultado);
            }
            else if (opcion == "2")
            {
                resultado = numero1 - numero2;
                Console.WriteLine("Resultado: " + resultado);
            }
            else if (opcion == "3")
            {
                resultado = numero1 * numero2;
                Console.WriteLine("Resultado: " + resultado);
            }
            else if (opcion == "4")
            {
                resultado = numero1 / numero2;
                Console.WriteLine("Resultado: " + resultado);
            }
            else
            {
                Console.WriteLine("Opción inválida");
            }
        }
    }
}
