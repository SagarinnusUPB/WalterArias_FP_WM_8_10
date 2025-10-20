namespace _5.comparacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita ingresar dos números, si el primer número es mayor al segundo número informar su suma y diferencia, en caso contrario informar el producto y la división del primer número respecto al segundo número.

            Console.WriteLine("Ingrese el primer número:");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double numero2 = double.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                double suma = numero1 + numero2;
                double diferencia = numero1 - numero2;
                Console.WriteLine("Suma: " + suma);
                Console.WriteLine("Diferencia: " + diferencia);
            }
            else
            {
                double producto = numero1 * numero2;
                double division = numero1 / numero2;
                Console.WriteLine("Producto: " + producto);
                Console.WriteLine("División: " + division);
            }
        }
    }
}
