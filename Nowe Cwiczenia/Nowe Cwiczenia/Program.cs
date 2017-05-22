using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nowe_Cwiczenia
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10, i, j, k = 0, suma = 0; ;
            int[,] macierz = new int[n, n];

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (n == i + j + 1)
                        macierz[i, j] = k++;
                    else
                        macierz[i, j] = 0;
                }
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (j = 0; j < n; j++)
                {
                    Console.Write(macierz[i, j] + " ");
                }
            }
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                suma = suma + macierz[i, i];

            }
            Console.WriteLine("suma przekatych = " + suma);

            Console.ReadKey(); 
        }
    }
}
/*
 *  int n = 10,i,j,k=0, suma = 0; ;
            int[,] macierz = new int[n, n];

            for(i = 0; i < n; i++)
            {
                for(j = 0; j < n; j++)
                {
                    if (i == j)
                        macierz[i, j] =k++;
                    else
                        macierz[i, j] = 0;
                }
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (j = 0; j < n; j++)
                {
                    Console.Write(macierz[i, j] + " " );
                }
            }
            Console.WriteLine();
            for(i = 0; i < n; i++)
            {
                suma = suma + macierz[i, i];
               
            }
            Console.WriteLine("suma przekatych = "+ suma);

    */