using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczeniazpowtorzeniem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100, suma_p = 0, suma_np=0 ;
            int[] tab = new int[n];
            for(int i = 0; i < n ; i++)
            {
                
                tab[i] = i + 1;
            }
            foreach(int x in tab)
            {
                if((x%2)==0)
                    suma_p += x;
                else
                    suma_np += x;
            }
            Console.WriteLine("suma liczb parzystcyh = " + suma_p);
            Console.WriteLine("suma liczb nieparzystych = " + suma_np);

            Console.ReadLine();
                
            
        }
    }
}
/*
 tablice 2-wymiarowe obliczanie pierwszej i 2 kolumny podniesionej do kwadratu
 int n = 10 , i ;
            int suma,j;
            int[,] tab = new int[n, n];
            for(i = 0; i < n; i++ )
            {
                for(j = 0; j < n; j++)
                {
                    if (j == 0) tab[i, j] = i;
                    
                    if (j == 1) tab[i, j] = i * i;
                    if (j > 1) tab[i, j] = 0;
                }
                
            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(tab[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            suma = 0;
            for (i = 0; i < n; i++)
            {

                suma = suma + tab[i,0];
            }
            Console.WriteLine("SUMA pierwszej kolumny =" + suma);
            suma = 0;
            for (i = 0; i < n; i++)
            {

                suma = suma + tab[i, 1];
            }
            Console.WriteLine("SUMA drugiej kolumny =" + suma);
 */
/*
            * Program przepisywania wartosci z tablicy a do tablicy b

           int n = 10, i, j;
           int[,] a = new int[n, n];
           int[,] b = new int[n, n];

           for(i = 0; i<n; i++)
           {
               for(j = 0; j < n; j++)
               {
                   a[i, j] = j;
               }
           }
           for (i = 0; i < n; i++)
           {
               for (j = 0; j < n; j++)
               {
                   b[i, j] = a[j,i];
               }
           }

           Console.WriteLine();
           for (i = 0; i < n; i++)
           {
               for (j = 0; j < n; j++)
               {
                   Console.Write(a[i, j] + " ");
               }
               Console.WriteLine();

               for (i = 0; i < n; i++)
               {
                   for (j = 0; j < n; j++)
                   {
                       Console.Write(b[i, j] + " ");
                   }
                   Console.WriteLine();
                   */
