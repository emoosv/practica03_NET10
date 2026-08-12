Console.WriteLine("======================================");
Console.WriteLine("       CALCULADORA DE RECURSOS");
Console.WriteLine("======================================");

int trabajadores;
double horas;
double consumoPorHora;

Console.Write("Ingrese la cantidad de trabajadores: ");
while (!int.TryParse(Console.ReadLine(), out trabajadores) || trabajadores <= 0)
{
    Console.Write("Dato inválido. Ingrese una cantidad válida: ");
}

Console.Write("Ingrese las horas trabajadas: ");
while (!double.TryParse(Console.ReadLine(), out horas) || horas <= 0)
{
    Console.Write("Dato inválido. Ingrese una cantidad válida: ");
}

Console.Write("Ingrese el consumo por hora: ");
while (!double.TryParse(Console.ReadLine(), out consumoPorHora) || consumoPorHora <= 0)
{
    Console.Write("Dato inválido. Ingrese una cantidad válida: ");
}

double consumoTotal = trabajadores * horas * consumoPorHora;

Console.WriteLine();
Console.WriteLine("========== REPORTE ==========");
Console.WriteLine("Trabajadores: " + trabajadores);
Console.WriteLine("Horas trabajadas: " + horas);
Console.WriteLine("Consumo por hora: " + consumoPorHora);
Console.WriteLine("Consumo total: " + consumoTotal);
Console.WriteLine("=============================");