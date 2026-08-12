string[] operadores =
{
    "Carlos",
    "Ana",
    "Miguel",
    "Luis",
    "Sofia",
    "Daniel",
    "Jose"
};

Console.WriteLine("Operadores con más de cuatro caracteres:");

foreach (string nombre in operadores)
{
    if (nombre.Length > 4)
    {
        Console.WriteLine(nombre);
    }
}