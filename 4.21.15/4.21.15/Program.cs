using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_21_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //isbn test
            ////a valid number: 0-7475-3269-9
            //Console.WriteLine(verifyISBN("0-0000-0040-X"));

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i + ": " + FizzBuzz(i));
            }

                Console.Read();//pause console
        }

        static string FizzBuzz(int input)
        {
            string output = "";
            if (input % 3 == 0)
            {
                output += "Fizz";
            }
            if (input % 5 == 0)
            {
                output += "Buzz";
            }
            return output;
        }

        static bool verifyISBN(string in_isbn)
        {
            //make sure the syntax is correct
            //check length
            if (in_isbn.Length < 13)
            {
                return false;
            }
            for (int i = 0; i < in_isbn.Length; i++)
            {
                if (i == 1 || i == 6 || i == 11)
                {
                    //make sure dashes are correct
                    if (in_isbn.ElementAt(i) != '-')
                    {
                        return false;
                    }
                }
                else if (i == 12)
                {
                    //the last number can be an 'X' so it needs a specal case
                    char lastChar = in_isbn.ElementAt(i);
                    if ((lastChar - '0' > 9 || lastChar - '0' < 0))
                    {
                        if (lastChar != 'X' && lastChar != 'x')
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    //make sure the numbers are actually numbers
                    char currentChar = in_isbn.ElementAt(i);
                    if (currentChar - '0' > 9 || currentChar - '0' < 0)
                    {
                        return false;
                    }
                }
            }

            int total = 0;
            total += 10 * (in_isbn.ElementAt(0) - '0');
            //-
            total += 9 * (in_isbn.ElementAt(2) - '0');
            total += 8 * (in_isbn.ElementAt(3) - '0');
            total += 7 * (in_isbn.ElementAt(4) - '0');
            total += 6 * (in_isbn.ElementAt(5) - '0');
            //-
            total += 5 * (in_isbn.ElementAt(7) - '0');
            total += 4 * (in_isbn.ElementAt(8) - '0');
            total += 3 * (in_isbn.ElementAt(9) - '0');
            total += 2 * (in_isbn.ElementAt(10) - '0');
            //-
            //check for "X"
            if (in_isbn.ElementAt(12) == 'X' || in_isbn.ElementAt(12) == 'x')
            {
                total += 10;
            }
            else
            {
                total += /* (1 *) */ (in_isbn.ElementAt(12) - '0');
            }

            //determine validity
            return (0 == total % 11);
        }
    }
}
