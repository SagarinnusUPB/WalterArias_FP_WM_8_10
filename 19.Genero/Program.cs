namespace _19.Genero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //En un grupo de 100 alumnos, se desea saber cuántos de los estudiantes son hombres y cuántos son mujeres, además se desea saber cuántos son mayores de edad y cuántos no. 

            int hombres = 0;
            int mujeres = 0;
            int mayoresDeEdad = 0;
            int menoresDeEdad = 0;

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Estudiante {i}");
                Console.WriteLine("Ingrese el género (hombre/mujer):");
                string genero = Console.ReadLine();

                Console.WriteLine("Ingrese la edad:");
                int edad = int.Parse(Console.ReadLine());

                if (genero == "hombre")
                {
                    hombres++;
                }
                else if (genero == "mujer")
                {
                    mujeres++;
                }

                if (edad >= 18)
                {
                    mayoresDeEdad++;
                }
                else
                {
                    menoresDeEdad++;
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Cantidad de hombres: {hombres}");
            Console.WriteLine($"Cantidad de mujeres: {mujeres}");
            Console.WriteLine($"Mayores de edad: {mayoresDeEdad}");
            Console.WriteLine($"Menores de edad: {menoresDeEdad}");

        }
    }
}
