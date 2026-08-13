using System;

const int MAX_OPERADORES = 100;

string[] nombres = new string[MAX_OPERADORES];
int[] edades = new int[MAX_OPERADORES];
int[] niveles = new int[MAX_OPERADORES];
bool[] credenciales = new bool[MAX_OPERADORES];
string[] codigos = new string[MAX_OPERADORES];

int cantidadOperadores = 0;
int accesosAutorizados = 0;
int accesosDenegados = 0;

Random random = new Random();

int opcion;

do
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("==========================================");
    Console.WriteLine("          OPERACIÓN CÓDIGO ROJO");
    Console.WriteLine("==========================================");
    Console.ResetColor();

    Console.WriteLine("1. Registrar operador");
    Console.WriteLine("2. Mostrar operadores");
    Console.WriteLine("3. Simular acceso");
    Console.WriteLine("4. Generar código de seguridad");
    Console.WriteLine("5. Mostrar estadísticas");
    Console.WriteLine("6. Mostrar fecha y hora");
    Console.WriteLine("7. Salir");

    Console.Write("Seleccione una opción: ");

    while (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.Write("Opción inválida. Intente nuevamente: ");
    }

    switch (opcion)
    {
        // =========================================
        // 1. REGISTRAR OPERADOR
        // =========================================
        case 1:

            Console.Clear();

            if (cantidadOperadores >= MAX_OPERADORES)
            {
                Console.WriteLine("No se pueden registrar más operadores.");
                Console.ReadKey();
                break;
            }

            Console.WriteLine("========== REGISTRO DE OPERADOR ==========");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine() ?? "";

            while (nombre.Trim() == "")
            {
                Console.Write("El nombre no puede estar vacío. Ingrese nuevamente: ");
                nombre = Console.ReadLine() ?? "";
            }

            Console.Write("Edad: ");

            int edad;

            while (!int.TryParse(Console.ReadLine(), out edad) || edad < 0)
            {
                Console.Write("Edad inválida. Ingrese nuevamente: ");
            }

            Console.Write("Nivel de seguridad (1-5): ");

            int nivel;

            while (!int.TryParse(Console.ReadLine(), out nivel) ||
                   nivel < 1 || nivel > 5)
            {
                Console.Write("Nivel inválido. Ingrese un valor entre 1 y 5: ");
            }

            Console.Write("¿Credencial activa? (si/no): ");

            string respuesta = Console.ReadLine() ?? "";

            bool credencialActiva =
                respuesta.Trim().ToLower() == "si";

            nombres[cantidadOperadores] = nombre.Trim().ToUpper();
            edades[cantidadOperadores] = edad;
            niveles[cantidadOperadores] = nivel;
            credenciales[cantidadOperadores] = credencialActiva;

            codigos[cantidadOperadores] =
                "OP-" + random.Next(1000, 10000);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Operador registrado correctamente.");
            Console.ResetColor();

            Console.WriteLine("Código asignado: "
                + codigos[cantidadOperadores]);

            cantidadOperadores++;

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

            break;


        // =========================================
        // 2. MOSTRAR OPERADORES
        // =========================================
        case 2:

            Console.Clear();

            Console.WriteLine("========== OPERADORES REGISTRADOS ==========");

            if (cantidadOperadores == 0)
            {
                Console.WriteLine("No hay operadores registrados.");
            }
            else
            {
                for (int i = 0; i < cantidadOperadores; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Operador #" + (i + 1));
                    Console.WriteLine("--------------------------------");

                    Console.WriteLine("Código: " + codigos[i]);
                    Console.WriteLine("Nombre: " + nombres[i]);
                    Console.WriteLine("Edad: " + edades[i]);
                    Console.WriteLine("Nivel: " + niveles[i]);

                    if (credenciales[i])
                    {
                        Console.WriteLine("Credencial: ACTIVA");
                    }
                    else
                    {
                        Console.WriteLine("Credencial: INACTIVA");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

            break;


        // =========================================
        // 3. SIMULAR ACCESO
        // =========================================
        case 3:

            Console.Clear();

            Console.WriteLine("========== SIMULACIÓN DE ACCESO ==========");

            if (cantidadOperadores == 0)
            {
                Console.WriteLine("No existen operadores registrados.");
                Console.ReadKey();
                break;
            }

            Console.Write("Ingrese el código del operador: ");

            string codigoBuscar =
                (Console.ReadLine() ?? "").Trim().ToUpper();

            int posicion = -1;

            for (int i = 0; i < cantidadOperadores; i++)
            {
                if (codigos[i].ToUpper() == codigoBuscar)
                {
                    posicion = i;
                    break;
                }
            }

            if (posicion == -1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Operador no encontrado.");
                Console.ResetColor();
            }
            else
            {
                bool acceso =
                    edades[posicion] >= 18 &&
                    niveles[posicion] >= 3 &&
                    credenciales[posicion];

                Console.WriteLine();
                Console.WriteLine("Operador: "
                    + nombres[posicion]);

                if (acceso)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ACCESO AUTORIZADO");
                    Console.ResetColor();

                    accesosAutorizados++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ACCESO DENEGADO");
                    Console.ResetColor();

                    accesosDenegados++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

            break;


        // =========================================
        // 4. CÓDIGO DE SEGURIDAD
        // =========================================
        case 4:

            Console.Clear();

            Console.WriteLine("========== CÓDIGO DE SEGURIDAD ==========");

            int codigoSeguridad = random.Next(100000, 1000000);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Código generado: " + codigoSeguridad);
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

            break;


        // =========================================
        // 5. ESTADÍSTICAS
        // =========================================
        case 5:

            Console.Clear();

            int sumaEdades = 0;
            int operadoresMayores = 0;
            int operadoresNivelAlto = 0;
            int credencialesActivas = 0;

            for (int i = 0; i < cantidadOperadores; i++)
            {
                sumaEdades += edades[i];

                if (edades[i] >= 18)
                {
                    operadoresMayores++;
                }

                if (niveles[i] >= 3)
                {
                    operadoresNivelAlto++;
                }

                if (credenciales[i])
                {
                    credencialesActivas++;
                }
            }

            double edadPromedio = 0;

            if (cantidadOperadores > 0)
            {
                edadPromedio =
                    (double)sumaEdades / cantidadOperadores;
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("========== ESTADÍSTICAS ==========");
            Console.ResetColor();

            Console.WriteLine("Total de operadores: "
                + cantidadOperadores);

            Console.WriteLine("Edad promedio: "
                + Math.Round(edadPromedio, 2));

            Console.WriteLine("Mayores de edad: "
                + operadoresMayores);

            Console.WriteLine("Nivel de seguridad >= 3: "
                + operadoresNivelAlto);

            Console.WriteLine("Credenciales activas: "
                + credencialesActivas);

            Console.WriteLine("Accesos autorizados: "
                + accesosAutorizados);

            Console.WriteLine("Accesos denegados: "
                + accesosDenegados);

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

            break;


        // =========================================
        // 6. FECHA Y HORA
        // =========================================
        case 6:

            Console.Clear();

            DateTime ahora = DateTime.Now;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========== FECHA Y HORA ==========");
            Console.ResetColor();

            Console.WriteLine(
                "Fecha: " + ahora.ToString("dd/MM/yyyy"));

            Console.WriteLine(
                "Hora: " + ahora.ToString("HH:mm:ss"));

            Console.WriteLine(
                "Fecha y hora: "
                + ahora.ToString("dd/MM/yyyy HH:mm:ss"));

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

            break;


        // =========================================
        // 7. SALIR
        // =========================================
        case 7:

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==========================================");
            Console.WriteLine("       OPERACIÓN CÓDIGO ROJO");
            Console.WriteLine("==========================================");
            Console.WriteLine("Sistema finalizado correctamente.");
            Console.ResetColor();

            break;


        default:

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("OPCIÓN NO VÁLIDA");
            Console.ResetColor();

            Console.ReadKey();

            break;
    }

} while (opcion != 7);

Console.ResetColor();