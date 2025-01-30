## Firmas de funciones

```c#
   // 1. Función sin parámetros ni retorno
    static void Saludar()
    {
        Console.WriteLine("Hola, mundo!");
    }

    // 2. Función con un parámetro y sin retorno
    static void SaludarPersona(string nombre)
    {
        Console.WriteLine($"Hola, {nombre}!");
    }

    // 3. Función con retorno sin parámetros
    static int ObtenerNumero()
    {
        return 42;
    }

    // 4. Función con parámetros y retorno
    static int Sumar(int a, int b)
    {
        return a + b;
    }

    // 5. Función con lista como parámetro
    static void MostrarLista(List<string> nombres)
    {
        foreach (var nombre in nombres)
        {
            Console.WriteLine(nombre);
        }
    }

    // 6. Función que retorna una lista
    static List<int> GenerarNumeros(int cantidad)
    {
        List<int> numeros = new List<int>();
        for (int i = 0; i < cantidad; i++)
        {
            numeros.Add(i * 2);
        }
        return numeros;
    }

    // 7. Función con matriz como parámetro
    static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // 8. Función que retorna una matriz
    static int[,] CrearMatriz(int filas, int columnas)
    {
        int[,] matriz = new int[filas, columnas];
        for (int i = 0; i < filas; i++)
            for (int j = 0; j < columnas; j++)
                matriz[i, j] = i + j;
        return matriz;
    }

    // 9. Función con un objeto como parámetro
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    static void MostrarPersona(Persona p)
    {
        Console.WriteLine($"Nombre: {p.Nombre}, Edad: {p.Edad}");
    }

    // 10. Función que retorna un objeto
    static Persona CrearPersona(string nombre, int edad)
    {
        return new Persona { Nombre = nombre, Edad = edad };
    }

    // 11. Función con params (cantidad variable de argumentos)
    static void SumarTodos(params int[] numeros)
    {
        int suma = 0;
        foreach (int num in numeros)
            suma += num;
        Console.WriteLine("Suma: " + suma);
    }

    // 12. Función con delegados
    delegate int Operacion(int x, int y);
    static int Multiplicar(int x, int y) => x * y;

    // 13. Función genérica
    static T Duplicar<T>(T valor)
    {
        return valor;
    }

    // 14. Función lambda como parámetro
    static void EjecutarOperacion(Func<int, int, int> operacion, int a, int b)
    {
        Console.WriteLine("Resultado: " + operacion(a, b));
    }

    // 15. Función asíncrona
    static async Task Esperar()
    {
        await Task.Delay(1000);
        Console.WriteLine("Esperé 1 segundo.");
    }

    // 16. Función con excepción
    static void LanzarExcepcion()
    {
        throw new Exception("Error de prueba");
    }

    // 17. Función con sobrecarga
    static int Multiplicar(int a, int b) => a * b;
    static double Multiplicar(double a, double b) => a * b;

    // 18. Función local dentro de otra función
    static void FuncionExterna()
    {
        void FuncionInterna()
        {
            Console.WriteLine("Soy una función dentro de otra.");
        }
        FuncionInterna();
    }

    // 19. Función que retorna una tupla
    static (int, string) RetornarTupla()
    {
        return (1, "Hola");
    }

    // 20. Función recursiva
    static int Factorial(int n)
    {
        if (n <= 1) return 1;
        return n * Factorial(n - 1);
    }

    static void Main()
    {
        // Invocaciones
        Saludar();
        SaludarPersona("Carlos");
        Console.WriteLine(ObtenerNumero());
        Console.WriteLine(Sumar(5, 3));
        MostrarLista(new List<string> { "Ana", "Luis", "Maria" });
        ImprimirMatriz(CrearMatriz(3, 3));
        Persona p = CrearPersona("Juan", 25);
        MostrarPersona(p);
        SumarTodos(1, 2, 3, 4, 5);
        Console.WriteLine(Duplicar(10));
        EjecutarOperacion((x, y) => x + y, 4, 5);
        _ = Esperar();
        (int num, string texto) = RetornarTupla();
        Console.WriteLine($"Tupla: {num}, {texto}");
        Console.WriteLine("Factorial de 5: " + Factorial(5));
    }
```

### ¿Qué hace cada una?
