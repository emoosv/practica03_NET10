Console.Write("Ingrese su edad: ");

if (int.TryParse(Console.ReadLine(), out int edad))
{
    if (edad >= 0)
    {
        Console.WriteLine("Edad registrada: " + edad);
    }
    else
    {
        Console.WriteLine("Error: la edad no puede ser negativa.");
    }
}
else
{
    Console.WriteLine("Error: la edad debe ser un número.");
}

Console.Write("\nIngrese su salario: ");

try
{
    double salario = double.Parse(Console.ReadLine()!);

    if (salario >= 0)
    {
        Console.WriteLine("Salario registrado: $" + salario);
    }
    else
    {
        Console.WriteLine("Error: el salario no puede ser negativo.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: el salario debe ser un número válido.");
}

Console.Write("\nIngrese su año de nacimiento: ");

if (int.TryParse(Console.ReadLine(), out int añoNacimiento))
{
    if (añoNacimiento > 0)
    {
        Console.WriteLine("Año de nacimiento registrado: " + añoNacimiento);
    }
    else
    {
        Console.WriteLine("Error: el año debe ser válido.");
    }
}
else
{
    Console.WriteLine("Error: el año de nacimiento debe ser un número.");
}