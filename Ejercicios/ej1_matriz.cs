using System;
using System.Numerics;
using System.Security.Claims;
class Matriz
{
    static void Main()
    {

        int[,] matriz = new int[3, 3];
        matriz[0, 0] = -1; matriz[0, 1] = 2; matriz[0, 2] = -3;
        matriz[1, 0] = -6; matriz[1, 1] = -8; matriz[1, 2] = 9;
        matriz[2, 0] = -3; matriz[2, 2] = 4; matriz[1, 0] = -5;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matriz[i,j] = Math.Abs(matriz[i,j]);
                Console.WriteLine(matriz[i,j] + " ");
            }
            Console.WriteLine();
        }

    }
}
