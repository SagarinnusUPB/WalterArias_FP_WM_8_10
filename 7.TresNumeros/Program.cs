namespace _7.TresNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñar un algoritmo que lea tres números A, B, C y visualice en pantalla el valor más grande. El usuario debe ingresar tres valores diferentes. 
            Console.WriteLine("Ingrese el primer número (A):");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número (B):");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número (C):");
            double c = double.Parse(Console.ReadLine());

            double mayor = a;

            if (b > mayor)
            {
                mayor = b;
            }

            if (c > mayor)
            {
                mayor = c;
            }

            Console.WriteLine("El número más grande es: " + mayor);
        }
    }
}
