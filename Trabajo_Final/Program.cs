namespace Trabajo_Final
{
    internal class Program
    {
        // Constantes para los tamaños máximos de los arreglos
        const int MAX_CLIENTES = 15; 
        const int MAX_VEHICULOS = 20; 
        const int MAX_SERVICIOS_POR_VEHICULO = 5; 

        // Arreglos para el modoulo de Clientes
        static string[] cedulasClientes = new string[MAX_CLIENTES];
        static string[] nombresClientes = new string[MAX_CLIENTES];
        static string[] telefonosClientes = new string[MAX_CLIENTES];
        static int numClientes = 0;

        // Arreglos para el modulo de Vehículos
        static string[] placasVehiculos = new string[MAX_VEHICULOS];
        static string[] marcasVehiculos = new string[MAX_VEHICULOS];
        static string[] modelosVehiculos = new string[MAX_VEHICULOS];
        static int[] aniosVehiculos = new int[MAX_VEHICULOS];
        static int numVehiculos = 0;

        static string[] vehiculoPropietario = new string[MAX_VEHICULOS];

        // Arreglos para el modulo de Servicios (Bidimensionales)
        static string[,] serviciosTipo = new string[MAX_VEHICULOS, MAX_SERVICIOS_POR_VEHICULO];
        static string[,] serviciosFecha = new string[MAX_VEHICULOS, MAX_SERVICIOS_POR_VEHICULO];
        static double[,] serviciosCosto = new double[MAX_VEHICULOS, MAX_SERVICIOS_POR_VEHICULO];

        // Arreglo que cuenta el nuermo de servicios por vehículo
        static int[] numServiciosPorVehiculo = new int[MAX_VEHICULOS];
        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("======================================================");
                Console.WriteLine("  Sistema de Gestión de Mantenimiento de Vehículos");
                Console.WriteLine("  Taller Anna y Walter");
                Console.WriteLine("======================================================");
                Console.WriteLine("1. Gestión de vehículos"); 
                Console.WriteLine("2. Gestión de clientes"); 
                Console.WriteLine("3. Gestión de servicios de mantenimiento"); 
                Console.WriteLine("4. Salir del programa");
                Console.Write("\nSeleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        GestionarVehiculos();
                        break;
                    case "2":
                        GestionarClientes();
                        break;
                    case "3":
                        GestionarServicios();
                        break;
                    case "4":
                        salir = true;
                        Console.WriteLine("\nMuchas gracias por usar nuestros servicios. Hasta pronto.");
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida.");
                        break;
                }
            }
        }

        public static void GestionarVehiculos()
        {
            bool volver = false;
            while (!volver)
            {
                Console.Clear();
                Console.WriteLine("Gestión de Vehículos");
                Console.WriteLine("1. Registrar un nuevo vehículo");
                Console.WriteLine("2. Ver lista de vehículos registrados");
                Console.WriteLine("3. Editar información de un vehículo (por placa)");
                Console.WriteLine("4. Asignar vehículo a un cliente");
                Console.WriteLine("5. Ver vehículos de un cliente específico");
                Console.WriteLine("6. Salir (Volver al Menú principal)");
                Console.Write("\nSeleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarVehiculo();
                        break;
                    case "2":
                        VerListaVehiculos();
                        break;
                    case "3":
                        EditarVehiculo();
                        break;
                    case "4":
                        AsignarVehiculoACliente();
                        break;
                    case "5":
                        VerVehiculosPorCliente();
                        break;
                    case "6":
                        volver = true;
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida.");
                        break;
                }
            }
        }

        public static void GestionarClientes()
        {
            bool volver = false;
            while (!volver)
            {
                Console.Clear();
                Console.WriteLine("Gestión de Clientes");
                Console.WriteLine("1. Registrar un nuevo cliente");
                Console.WriteLine("2. Ver lista de todos los clientes");
                Console.WriteLine("3. Editar información de un cliente");
                Console.WriteLine("4. Salir (Volver al Menú principal)");
                Console.Write("\nSeleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // RegistrarCliente();
                        break;
                    case "2":
                        // VerListaClientes();
                        break;
                    case "3":
                        // EditarCliente();
                        break;
                    case "4":
                        volver = true;
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida.");
                        break;
                }
            }
        }

        public static void GestionarServicios()
        {
            bool volver = false;
            while (!volver)
            {
                Console.Clear();
                Console.WriteLine("Gestión de Servicios de Mantenimiento");
                Console.WriteLine("1. Registrar servicio de mantenimiento a un vehículo");
                Console.WriteLine("2. Ver historial de servicios por vehículo");
                Console.WriteLine("3. Ver resumen de servicios de todos los vehículos");
                Console.WriteLine("4. Salir (Volver al Menú principal)");
                Console.Write("\nSeleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // RegistrarServicio();
                        break;
                    case "2":
                        // VerHistorialPorVehiculo();
                        break;
                    case "3":
                        // VerResumenTotal();
                        break;
                    case "4":
                        volver = true;
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida.");
                        break;
                }
            }
        }

        public static void RegistrarVehiculo()
        {
            Console.Clear();
            Console.WriteLine("Registrar Nuevo Vehículo");

            if (numVehiculos >= MAX_VEHICULOS)
            {
                Console.WriteLine("Error: Se ha alcanzado el límite máximo de 20 vehículos.");
                return;
            }

            string placa = LeerEntrada("Ingrese la placa del vehículo: ").ToUpper();

            if (BuscarVehiculoPorPlaca(placa) != -1)
            {
                Console.WriteLine("Error: Ya existe un vehículo registrado con esa placa.");
                return;
            }

            string marca = LeerEntrada("Ingrese la marca: ");
            string modelo = LeerEntrada("Ingrese el modelo: ");
            int anio = LeerEntero("Ingrese el año (1900-2026): ", 1900, 2026);

            // Guardar en los arreglos
            placasVehiculos[numVehiculos] = placa;
            marcasVehiculos[numVehiculos] = marca;
            modelosVehiculos[numVehiculos] = modelo;
            aniosVehiculos[numVehiculos] = anio;
            vehiculoPropietario[numVehiculos] = "SIN ASIGNAR"; // Valor por defecto
            numServiciosPorVehiculo[numVehiculos] = 0; // Inicializar contador de servicios

            numVehiculos++; // Incrementar el contador

            Console.WriteLine("\n¡Vehículo registrado exitosamente!");
        }

        public static void VerListaVehiculos()
        {
            Console.Clear();
            Console.WriteLine("Lista de Vehículos Registrados");

        if (numVehiculos == 0)
            {
                Console.WriteLine("No hay vehículos registrados.");
                return;
            }

            for (int i = 0; i < numVehiculos; i++)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"Vehículo #{i + 1}");
                Console.WriteLine($"  Placa:        {placasVehiculos[i]}");
                Console.WriteLine($"  Marca:        {marcasVehiculos[i]}");
                Console.WriteLine($"  Modelo:       {modelosVehiculos[i]}");
                Console.WriteLine($"  Año:          {aniosVehiculos[i]}");
                Console.WriteLine($"  Propietario (C.C): {vehiculoPropietario[i]}");
            }
            Console.WriteLine("---------------------------------");
        }

        public static void EditarVehiculo()
        {
            Console.Clear();
            Console.WriteLine("--- Editar Información de Vehículo ---");

            string placa = LeerEntrada("Ingrese la placa del vehículo a editar: ").ToUpper();
            int index = BuscarVehiculoPorPlaca(placa);

            if (index == -1)
            {
                Console.WriteLine("Error: No se encontró ningún vehículo con esa placa.");
                return;
            }

            Console.WriteLine("\nDatos actuales:");
            Console.WriteLine($"  Marca:  {marcasVehiculos[index]}");
            Console.WriteLine($"  Modelo: {modelosVehiculos[index]}");
            Console.WriteLine($"  Año:    {aniosVehiculos[index]}");
            Console.WriteLine("(La placa no se puede modificar)\n");

            string nuevaMarca = LeerEntrada("Ingrese la nueva marca (deje en blanco para no cambiar): ");
            string nuevoModelo = LeerEntrada("Ingrese el nuevo modelo (deje en blanco para no cambiar): ");
            string anioStr = LeerEntrada("Ingrese el nuevo año (deje en blanco para no cambiar): ");

            if (!string.IsNullOrEmpty(nuevaMarca))
            {
                marcasVehiculos[index] = nuevaMarca;
            }
            if (!string.IsNullOrEmpty(nuevoModelo))
            {
                modelosVehiculos[index] = nuevoModelo;
            }
            if (!string.IsNullOrEmpty(anioStr))
            {
                // Validamos el año ingresado
                int nuevoAnio;
                if (int.TryParse(anioStr, out nuevoAnio) && nuevoAnio >= 1900 && nuevoAnio <= 2026)
                {
                    aniosVehiculos[index] = nuevoAnio;
                }
                else
                {
                    Console.WriteLine("Año no válido, no se actualizó.");
                }
            }

            Console.WriteLine("\n¡Información actualizada exitosamente!");
        }

        public static void AsignarVehiculoACliente()
        {
            Console.Clear();
            Console.WriteLine("Asignar Vehículo a Cliente");

            if (numVehiculos == 0 || numClientes == 0)
            {
                Console.WriteLine("Error: Debe haber al menos un vehículo Y un cliente registrados.");
                return;
            }

            string placa = LeerEntrada("Ingrese la placa del vehículo: ").ToUpper();
            int vIndex = BuscarVehiculoPorPlaca(placa);

            if (vIndex == -1)
            {
                Console.WriteLine("Error: Vehículo no encontrado.");
                return;
            }

            string cedula = LeerEntrada("Ingrese la cédula del cliente al que desea asignarlo: ");
            int cIndex = BuscarClientePorCedula(cedula);

            if (cIndex == -1)
            {
                Console.WriteLine("Error: Cliente no encontrado.");
                return;
            }

            // Realizar la asignación
            vehiculoPropietario[vIndex] = cedulasClientes[cIndex];

            Console.WriteLine("\n¡Asignación exitosa!");
            Console.WriteLine($"Vehículo {placasVehiculos[vIndex]} asignado a {nombresClientes[cIndex]}.");
        }

        public static void VerVehiculosPorCliente()
        {
            Console.Clear();
            Console.WriteLine("--- Ver Vehículos de un Cliente ---");

        string cedula = LeerEntrada("Ingrese la cédula del cliente: ");
            int cIndex = BuscarClientePorCedula(cedula);

            if (cIndex == -1)
            {
                Console.WriteLine("Error: Cliente no encontrado.");
                return;
            }

            Console.WriteLine($"\nMostrando vehículos de: {nombresClientes[cIndex]} (C.C: {cedula})");
            bool encontrados = false;

            for (int i = 0; i < numVehiculos; i++)
            {
                // Comparamos la cédula buscada con la cédula almacenada en el arreglo de propietarios
                if (vehiculoPropietario[i] == cedula)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($"  Placa:  {placasVehiculos[i]}");
                    Console.WriteLine($"  Marca:  {marcasVehiculos[i]}");
                    Console.WriteLine($"  Modelo: {modelosVehiculos[i]}");
                    Console.WriteLine($"  Año:    {aniosVehiculos[i]}");
                    encontrados = true;
                }
            }

            if (!encontrados)
            {
                Console.WriteLine("\nEl cliente no tiene vehículos asignados.");
            }
            else
            {
                Console.WriteLine("---------------------------------");
            }
        }

        public static int BuscarClientePorCedula(string cedula)
        {
            for (int i = 0; i < numClientes; i++)
            {
                if (cedulasClientes[i] == cedula)
                {
                    return i; // Encontrado
                }
            }
            return -1; // No encontrado
        }

        public static int BuscarVehiculoPorPlaca(string placa)
        {
            for (int i = 0; i < numVehiculos; i++)
            {
                if (placasVehiculos[i] == placa)
                {
                    return i; // Encontrado
                }
            }
            return -1; // No encontrado
        }

        public static string LeerEntrada(string mensaje)
        {
            string entrada = "";
            while (string.IsNullOrEmpty(entrada))
            {
                Console.Write(mensaje);
                entrada = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(entrada))
                {
                    Console.WriteLine("Error: La entrada no puede estar vacía.");
                }
            }
            return entrada;
        }

        public static int LeerEntero(string mensaje, int min, int max)
        {
            int valor = 0;
            bool valido = false;
            while (!valido)
            {
                Console.Write(mensaje);
                if (int.TryParse(Console.ReadLine(), out valor))
                {
                    if (valor >= min && valor <= max)
                    {
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine($"Error: El valor debe estar entre {min} y {max}.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Por favor ingresar un número entero.");
                }
            }
            return valor;
        }

        public static double LeerDouble(string mensaje, double min)
        {
            double valor = 0;
            bool valido = false;
            while (!valido)
            {
                Console.Write(mensaje);
                if (double.TryParse(Console.ReadLine(), out valor))
                {
                    if (valor >= min)
                    {
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine($"Error: El valor debe ser mayor o igual a {min}.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Por favor ingresar un número válido.");
                }
            }
            return valor;
        }
    }
}
