Console.WriteLine("======================================");
Console.WriteLine("        SISTEMA DE AUTORIZACIÓN");
Console.WriteLine("======================================");

Console.Write("Ingrese la edad del operador: ");
bool edadValida = int.TryParse(Console.ReadLine(), out int edad);

Console.Write("Ingrese el nivel de seguridad (1-5): ");
bool nivelValido = int.TryParse(Console.ReadLine(), out int nivel);

Console.Write("¿La credencial está activa? (si/no): ");
string respuesta = Console.ReadLine() ?? "";

bool credencialActiva = respuesta.Trim().ToLower() == "si";

if (edadValida && edad >= 0 && nivelValido && nivel >= 1 && nivel <= 5)
{
    if (edad >= 18 && nivel >= 3 && credencialActiva)
    {
        Console.WriteLine("Acceso autorizado");
    }
    else
    {
        Console.WriteLine("Acceso denegado");
    }
}
else
{
    Console.WriteLine("Error: ingrese valores válidos.");
}