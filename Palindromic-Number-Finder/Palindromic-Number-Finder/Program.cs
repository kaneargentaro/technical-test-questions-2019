/*
This Palindromic Number Finder was written in c#, and it finds a palindrome that is derived from two three digit numbers.

It was written for a technical test that I took as part of a job recruitment on the 14th of Aug, 2019.

2 three digit numbeers = a palindromic number
eg: 300 x 300 = palindromic number
method returns the palindrome, and the 2 three digit numbers
*/

using System;

namespace Palindromic_Number_Finder
{
    class Program
    {
        //pass in a reference to i and j that we create in main()
        static int GetPalindrome(ref int i, ref int j)
        {
            for (i = 100; i < 1000; i++)
            {
                for (j = 100; j < 1000; j++)
                {
                    int sum = i * j;
                    //convert int to string for the sum
                    string sum1 = sum.ToString();
                    //create character array, save value from sum1
                    char[] sumRevArr = sum1.ToCharArray();
                    //reverse
                    Array.Reverse(sumRevArr);
                    //save reversed array to a new string
                    string sumReversed = new string(sumRevArr);

                    //if both strings are the same (even after being reversed), then the sum of i and j is a palindrome
                    if (sum1.Equals(sumReversed))
                    {
                        //if both are equal, then return sum which is the palindrone number
                        //also exits all loops
                        return sum;
                    }

                }
            }
            //if no palindrone found or there is an error, then return 0
            return 0;
        }

        static void Main(string[] args)
        {
            //declare i, j
            int i = 100;
            int j = 100;
            //variable palindrone to store the return value from method
            //pass i and j in as a ref
            int palindrone = GetPalindrome(ref i, ref j);

            //show output
            Console.WriteLine("The palidrone {0} is made up of {1} * {2}", palindrone, i, j);
        }
    }
}