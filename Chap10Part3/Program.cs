using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num;
            //Console.Write("Enter a number: ");
            //num = Convert.ToInt32(Console.ReadLine());
            //if (isEven(num))
            //    Console.WriteLine(num + " is even.");
            //else
            //    Console.WriteLine(num + " is odd.");
            char aLetter;
            Console.Write("Enter a letter: ");
            aLetter = Convert.ToChar(Console.ReadLine());
            if (isVowel(aLetter))
                Console.WriteLine(aLetter + " is a vowel.");
            else
                Console.WriteLine(aLetter + " is a consonant.");
            Console.ReadKey();
        }

        static Boolean isEven(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }

        static Boolean isVowel(char letter)
        {
            if (letter == 'a' || letter == 'e' || letter == 'i'
                || letter == 'o' || letter == 'u')
                return true;
            else
                return false;
        }
    }
}
