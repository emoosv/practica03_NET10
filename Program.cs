Console.Write("Ingrese el número para la tabla: ");

if (int.TryParse(Console.ReadLine(), out int numero))
{
    Console.Write("Ingrese el multiplicador inicial: ");

    if (int.TryParse(Console.ReadLine(), out int inicio))
    {
        Console.Write("Ingrese el multiplicador final: ");

        if (int.TryParse(Console.ReadLine(), out int fin))
        {
            if (inicio <= fin)
            {
                Console.WriteLine($"\nTabla del {numero}:");

                for (int multiplicador = inicio; multiplicador <= fin; multiplicador++)
                {
                    int resultado = numero * multiplicador;
                    Console.WriteLine($"{numero} x {multiplicador} = {resultado}");
                }
            }
            else
            {
                Console.WriteLine("Error: el inicio no puede ser mayor que el fin.");
            }
        }
        else
        {
            Console.WriteLine("Error: el multiplicador final debe ser un número.");
        }
    }
    else
    {
        Console.WriteLine("Error: el multiplicador inicial debe ser un número.");
    }
}
else
{
    Console.WriteLine("Error: el número debe ser válido.");
}