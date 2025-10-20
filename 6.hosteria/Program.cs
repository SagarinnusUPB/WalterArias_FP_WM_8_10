namespace _6.hosteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Un cliente se hospeda varias noches en una hostería, el precio por noche es de 200 dólares. Si el usuario se queda más de 3 noches se le aplica un porcentaje de descuento del 17 % y si no se aplica un porcentaje de descuento del 2 %. Mostrar un mensaje con el monto total que debe pagar el cliente, sabiendo que el usuario indica cuántas noches se va a quedar en la hostería.

            Console.WriteLine("¿Cuántas noches se va a quedar?");
            double noches = double.Parse(Console.ReadLine());

            double precioPorNoche = 200;
            double montoTotal = noches * precioPorNoche;
            double descuento;

            if (noches > 3)
            {
                descuento = montoTotal * 0.17;
            }
            else
            {
                descuento = montoTotal * 0.02;
            }

            double montoFinal = montoTotal - descuento;

            Console.WriteLine("Monto total a pagar: " + montoFinal + " dólares");
        }
    }
}
