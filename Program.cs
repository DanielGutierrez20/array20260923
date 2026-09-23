

static void ImprimirArreglo(int[] notas)
{
    for (int i = 0; i < notas.Length; i++)
    {
        Console.WriteLine($"Nota {i+1}: {notas[i]}");
    }
}

static void SumarArreglo(int[] notas)
{
    int suma = notas.Sum();
    Console.WriteLine($"Suma de las notas: {suma}");
}

int[] notas = {15, 18, 12, 17, 20};
ImprimirArreglo(notas);
SumarArreglo(notas);

//int[] notas2 = {2, 4, 9};
//ImprimirArreglo(notas2);