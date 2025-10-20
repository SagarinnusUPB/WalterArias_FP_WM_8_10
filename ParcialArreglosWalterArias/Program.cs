namespace ParcialArreglosWalterArias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Configuracion inicial del tablero
            char[,] tableroUsuario = new char[8, 8];
            char[,] tableroBase = new char[8, 8]   {{ 'T', 'C', 'A', 'D', 'R', 'A', 'C', 'T'},
                                                    { 'P', 'P', 'P', 'P', 'P', 'P', 'P', 'P' },
                                                    { 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X' },
                                                    { 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X' },
                                                    { 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X' },
                                                    { 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'X' },
                                                    { 'P', 'P', 'P', 'P', 'P', 'P', 'P', 'P' },
                                                    { 'T', 'C', 'A', 'D', 'R', 'A', 'C', 'T' }};

            char entradaUsuario = '_';
            Console.WriteLine("Bienvenido a UPB Chess. Por favor ingrese las fichas para un tablero inicial ");
            Console.WriteLine("Recuerde: Ingresar => ficha\nR => Rey\nD => Dama\nT => Torre\nA => Alfil\nC => Caballo\nP => Peon\nX => Vacia\n");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    entradaUsuario = '_';
                    do {
                        Console.Write($"Ingrese la ficha correspondiente a la posición [ {i}, {j}] : ");
                        entradaUsuario = Convert.ToChar(Console.ReadLine());
                        if (entradaUsuario != tableroBase[i, j]) Console.WriteLine("Error, Ingrese la ficha correcta");
                    } while(entradaUsuario != tableroBase[i, j]);
                    tableroUsuario[i , j] = entradaUsuario;
                }
            }
            Console.WriteLine("A continuación se muestra el tablero ingresado: ");
            for (int i = 0;i < 8;i++)
            {
                for(int j = 0;j < 8;j++)
                {
                    Console.Write($" {tableroUsuario[i,j]} ");

                }
                Console.WriteLine();
            }
        }
    }
}
