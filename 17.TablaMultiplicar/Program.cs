namespace _17.TablaMultiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10. Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar. 

            string continuar = "si";

            while (continuar == "si")
            {
                Console.WriteLine("Ingrese un número:");
                int numero = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    Console.WriteLine($"{numero} x {i} = {resultado}");
                }

                Console.WriteLine("¿Desea generar otra tabla de multiplicar? (si/no):");
                continuar = Console.ReadLine().ToLower();
            }
        }
    }
}
