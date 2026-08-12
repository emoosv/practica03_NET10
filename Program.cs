int opcion;

do
{
    Console.WriteLine("\n===== MENÚ PRINCIPAL =====");
    Console.WriteLine("1. Consultar estado");
    Console.WriteLine("2. Mostrar temperatura");
    Console.WriteLine("3. Mostrar operadores");
    Console.WriteLine("4. Reiniciar sistema");
    Console.WriteLine("5. Salir");
    Console.Write("Seleccione una opción: ");

    if (int.TryParse(Console.ReadLine(), out opcion))
    {
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Estado del sistema: OPERATIVO");
                break;

            case 2:
                Console.WriteLine("Temperatura: 25 °C");
                break;

            case 3:
                Console.WriteLine("Operadores registrados: 3");
                break;

            case 4:
                Console.WriteLine("Sistema reiniciado correctamente.");
                break;

            case 5:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("SALIR");
                Console.ResetColor();
                break;

            default:
                Console.WriteLine("OPCIÓN NO VÁLIDA");
                break;
        }
    }
    else
    {
        opcion = 0;
        Console.WriteLine("OPCIÓN NO VÁLIDA");
    }

} while (opcion != 5);