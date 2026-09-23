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

int[] notas = {15, 18, 12, 17, 20};
ImprimirArreglo(notas);
PromedioArreglo(notas);