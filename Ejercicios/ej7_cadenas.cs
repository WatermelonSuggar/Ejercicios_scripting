using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_1
{
    class Ej2
    {
        static void Main()
        {
            Console.WriteLine("Ingrese una cadena de números: ");
            string cadena = Console.ReadLine();

            if (!cadena.All(char.IsDigit))
            {
                Console.WriteLine("La cadena contiene caracteres diferentes a números");
            }
            else if (cadena.All(char.IsDigit))
            {
                int[] numbers = cadena.Select(numero => numero - '0').ToArray(); //Le resta al número el valor ASCII de 0 para obtener el valor real.
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
