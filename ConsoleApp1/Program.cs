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
            NumberGuesser numberGuesser = new NumberGuesser();

            numberGuesser.MaximumNumber = 200;

            //Fibonnaci(20);
            //for (int i = 0; i < 20; i++)
            //{
            //Console.WriteLine(Fib(i));
            //}

            //Console.WriteLine(fib(4));

            Sito(10);

            //wypisz wynik


            Console.ReadKey();


            //// Ask user to think of a number between 0 and 100
            //Console.WriteLine("I want you to think of a number between 0 and 100 ok? ");
            //Console.ReadLine();



            ////while the guess isn't the same as the know maximum value untill find the number 
            //while (guessMin != max)
            //{
            //    //increase guess amount
            //    guesses++;

            //    //ask the user if their number is between the guess range
            //    Console.WriteLine($"is your number between {guessMin} and {guessMax}?");
            //    string response = Console.ReadLine();

            //    //if the user confirmed their number is within the current range 
            //    //bool hasResponse = response != null && response.Length > 0;
            //    //if (hasResponse && (response[0] == 'y' || response[0] == 'Y'))

            //    if (response?.ToLower().FirstOrDefault() == 'y') //? sprawdza czy nie jest nulem
            //    {
            //        //We know the number is between guessFrom and guessTo
            //        //so set the new maximum number
            //        max = guessMax;

            //        //change the next quess range to be half of the new maximum range
            //        guessMax -= (guessMax - guessMin) / 2;
            //    }
            //    //the number is greater than guessmax and less than or equal to max
            //    else
            //    {
            //        //the new minimum is one above the old maximum
            //        guessMin = guessMax + 1;

            //        //guess the bottom half of the new range
            //        int reminingDifference = max - guessMax;

            //        //set the guess max to half way beteen the guessMin and max
            //        //note: math.celling will round up the remianing diferenco to 2, if the difference is 3
            //        guessMax += (int)Math.Ceiling(reminingDifference / 2f);
            //    }

            //    //if we only have 2 numbers left, quess on of time
            //    if (guessMin + 1 == max)
            //    {
            //        guesses++;
            //        //ask the user if their number is the lower number
            //        Console.WriteLine($"Is your number {guessMin}?");
            //        response = Console.ReadLine();
            //        //if the user confimed their number is the lower number
            //        if (response?.ToLower().FirstOrDefault() == 'y')
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            //that means the number must be the higher of the two
            //            guessMin = max;
            //            break;
            //        }
            //    }

            //}

            ////tell the user their number
            //Console.WriteLine($"*Your number is { guessMin }*");

            ////let the user know how many guesses it took
            //Console.WriteLine($"*Guessed in {guesses} guesses*");

            Console.ReadKey();

        }
    }
}
