Console.Write("Ingrese su nombre completo: ");
string? nombre = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(nombre))
{
    // Elimina espacios al inicio y al final
    nombre = nombre.Trim();

    // Elimina espacios innecesarios entre las palabras
    while (nombre.Contains("  "))
    {
        nombre = nombre.Replace("  ", " ");
    }

    Console.WriteLine("\nNombre limpio: " + nombre);
    Console.WriteLine("Cantidad de caracteres: " + nombre.Length);
    Console.WriteLine("Mayúsculas: " + nombre.ToUpper());
    Console.WriteLine("Minúsculas: " + nombre.ToLower());
}
else
{
    Console.WriteLine("Error: debe ingresar un nombre.");
}