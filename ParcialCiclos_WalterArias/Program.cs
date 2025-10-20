namespace ParcialCiclos_WalterArias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Don Alcides, un tendero, realiza la venta de 10 productos y necesita calcular el valor total de la venta aplicando el IVA correspondiente a cada uno de ellos según las siguientes condiciones:

            Si el valor del producto es mayor a 10.000, se aplica un 15 % de IVA.
            Si el valor del producto es menor o igual a 5.000, se aplica un 19 % de IVA.

            El programa debe realizar lo siguiente:

            1. Solicitar por teclado el valor de cada uno de los 10 productos.
            2. Calcular el subtotal de cada producto, teniendo en cuenta el valor ingresado más el IVA correspondiente.
            3. Sumar los subtotales de los 10 productos.
            4. Mostrar en pantalla el valor total de la venta. */
            
            Console.WriteLine("Bienvenido a la tienda de Don Alcides");
            double producto = 0;
            double acumulado = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Ingrese el valor del producto numero {i+1}:"); //Punto 1
                producto = Convert.ToDouble(Console.ReadLine());
                //Calculo de los subtotales y suma; Puntos 2 y 3
                if (producto > 10000)
                {
                    //Mayor de 10.000 se aplica el 15%
                    acumulado += producto*1.15;
                }
                else if (producto <= 5000)
                {
                    //Menor de 5.000 se aplica el 19%
                    acumulado += producto * 1.19;
                }
                else 
                {
                    //Interpretacion: No se debe aplicar ningun incremento
                    acumulado += producto;
                }
            }
            Console.WriteLine($"El total de la venta es de {acumulado}"); //Punto 4
        }
    }
}
