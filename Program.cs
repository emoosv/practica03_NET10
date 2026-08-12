string[] codigos =
{
    "A123",
    "B456",
    "ERROR",
    "C789",
    "D321",
    "EXIT",
    "E654"
};

Console.WriteLine("Procesando códigos:");

foreach (string codigo in codigos)
{
    if (codigo == "ERROR")
    {
        continue;
    }

    if (codigo == "EXIT")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("EXIT");
        Console.ResetColor();

        break;
    }

    Console.WriteLine($"Código procesado: {codigo}");
}

Console.WriteLine("Procesamiento finalizado.");