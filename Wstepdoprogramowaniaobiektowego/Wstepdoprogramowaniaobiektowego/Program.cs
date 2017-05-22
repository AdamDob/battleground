using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wstepdoprogramowaniaobiektowego
{
    class Silnia1
    {
        static void Wielkie(string [] tab)
        {
           for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = tab[i].ToUpper();
            }
        }
       
           
      static void Main(string[] args)
       {
            string[] tab1 = { "jeden", "dwa", "trzy" };
            Wielkie(tab1);
            for(int i = 0; i < tab1.Length; i++)
            {
                Console.Write(tab1[i] + " ");
            }
            Console.ReadKey();
       }

    }
    
    }

/*
 *  public void czytaj_dane(double[] macierz, int rozmiar)
            {
            int i;
            Console.WriteLine("Nieposortowane liczby to: ");
            for(i = 0; i < rozmiar; i++)
            {
                if (i < rozmiar - 1)
                    Console.Write(macierz[i] + ". ");
                else
                    Console.Write(macierz[i] + ". ");
            }
            
            }
            public void przetworz_dane(double[] macierz, int rozmiar)
            {
            int i, j;
            double x;
            for(i = 1; i<= rozmiar; i++)
            {
                for(j = rozmiar - 1; j >= i; j--)
                {
                    if(macierz[j - 1] > macierz[j])
                    {
                        x = macierz[j - 1];
                        macierz[j - 1] = macierz[j];
                        macierz[j] = x;

                    }
                }
            }

            }
            public void wyswietl_dane(double[] macierz, int rozmiar)
            {
            int i;
            Console.WriteLine();
            Console.WriteLine("Liczby posortowane to: ");

            for(i = 0; i < rozmiar; i++)
            {
                if (i < rozmiar - 1)
                    Console.Write(macierz[i] + ". ");
                else
                    Console.Write(macierz[i] + ". ");
            }
            Console.WriteLine();
            }
            static void Main(string[] args)
            {
            int n = 6;
            double[] liczby = new double[n];
            liczby[0] = 57;
            liczby[1] = -1026;
            liczby[2] = 303;
            liczby[3] = 8;
            liczby[4] = 20;
            liczby[5] = 34;

            Trojmian sortowanie = new Trojmian();
            sortowanie.czytaj_dane(liczby, n);
            sortowanie.przetworz_dane(liczby, n);
            sortowanie.wyswietl_dane(liczby, n);
 */
/* SILNIA
 *  public long silnia(int liczba)
       {
           long zwrot = 1;
           if(liczba >= 2)
           {
               zwrot = liczba * silnia(liczba - 1);
           }
           return zwrot;
       }


           static void Main(string[] args)
           {
           int i, n;

           Silnia1 sil = new Silnia1();
           Console.WriteLine("Podaj n");
           n = int.Parse(Console.ReadLine());

           for(i = 1; i <= n; i++)
           {
               Console.WriteLine(" " + i + "! = " + sil.silnia(i));
           }
           Console.ReadLine();
           */