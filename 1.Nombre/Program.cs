namespace _1.Nombre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos.
            String nombre = "";
            int sueldo = 0;

            Console.WriteLine("Ingresa tu nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo: ");
            sueldo = int.Parse(Console.ReadLine());
            if (sueldo > 3000) Console.WriteLine($"El usuario {nombre} debe abonar impuestos");
        }
    }
}
