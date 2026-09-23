static void ImprimirArreglo(int[] notas)
{
    for (int i = 0; i < notas.Length; i++)
    {
        Console.WriteLine($"Nota {i+1}: {notas[i]}");
    }
}

static void PromedioArreglo(int[] notas)
{
    int suma = notas.Sum();
    Console.WriteLine($"Promedio de las notas: {(double)suma/notas.Length:F2}");
}

static void MaxArreglo(int[] notas)
{
    int max = notas[0];
    for (int i=1; i < notas.Length; i++)
    {
        if (notas[i]>max)
        {
            max = notas[i];
        }
    }
    System.Console.WriteLine($"La nota máxima es: {max}");
}

static void MinArreglo(int[] notas)
{
    int min = notas[0];
    for (int i=1; i < notas.Length; i++)
    {
        if (notas[i]<min)
        {
            min = notas[i];
        }
    }
    System.Console.WriteLine($"La nota mínima es: {min}");
}

int[] notas = {15, 18, 12, 17, 20};

ImprimirArreglo(notas);
PromedioArreglo(notas);
MaxArreglo(notas);
MinArreglo(notas);