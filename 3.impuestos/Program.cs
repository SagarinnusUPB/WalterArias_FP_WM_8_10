namespace _3.impuestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos. De lo contrario mostrar el mensaje “Persona exenta de impuestos”.

            Console.WriteLine("Ingrese el nombre de la persona:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el sueldo:");
            decimal sueldo = decimal.Parse(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine(nombre + " debe abonar impuestos");
            }
            else
            {
                Console.WriteLine("Persona exenta de impuestos");
            }
        }
    }
}
