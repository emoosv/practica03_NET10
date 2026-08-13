Console.WriteLine("===== CONSOLA DE CONTROL =====\n");

// Estado operativo
Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("OPERATIVO: Sistema funcionando correctamente.");
Console.ResetColor();

// Estado de advertencia
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("ADVERTENCIA: Se detectó una situación que requiere atención.");
Console.ResetColor();

// Estado de error
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("ERROR: Se produjo un problema en el sistema.");
Console.ResetColor();

// Estado de información
Console.ForegroundColor = ConsoleColor.Cyan;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("INFORMACIÓN: Sistema actualizado correctamente.");
Console.ResetColor();

Console.WriteLine("\nControl finalizado.");