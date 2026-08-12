Console.WriteLine("================================");
Console.WriteLine("        NIVEL DE ACCESO");
Console.WriteLine("================================");

int edad;

Console.Write("Ingrese la edad del operador: ");

while (!int.TryParse(Console.ReadLine(), out edad) || edad < 0)
{
    Console.Write("Edad inválida. Ingrese una edad válida: ");
}

if (edad >= 18)
{
    Console.WriteLine("Acceso permitido");
}
else
{
    Console.WriteLine("Acceso restringido");
}