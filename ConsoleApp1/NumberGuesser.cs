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
    }
}
