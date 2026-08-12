string usuarioCorrecto = "admin";
string contraseñaCorrecta = "1234";

int intentos = 0;
const int maxIntentos = 3;

while (intentos < maxIntentos)
{
    Console.Write("Ingrese el usuario: ");
    string? usuario = Console.ReadLine();

    Console.Write("Ingrese la contraseña: ");
    string? contraseña = Console.ReadLine();

    if (usuario == usuarioCorrecto && contraseña == contraseñaCorrecta)
    {
        Console.WriteLine("Inicio de sesión exitoso.");
        break;
    }
    else
    {
        intentos++;

        int intentosRestantes = maxIntentos - intentos;

        if (intentosRestantes > 0)
        {
            Console.WriteLine($"Usuario o contraseña incorrectos.");
            Console.WriteLine($"Intentos restantes: {intentosRestantes}");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("SISTEMA BLOQUEADO");
            Console.ResetColor();
        }
    }
}