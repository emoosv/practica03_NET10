Console.Write("Ingrese el nivel de alerta (0-10): ");

if (int.TryParse(Console.ReadLine(), out int nivel))
{
    if (nivel == 0)
    {
        Console.WriteLine("NORMAL");
    }
    else if (nivel >= 1 && nivel <= 3)
    {
        Console.WriteLine("ADVERTENCIA");
    }
    else if (nivel >= 4 && nivel <= 6)
    {
        Console.WriteLine("PELIGRO");
    }
    else if (nivel >= 7 && nivel <= 9)
    {
        Console.WriteLine("CRÍTICO");
    }
    else if (nivel == 10)
    {
        Console.WriteLine("EMERGENCIA");
    }
    else
    {
        Console.WriteLine("NIVEL DE ALERTA INVÁLIDO");
    }
}
else
{
    Console.WriteLine("NIVEL DE ALERTA INVÁLIDO");
}