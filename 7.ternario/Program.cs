namespace _7.ternario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que verifique si una persona es mayor de edad usando el operador ternario. Una persona mayor de edad tiene 18 años o más).
            Console.WriteLine("Ingrese su edad:");
            int edad = int.Parse(Console.ReadLine());

            string mensaje = edad >= 18 ? "Es mayor de edad" : "Es menor de edad";

            Console.WriteLine(mensaje);
        }
    }
}
