using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Ask the user to guess a number between a certain range and then guesses that number 
    /// </summary>
    public class NumberGuesser
    {
        #region Public Properties
        /// <summary>
        /// The largest number we ask the user to guess, between 0 and this number;
        /// </summary>
        public int MaximumNumber { get; set; }

        /// <summary>
        /// current number of guesses the computer has had
        /// </summary>
        public int CurrentNumberOfGuesses { get; private set; }

        /// <summary>
        /// The current known minimum number the user is thinking of
        /// </summary>
        public int CurrentGuessMinimum { get; private set; }

        /// <summary>
        /// The current known maximum number the user is thinking of
        /// </summary>
        public int CurrentguessMaximum { get; private set; }
        #endregion

        #region .ctor
        /// <summary>
        /// Default constructor
        /// </summary>
        public NumberGuesser()
        {
            //set default maximum number;
            this.MaximumNumber = 100;
        }
        #endregion

        /// <summary>
        /// Ask the user to think of a number between 0 and the maximum number
        /// </summary>
        public void InformUser()
        {
            // Ask user to think of a number between 0 and MaximumNumber
            Console.WriteLine($"I want you to think of a number between 0 and {this.MaximumNumber}  ok? ");
            Console.ReadLine();
        }

        /// <summary>
        /// Aske the user a series of question 
        /// </summary>
        public void DiscoverNumber()
        {
            //while the guess isn't the same as the know maximum value untill find the number 
            while (this.CurrentGuessMinimum != this.CurrentguessMaximum)
            {
                //increase guess amount
                this.CurrentNumberOfGuesses++;

                //ask the user if their number is between the guess range
                Console.WriteLine($"is your number between {this.CurrentGuessMinimum} and {this.CurrentguessMaximum}?");
                string response = Console.ReadLine();

                //if the user confirmed their number is within the current range 
                //bool hasResponse = response != null && response.Length > 0;
                //if (hasResponse && (response[0] == 'y' || response[0] == 'Y'))

                if (response?.ToLower().FirstOrDefault() == 'y') //? sprawdza czy nie jest nulem
                {
                    //We know the number is between guessFrom and guessTo
                    //so set the new maximum number
                    this.MaximumNumber = this.CurrentguessMaximum;

                    //change the next quess range to be half of the new maximum range
                    this.CurrentguessMaximum -= (this.CurrentguessMaximum - this.CurrentGuessMinimum) / 2;
                }
                //the number is greater than guessmax and less than or equal to max
                else
                {
                    //the new minimum is one above the old maximum
                    this.CurrentGuessMinimum = this.CurrentguessMaximum + 1;

                    //guess the bottom half of the new range
                    int reminingDifference = this.MaximumNumber - this.CurrentguessMaximum;

                    //set the guess max to half way beteen the guessMin and max
                    //note: math.celling will round up the remianing diferenco to 2, if the difference is 3
                    this.CurrentguessMaximum += (int)Math.Ceiling(reminingDifference / 2f);
                }

                //if we only have 2 numbers left, quess on of time
                if (this.CurrentGuessMinimum + 1 == this.MaximumNumber)
                {
                    this.CurrentNumberOfGuesses++;
                    //ask the user if their number is the lower number
                    Console.WriteLine($"Is your number {this.CurrentGuessMinimum}?");
                    response = Console.ReadLine();
                    //if the user confimed their number is the lower number
                    if (response?.ToLower().FirstOrDefault() == 'y')
                    {
                        break;
                    }
                    else
                    {
                        //that means the number must be the higher of the two
                        this.CurrentGuessMinimum = this.MaximumNumber;
                        break;
                    }
                }

            }
        }

        /// <summary>
        /// Annouces the number the user was thinking of 
        /// </summary>
        public void AnnouceResult()
        {
            //tell the user their number
            Console.WriteLine($"*Your number is { this.CurrentGuessMinimum }*");

            //let the user know how many guesses it took
            Console.WriteLine($"*Guessed in {this.CurrentNumberOfGuesses} guesses*");
        }

    }
}
