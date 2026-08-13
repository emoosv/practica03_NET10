Console.Write("Ingrese el primer número: ");

if (double.TryParse(Console.ReadLine(), out double numero1))
{
    Console.Write("Ingrese el segundo número: ");

    if (double.TryParse(Console.ReadLine(), out double numero2))
    {
        Console.WriteLine("\n===== SIMULADOR MATEMÁTICO =====");

        // Potencia
        Console.WriteLine("Potencia: " + Math.Pow(numero1, numero2));

        // Raíz cuadrada
        if (numero1 >= 0)
        {
            Console.WriteLine("Raíz cuadrada del primer número: " +
                              Math.Sqrt(numero1));
        }
        else
        {
            Console.WriteLine("Raíz cuadrada del primer número: no existe en números reales.");
        }

        if (numero2 >= 0)
        {
            Console.WriteLine("Raíz cuadrada del segundo número: " +
                              Math.Sqrt(numero2));
        }
        else
        {
            Console.WriteLine("Raíz cuadrada del segundo número: no existe en números reales.");
        }

        // Valor absoluto
        Console.WriteLine("Valor absoluto del primer número: " +
                          Math.Abs(numero1));

        Console.WriteLine("Valor absoluto del segundo número: " +
                          Math.Abs(numero2));

        // Redondeo
        Console.WriteLine("Redondeo del primer número: " +
                          Math.Round(numero1));

        Console.WriteLine("Redondeo del segundo número: " +
                          Math.Round(numero2));

        // Mayor y menor
        Console.WriteLine("Número mayor: " +
                          Math.Max(numero1, numero2));

        Console.WriteLine("Número menor: " +
                          Math.Min(numero1, numero2));
    }
    else
    {
        Console.WriteLine("Error: el segundo número no es válido.");
    }
}
else
{
    Console.WriteLine("Error: el primer número no es válido.");
}