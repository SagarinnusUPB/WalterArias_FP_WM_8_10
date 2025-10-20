namespace _1.parcial1_walter_arias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int edad = 0;
            int sala = 0;
            int juego = 0;
            String precio = "";
            bool esJuegoValido = true;
            Console.WriteLine("Bienvenido a la sala de juegos de Anoxia Studios");
            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad > 1 && edad <= 5)
            {
                Console.WriteLine("Seleccione la sala a la cual desea ingresar (Ingrese solo el número):");
                Console.WriteLine("    Sala 1");
                sala = Convert.ToInt32(Console.ReadLine());
            }
            else if (edad > 6 && edad <= 16)
            {
                Console.WriteLine("Seleccione la sala a la cual desea ingresar (Ingrese solo el número):");
                Console.WriteLine("    Sala 2");
                sala = Convert.ToInt32(Console.ReadLine());
            }
            else if (edad > 7 && edad <= 25)
            {
                Console.WriteLine("Seleccione la sala a la cual desea ingresar (Ingrese solo el número):");
                Console.WriteLine("    Sala 3\n    Sala 4");
                sala = Convert.ToInt32(Console.ReadLine());
            }
            else if (edad > 26)
            {
                Console.WriteLine("Seleccione la sala a la cual desea ingresar (Ingrese solo el número):");
                Console.WriteLine("    Sala 5");
                sala = Convert.ToInt32(Console.ReadLine());
            }
            else {
                Console.WriteLine("Ingrese una edad valida");
                esJuegoValido = false;
                sala = 6;
            }
            if (sala > 0 && sala <= 5)
            {
                Console.WriteLine("Seleccione el juego que desea (Ingrese solo el número):");
                switch (sala)
                {
                    case 1:
                        Console.WriteLine("    Juego 1 \n    Juego 5");
                        break;

                    case 2:
                        Console.WriteLine("    Juego 3 \n    Juego 6");
                        break;

                    case 3:
                        Console.WriteLine("    Juego 2 \n    Juego 7");
                        break;

                    case 4:
                        Console.WriteLine("    Juego 4 \n    Juego 8");
                        break;

                    case 5:
                        Console.WriteLine("    Juego 9 \n    Juego 10");
                        break;

                    case 6:
                        //Este caso solo es para cuando el usuario ingresa mal su edad
                        break;
                    default:
                        Console.WriteLine("Ingrese una sala valida");
                        break;
                }
                juego = Convert.ToInt32(Console.ReadLine());
                //Precios de los juegos de la Sala 1
                if (edad > 1 && edad <= 5 && sala == 1 && juego == 1) { Console.WriteLine("El juego tiene un precio de $3.000"); precio = "$3.000"; }
                else if (edad > 1 && edad <= 5 && sala == 1 && juego == 5) { Console.WriteLine("El juego tiene un precio de $7.000"); ; precio = "$7.000"; }

                //Precios de los juegos de la Sala 2
                else if (edad > 6 && edad <= 16 && sala == 2 && juego == 3) { Console.WriteLine("El juego tiene un precio de $7.000"); precio = "$7.000"; }
                else if (edad > 6 && edad <= 16 && sala == 2 && juego == 6) {Console.WriteLine("El juego tiene un precio de $9.000"); precio = "$9.000"; }
            
                //Precios de los juegos de la Sala 3
                else if (edad > 17 && edad <= 25 && sala == 3 && juego == 2) {Console.WriteLine("El juego tiene un precio de $5.000"); precio = "$5.000"; }
                else if (edad > 17 && edad <= 25 && sala == 3 && juego == 7) {Console.WriteLine("El juego tiene un precio de $10.000"); precio = "$10.000"; }

                //Precios de los juegos de la Sala 4
                else if (edad > 17 && edad <= 25 && sala == 4 && juego == 4) {Console.WriteLine("El juego tiene un precio de $9.000"); precio = "$9.000"; }
                else if (edad > 17 && edad <= 25 && sala == 4 && juego == 8) {Console.WriteLine("El juego tiene un precio de $7.000"); precio = "$7.000"; }

                //Precios de los juegos de la Sala 5
                else if (edad > 26 && sala == 26 && juego == 9) {Console.WriteLine("El juego tiene un precio de $5.000"); precio = "$7.000"; }
                else if (edad > 1 && sala == 5 && juego == 10) {Console.WriteLine("El juego tiene un precio de $3.000"); precio = "$3.000"; }

                //Caso juego mal ingresado
                else
                {
                    Console.WriteLine("Ingrese un juego valido");
                    esJuegoValido = false;
                }
                
            }
            else
            {
                Console.WriteLine("Ingrese una sala valida");
                esJuegoValido = false;
            }

            if (esJuegoValido) {
                Console.WriteLine($"Edad del usuario: {edad}. Sala seleccionada: {sala}. Juego seleccionado: {juego}. Precio a pagar:{precio}.\n \n Muchas gracias por confiar en Anoxia Studios");
            }
        }
    }
}
