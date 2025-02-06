using System;

namespace Taller_1
{
    class Ej2
    {
        static void Main()
        {
            Console.WriteLine("Escoja el número de números impares a sumar: ");
            

            int sumNums;
            while (!int.TryParse(Console.ReadLine(), out sumNums) || sumNums <= 0)
            {
                Console.WriteLine("Ingrese un número entero positivo válido:");
            }

            int n = 1;
            int suma = 0;
            int count = 0;
            
            do
            {
                suma += n;
                n += 2;
                count++;
            }
            while (count < sumNums);
            
            Console.WriteLine($"Total de la suma de los primeros {sumNums} números impares: {suma}");
        }
    }
}

//  out sumNums -> Esta expresión le permite al método TryParse asignarle un valor 'sumNums'. La expresión 'out' se asegura de que una variable no quede sin inicializar
