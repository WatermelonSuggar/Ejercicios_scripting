# Ejercicios_scripting
Códigos de ejercicios de scripting

**Ejercicio 1**

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciotaller1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declarar matriz 
            int[,] matriz = {
                { 2, 3, 1, 5, 0, 3 },
                { 1, 2, 1, 2, 6, 6 },
                { 4, 6, 9, 3, 1, 5 },
                { 2, 8, 4, 4, 2, 1 },
                { 7, 1, 2, 6, 7, 3 }
            };

            // Llamar a la función para calcular los promedios
            calcularPromedio(matriz);

            // Pausar la consola para ver el resultado
            Console.ReadLine();
        }

        // Declaramos la función que va a calcular el promedio 
        static void calcularPromedio(int[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            Console.WriteLine("El promedio de cada fila es:");

            for (int i = 0; i < filas; i++)
            {
                int sumaFila = 0;

                for (int j = 0; j < columnas; j++)
                {
                    sumaFila += matriz[i, j];
                }

                double promedioFila = (double)sumaFila / columnas;
                Console.WriteLine($"Fila {i + 1}: {promedioFila:F2}");
            }

            Console.WriteLine("\nEl promedio de cada columna es:");

            for (int j = 0; j < columnas; j++)
            {
                int sumaColumna = 0;

                for (int i = 0; i < filas; i++)
                {
                    sumaColumna += matriz[i, j];
                }

                double promedioColumna = (double)sumaColumna / filas;
                Console.WriteLine($"Columna {j + 1}: {promedioColumna:F2}");
            }

        }
    }
}



```
