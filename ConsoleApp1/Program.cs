using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static void Fibonnaci(int n)
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

        public static int Fib(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        public static void Sito(int n)
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


        static void Main(string[] args)
        {
            var numberGuesser = new NumberGuesser();

            //change the default maximum number to 200
            numberGuesser.MaximumNumber = 200;

            //ask the user to think of a number
            numberGuesser.InformUser();

            //discover the number the user is thinking of
            numberGuesser.DiscoverNumber();

            //annouce the result
            numberGuesser.AnnouceResult();


            //Fibonnaci(20);
            //for (int i = 0; i < 20; i++)
            //{
            //Console.WriteLine(Fib(i));
            //}

            //Console.WriteLine(fib(4));

            //Sito(10);

            //wypisz wynik

          
           

            Console.ReadKey();

        }
    }
}
