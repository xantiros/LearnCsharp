using System;

namespace ConsoleApp1
{
    public class Fibonanaci
    {
        public void Fibonnaci(int n)
        {
            int a = 0;              //a b  
            int b = 1;              //0 1 1 2 3 5
            //int c;                //t a b
            //Console.WriteLine(a);
            for (int i = 0; i < n; i++)
            {
                int tmp = a;
                a = b;
                b = tmp + a;
                Console.WriteLine(a);
            }
            //return a;
        }

        public int Fib(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        public void Sito(int n)
        {
            int i, j, max, dokad;
            int[] tablica = new int[10000];

            Console.WriteLine("Podaj gorny zakres, do ktorego chcesz odnalezc liczby pierwsze");
            max = int.Parse(Console.ReadLine());
            dokad = (int)Math.Floor(Math.Sqrt(max));

            //inicjuj tablice
            for (i = 0; i <= max; i++) tablica[i] = i;

            for (i = 2; i <= dokad; i++)
            {
                if (tablica[i] != 0)
                {
                    j = i + i;
                    while (j <= max)
                    {
                        tablica[j] = 0;
                        j += i;
                    }
                }
            }

            Console.WriteLine("Liczby pierwsze z zakresu od 1 do " + max);
            for (i = 2; i <= max; i++)
                if (tablica[i] != 0)
                    Console.WriteLine(i + ", ");

        }
    }
}
