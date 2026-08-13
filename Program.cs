Random random = new Random();

Console.Write("¿Cuántos códigos de seguridad desea generar? ");

if (int.TryParse(Console.ReadLine(), out int cantidad))
{
    if (cantidad > 0)
    {
        Console.WriteLine("\n===== CÓDIGOS DE SEGURIDAD =====");

        for (int i = 1; i <= cantidad; i++)
        {
            int codigo = random.Next(100000, 1000000);

            Console.WriteLine($"Código {i}: {codigo}");
        }
    }
    else
    {
        Console.WriteLine("Error: la cantidad debe ser mayor que 0.");
    }
}
else
{
    Console.WriteLine("Error: debe ingresar una cantidad válida.");
}