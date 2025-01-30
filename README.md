# Ejercicios_scripting
Códigos de ejercicios de scripting

### USO DE FUNCIONES

**Ejercicio 1:** Realice una función que lea una matriz de números enteros de NxM y calcule el promedio de cada fila y cada columna. 

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

**Ejercicio 2:** Realice una función, que lea un número de máximo 8 cifras y luego sume cada dígito hasta obtener un valor de un solo dígito.

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número de hasta 8 cifras: ");
            string input = Console.ReadLine();

            if (long.TryParse(input, out long numero) && numero >= 0 && numero <= 99999999)
            {
                int resultado = SumarDigitosHastaUno(numero);
                Console.WriteLine($"El resultado final es: {resultado}");
            }
            else
            {
                Console.WriteLine("Número inválido. Debe ser un número positivo de hasta 8 cifras.");
            }
        }

        static int SumarDigitosHastaUno(long numero)
        {
            while (numero >= 10)  // Mientras el número tenga más de un dígito
            {
                int suma = 0;
                while (numero > 0)
                {
                    suma += (int)(numero % 10); // Extrae el último dígito y lo suma
                    numero /= 10; // Elimina el último dígito
                }
                numero = suma; // Actualiza el número con la nueva suma
            }
            return (int)numero; // Devuelve el resultado final
        }
    }
}

```

**PREGUNTAS TEÓRICAS**
> ¿De qué tipo es el resultado al sumar 12 bytes, 3 ints, 6 floats y 3 doubles?

* Cuando se suman diferentes tipos de datos, C# convierte los valores al tipo de mayor precisión, que en este caso es double.

> ¿Cuál es la diferencia entre la longitud de un array y la de una cadena?

* Array: Su longitud se obtiene con .Length, que devuelve el número total de elementos.
* Cadena (string): Su longitud se obtiene con .Length, que devuelve el número de caracteres en la cadena.

```C#
int[] numeros = {1, 2, 3, 4};
Console.WriteLine(numeros.Length); // 4

string texto = "Wendy";
Console.WriteLine(texto.Length); // 5
```

> Usando un ciclo do-while imprima los número impares desde 10000 hasta -10000

```c#
static void Main()
{
    int NumInicial = 9999;
    do
    {
        Console.WriteLine(NumInicial);
        NumInicial--;
    }
    while (NumInicial > -10000);
}
```


