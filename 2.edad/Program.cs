namespace _2.edad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: “Bienvenido a mi sitio web”. 
            Console.WriteLine("Ingrese su edad:");
            int edad = int.Parse(Console.ReadLine());

            if (edad > 18)
            {
                Console.WriteLine("Bienvenido a mi sitio web");
            }
        }
    }
}
