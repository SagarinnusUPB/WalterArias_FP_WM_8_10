namespace _15.Ahorro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo para determinar cuánto ahorrará una persona en un año, si al final de cada mes deposita cantidades variables de dinero; además, se quiere saber cuánto lleva ahorrado cada mes. 

            double ahorroTotal = 0;

            for (int mes = 1; mes <= 12; mes++)
            {
                Console.WriteLine($"Ingrese el monto a depositar en el mes {mes}:");
                double deposito = double.Parse(Console.ReadLine());

                ahorroTotal = ahorroTotal + deposito;

                Console.WriteLine($"Ahorro acumulado al mes {mes}: {ahorroTotal}");
            }

            Console.WriteLine($"Total ahorrado en el año: {ahorroTotal}");
        }
    }
}
