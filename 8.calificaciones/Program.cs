namespace _8.calificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un algoritmo que permita solicitar 3 calificaciones, calcular el promedio. Si el promedio se ubica en los siguientes rangos, escribir los correspondientes mensajes. Considerar la situación en donde el promedio generado no esté contemplado en los rangos establecidos, mostrar mensaje de error. 
                9.5 - 10.0 Excelente
                8.5 - 9.4 Muy bien
                7.5 - 8.4 Bien
            */
            Console.WriteLine("Ingrese la primera calificación:");
            double calificacion1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda calificación:");
            double calificacion2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la tercera calificación:");
            double calificacion3 = double.Parse(Console.ReadLine());

            double promedio = (calificacion1 + calificacion2 + calificacion3) / 3;

            if (promedio >= 9.5 && promedio <= 10.0)
            {
                Console.WriteLine("Excelente");
            }
            else if (promedio >= 8.5 && promedio <= 9.4)
            {
                Console.WriteLine("Muy bien");
            }
            else if (promedio >= 7.5 && promedio <= 8.4)
            {
                Console.WriteLine("Bien");
            }
            else
            {
                Console.WriteLine("Error, ingrese bien la calificació");
            }
        }
    }
}
