using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_03_01
{
    public class Palindrome
    {
        public bool methodPalindrome()
        {
            Console.Write("Введите любое число: ");
            string number = Console.ReadLine();
            string revers = string.Empty;
            for (int i = number.Length - 1; i >= 0; i--)
                revers += number[i];
            if (number == revers)
                return true;
            else
                return false;
        }
    }
}
