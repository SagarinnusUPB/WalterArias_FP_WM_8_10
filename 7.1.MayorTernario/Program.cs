namespace _7._1.MayorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita ingresar 3 números enteros, y mostrar por pantalla cuál es el mayor

            Console.WriteLine("Ingrese el primer número:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número:");
            int numero3 = int.Parse(Console.ReadLine());

            int mayor = numero1 > numero2 ? numero1 : numero2;
            mayor = mayor > numero3 ? mayor : numero3;

            Console.WriteLine($"El número mayor es: {mayor}");
        }
    }
}
