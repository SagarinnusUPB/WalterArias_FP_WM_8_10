using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _18.RegistroBancario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; para cada usuario se debe hacer lo siguiente: 
            Si el saldo es mayor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “Es apto para el crédito” 
            Si el saldo es menor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “No es apto para el crédito” 
            El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique que ya no se desea preguntar más. 
            Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto por la información, y debe mostrar el promedio de los saldos.
            */
            string continuar = "si";
            int cantidadUsuarios = 0;
            double sumaSaldos = 0;

            while (continuar == "si")
            {
                Console.WriteLine("Ingrese el nombre del usuario:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el número de cuenta:");
                string numeroCuenta = Console.ReadLine();

                Console.WriteLine("Ingrese el saldo:");
                double saldo = double.Parse(Console.ReadLine());

                string apto = saldo > 3000000 ? "Es apto para el crédito" : "No es apto para el crédito";

                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Número de cuenta: {numeroCuenta}");
                Console.WriteLine($"Saldo: {saldo}");
                Console.WriteLine($"{apto}");
                Console.WriteLine();

                cantidadUsuarios++;
                sumaSaldos = sumaSaldos + saldo;

                Console.WriteLine("¿Desea ingresar otro usuario? (si/no):");
                continuar = Console.ReadLine().ToLower();
            }

            double promedioSaldos = sumaSaldos / cantidadUsuarios;

            Console.WriteLine($"Cantidad de usuarios: {cantidadUsuarios}");
            Console.WriteLine($"Promedio de saldos: {promedioSaldos}");
        }
    }
}
