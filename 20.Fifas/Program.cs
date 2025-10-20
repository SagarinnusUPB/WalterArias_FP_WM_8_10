namespace _20.Fifas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Un equipo de futbol jugó 30 partidos en el año, se desea crear un algoritmo que permita saber:   
                El número de partidos perdidos
                El número de partidos empatados
                El número de partidos ganados
                El porcentaje de partidos perdidos
                El porcentaje de partidos empatados
                El porcentaje de partidos ganados
            */
            int partidos = 30;
            int ganados = 0;
            int empatados = 0;
            int perdidos = 0;

            for (int i = 1; i <= partidos; i++)
            {
                Console.WriteLine($"Partido {i}");
                Console.WriteLine("Ingrese el resultado (ganado/empatado/perdido):");
                string resultado = Console.ReadLine();

                if (resultado == "ganado")
                {
                    ganados++;
                }
                else if (resultado == "empatado")
                {
                    empatados++;
                }
                else if (resultado == "perdido")
                {
                    perdidos++;
                }
            }

            double porcentajeGanados = (ganados * 100.0) / partidos;
            double porcentajeEmpatados = (empatados * 100.0) / partidos;
            double porcentajePerdidos = (perdidos * 100.0) / partidos;

            Console.WriteLine($"Partidos ganados: {ganados}");
            Console.WriteLine($"Partidos empatados: {empatados}");
            Console.WriteLine($"Partidos perdidos: {perdidos}");
            Console.WriteLine($"Porcentaje de partidos ganados: {porcentajeGanados}%");
            Console.WriteLine($"Porcentaje de partidos empatados: {porcentajeEmpatados}%");
            Console.WriteLine($"Porcentaje de partidos perdidos: {porcentajePerdidos}%");
        }
    }
}
