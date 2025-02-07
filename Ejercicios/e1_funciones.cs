using System;

class Program
{
    static void Main()
    {
        int[,] matriz = {
            { 2, 3, 1, 5, 0, 3 },
            { 1, 2, 1, 2, 6, 6 },
            { 4, 6, 9, 3, 1, 5 },
            { 2, 8, 4, 4, 2, 1 },
            { 7, 1, 2, 6, 7, 3 }
        };

        CalcularPromedios(matriz);
        Console.ReadLine();
    }

    static void CalcularPromedios(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        double[] sumaColumnas = new double[columnas];

        Console.WriteLine("El promedio de cada fila es:");

        for (int i = 0; i < filas; i++)
        {
            double sumaFila = 0;

            for (int j = 0; j < columnas; j++)
            {
                sumaFila += matriz[i, j];
                sumaColumnas[j] += matriz[i, j];
            }

            Console.WriteLine($"Fila {i + 1}: {sumaFila / columnas:F2}");
        }

        Console.WriteLine("\nEl promedio de cada columna es:");

        for (int j = 0; j < columnas; j++)
        {
            Console.WriteLine($"Columna {j + 1}: {sumaColumnas[j] / filas:F2}");
        }
    }
}
