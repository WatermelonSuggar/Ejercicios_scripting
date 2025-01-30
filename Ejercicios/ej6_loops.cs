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
            Console.WriteLine("Escoja el número de numeros impares a sumar: ");
            int sumNums = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sumNums);

            int n = 1;
            int Suma = 0;
            int count = 0;
            
           do
           {
              Suma += n;
              n += 2;
              count++;
           }
           while (count <  sumNums);
           Console.WriteLine("Total de la suma de los primeros " + sumNums + " números impares: " + Suma);
        }
        


    }
}
