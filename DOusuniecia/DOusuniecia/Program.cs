using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOusuniecia
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ************************************************
             * ZADANIA DO SAMODZIELNEGO ROZWIAZANIA 4.3 !!!!!!!!!!!!! */
            //4.1
            /*
            Console.WriteLine("Podaj ile elementow ma tablica");
            int element = int.Parse(Console.ReadLine());
            int[] tab = new int[element];
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Podaj elementy tablicy {0}",i+1);
                tab[i] = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("Wypisuje talbice :D");
            for(int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
              */

            //4.2
            /*
            int[] tab = { -5, 5, -6, 12, 34, 54, 12, -54, 56, 98 };
            int[] tab2 = new int[10];
            Array.Copy(tab, 0, tab2, 1, 9);
           
            
                foreach (int x in tab2)
                {
                    if(x > 0)
                    Console.Write(x + " ");
                }
          
            */
            //4.3
            /*
            Console.WriteLine("Podaj ilosc elementow tablicy ");
            int elementy = int.Parse(Console.ReadLine());
            int[] tab = new int[elementy];
            int max = tab[0];
            int min = tab[0];
            int srednia = 0;
            for(int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("element tab {0} ", i + 1);
                tab[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("element {0} = {1}",i, tab[i]);
                for(int j = 1; j < tab.Length; j++)
                {
                    if (tab[j] > max)
                        max = tab[j];
                    if (tab[j] < min)
                        min = tab[j];
                    srednia += tab[i]/tab.Length;
                } 
            }
            Console.WriteLine("najwieksza liczba jest {0}", max);
            Console.WriteLine("najmniejsza liczba jest {0}", min);
            Console.WriteLine("Srednia " + srednia);
            */

            //ZADANIE 4.4
            /*
            int[] tab = new int[10];
            
            Random rand = new Random();
            
            for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = rand.Next(1, 100);
                Console.WriteLine("nr tablicy {0}",i + " = " +  tab[i]);
            }
           */
            //ZADANIE4.5
            int[] tab1 ={ 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] tab2 = new int[9];
            
            Array.Copy(tab1, 0, tab2, 0, 8);
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.Write(tab1[i] + " ");
            }
            Console.WriteLine();

            foreach (int x in tab2)
            {
                Console.Write(x +  " " );
            }


            //Tekst jako tablica znakow


            /*
            string teskt = "Ala ma kota";
            foreach(char litera in teskt)
            {
                Console.WriteLine(litera);
            }


            /*
            string teskt = "Ala ma kota";
            Console.WriteLine(teskt[0]);


            //---------------------------------------------------------------
            //WYbrane metody klasy array
            //Metody Reverse(), Sort(), IndexOf() oraz LastIndexOf() stosować można jedynie dla
            //tablic jednowymiarowych. 
            /*
            {
                // elementy tablicy 0 1 2 3 4
                string[] imiona = { "Ala", "Ola", "Ela", "Tola", "Ela" };
                Console.WriteLine(Array.IndexOf(imiona, "Ela")); // wypisze 2
                Console.WriteLine(Array.IndexOf(imiona, "Iza")); // wypisze -1 

            }

            // wyswietlanie indexu jakiegos elementu


            /*
             
            //Sortowanie tablicy 
            int[] tab = { 4, 2, 6, 23, 1, 3, 7, 0 };
            Array.Sort(tab);
            for(int i = 0; i < tab.Length; i++)
            {
                Console.Write("{0} ", tab[i]);
            }

            /*
            // odwracanie tablicy array.reverse
            int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Array.Reverse(tab);
            foreach(int i in tab)
            {
                Console.Write("{0} ", i);
            }


                /*
            //Kopiowanie fragmentru tablicy do drugiej
            int[] a = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
            int[] b = new int[10];
            Array.Copy(a, 0, b, 3, 5);
            foreach(int x in b)
            {
                Console.Write("{0} ", x);
            }
            

            
            
            /*
            //tablice postrzepione-
            ------------------------------------------
            string[][] zespoly =
            {
                new string[] {"Adam", "Karol"},
                new string[] {"Ola", "Ela", "Jan"}
            };
            for(int i = 0; i < zespoly.Length; i++)
            {
                for (int j = 0; j < zespoly.Length; j++)

                {
                    Console.Write("{0,-10} ", zespoly[i][j]);
                }
                Console.WriteLine();
            }


            /* int[][] tab = 
            {
                new int[] { 1,2 },
                new int[] {3,4,5,6 },
                new int[] {7,8,9 }
            };
            foreach(int[] podtablica in tab)
            {
                foreach (int x in podtablica)
                {
                    Console.Write("{0,2}", x);
                }
                        Console.WriteLine();
            }
            


            //tablica dwuwymiarowa

            /*--------------------
            int[,] tab = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, };
            for(int i = 0; i < tab.GetLength(0); i++)
            {
                for(int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write("{0,3}", tab[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            
            int[] uczestnicy = { 19, 23, 56, 34, 23 };
            int max = uczestnicy[0];
            for(int i = 1; i< uczestnicy.Length; i++)
            {
                if (uczestnicy[i] > max)
                    max = uczestnicy[i];
            }
            Console.WriteLine("Najstardszy uczestnik ma {0}", max);

            
            int[] uczestnicy = { 19, 23, 56, 34, 23 };
            int suma = 0;
            double srednia;
            Console.WriteLine("Wiek uczestnikwo: ");
            for(int i = 0; i < uczestnicy.Length; i++)
            {
                Console.Write("{0}, ", uczestnicy[i]);
                suma += uczestnicy[i];
            }
            srednia = (double)suma / uczestnicy.Length;
            Console.WriteLine();
            Console.WriteLine("Srednia: {0},", srednia);
            */
            Console.ReadKey();
        }
    }
}
