using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RevertNumber
    {
        public int Revert(int number)
        {
            int newNumber = 0;
            int mod = 0;
            int num = number;

            for (int i = 1; i <= num.ToString().Length; i++)
            {
                mod = number % 10;
                newNumber = (newNumber * 10) + mod;
                number = number / 10;
            }
            return newNumber;
        }
    }
}
