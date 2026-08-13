DateTime ahora = DateTime.Now;

Console.WriteLine("===== RELOJ DEL SISTEMA =====");
Console.WriteLine("Fecha y hora actual: " + ahora);
Console.WriteLine("Día: " + ahora.Day);
Console.WriteLine("Mes: " + ahora.Month);
Console.WriteLine("Año: " + ahora.Year);

Console.Write("\nIngrese su fecha de nacimiento (dd/MM/yyyy): ");

if (DateTime.TryParse(Console.ReadLine(), out DateTime fechaNacimiento))
{
    if (fechaNacimiento <= ahora)
    {
        int edad = ahora.Year - fechaNacimiento.Year;

        if (fechaNacimiento.Date > ahora.AddYears(-edad).Date)
        {
            edad--;
        }

        Console.WriteLine("Edad: " + edad + " años");
    }
    else
    {
        Console.WriteLine("Error: la fecha de nacimiento no puede ser futura.");
    }
}
else
{
    Console.WriteLine("Error: ingrese una fecha válida.");
}