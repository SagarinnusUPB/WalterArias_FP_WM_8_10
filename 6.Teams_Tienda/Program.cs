using System.Security.Cryptography;
using System.Text;

namespace _6.Teams_Tienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Tiendas La Avenida desea desarrollar un programa que permita ingresar por teclado el monto de compra y el día de la semana, para saber: 
                Si el día es martes o jueves, se realizará un descuento del 15 % por la compra.  
                Si el día es lunes o miércoles, se realizará un descuento del 10 % por la compra. 
                Si el día es viernes o sábado, se realizará un descuento del 20 % por la compra. 
                Si es domingo no se realiza descuento.
                Visualizar el día, el descuento y el total a pagar por la compra. Tiendas La Avenida desea desarrollar un programa que permita ingresar por teclado el monto de compra y el día de la semana, para saber:
                            Si el día es martes o jueves, se realizará un descuento del 15 % por la compra.  
                Si el día es lunes o miércoles, se realizará un descuento del 10 % por la compra. 
                Si el día es viernes o sábado, se realizará un descuento del 20 % por la compra. 
                Si es domingo no se realiza descuento.
                Visualizar el día, el descuento y el total a pagar por la compra. 
            */
            Console.WriteLine("Ingrese el monto de compra:");
            double monto = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el día de la semana: {domingo, lunes, martes, miercoles, jueves, viernes, sabado}");
            string dia = Console.ReadLine();

            double descuento = 0;

            if (dia == "martes" || dia == "jueves")
            {
                descuento = monto * 0.15;
            }
            else if (dia == "lunes" || dia == "miércoles")
            {
                descuento = monto * 0.10;
            }
            else if (dia == "viernes" || dia == "sábado")
            {
                descuento = monto * 0.20;
            }
            else if (dia == "domingo")
            {
                descuento = 0;
            }

            double totalAPagar = monto - descuento;

            Console.WriteLine("Día: " + dia);
            Console.WriteLine("Descuento: " + descuento);
            Console.WriteLine("Total a pagar: " + totalAPagar);
        }
    }
}
