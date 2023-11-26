using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_03_01
{
    public class Square
    {
        public void squarePrint()
        {
            Console.Write("Введите размер квадрата: ");
            int size = int.Parse(Console.ReadLine());

            Console.Write("Введите символ для квадрата: ");
          char sumbol = char.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || j == 0 || i == size - 1 || j == size - 1)
                        Console.Write(sumbol + " ");
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
    }
}
