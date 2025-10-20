namespace _6._2.MesDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñar un algoritmo que solicite al usuario un número del 1 al 12, correspondiente a un mes del año (1 para enero, 2 para febrero, etc.). El algoritmo debe mostrar en pantalla el nombre del mes seleccionado y la cantidad de días que contiene. 
            Console.WriteLine("Ingrese un número del 1 al 12 correspondiente a un mes:");
            int mes = int.Parse(Console.ReadLine());

            string nombreMes = "";
            int dias = 0;

            if (mes == 1)
            {
                nombreMes = "Enero";
                dias = 31;
            }
            else if (mes == 2)
            {
                nombreMes = "Febrero";
                dias = 28;
            }
            else if (mes == 3)
            {
                nombreMes = "Marzo";
                dias = 31;
            }
            else if (mes == 4)
            {
                nombreMes = "Abril";
                dias = 30;
            }
            else if (mes == 5)
            {
                nombreMes = "Mayo";
                dias = 31;
            }
            else if (mes == 6)
            {
                nombreMes = "Junio";
                dias = 30;
            }
            else if (mes == 7)
            {
                nombreMes = "Julio";
                dias = 31;
            }
            else if (mes == 8)
            {
                nombreMes = "Agosto";
                dias = 31;
            }
            else if (mes == 9)
            {
                nombreMes = "Septiembre";
                dias = 30;
            }
            else if (mes == 10)
            {
                nombreMes = "Octubre";
                dias = 31;
            }
            else if (mes == 11)
            {
                nombreMes = "Noviembre";
                dias = 30;
            }
            else if (mes == 12)
            {
                nombreMes = "Diciembre";
                dias = 31;
            }
            else
            {
                Console.WriteLine("Número inválido");
            }

            if (mes >= 1 && mes <= 12)
            {
                Console.WriteLine($"Mes: {nombreMes}");
                Console.WriteLine($"Días: {dias}");
            }
        }
    }
}
