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
