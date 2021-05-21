using System;
using System.Collections.Generic;

namespace Практическая_работа__21_мая_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Перевод числа из римского в арабское");
            Console.WriteLine("Введите число в Римских цифрах");
            string a = Console.ReadLine();
            int ch = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 'I' && a[i] != 'X' && a[i] != 'V' && a[i] != 'C' && a[i] != 'L' && a[i] != 'D' && a[i] != 'M')
                {
                    Console.WriteLine("Ошибка ввода элемента");
                    ch = 0;
                }
                else if (i < a.Length - 1 && a[i] == 'I' && a[i + 1] != 'I')
                {
                    continue;
                }
                else if (a[i] == 'I')
                {
                    ch += 1;
                }
                else if (a[i] == 'V')
                {
                    if (i > 0 && a[i - 1] == 'I')
                    {
                        ch += 4;
                    }
                    else { ch += 5; }
                }

                else if (a[i] == 'X')
                {
                    if (i > 0 && a[i - 1] == 'I')
                    {
                        ch += 9;
                    }
                    else if (i < a.Length - 1 && (a[i + 1] == 'L' || a[i + 1] == 'C'))
                    {
                        continue;
                    }
                    else { ch += 10; }
                }

                else if (a[i] == 'L')
                {
                    if (i > 0 && a[i - 1] == 'X')
                    {
                        ch += 40;
                    }
                    else { ch += 50; }
                }

                else if (a[i] == 'C')
                {
                    if (i > 0 && a[i - 1] == 'X')
                    {
                        ch += 90;
                    }
                    else if (i < a.Length - 1 && (a[i + 1] == 'D' || a[i + 1] == 'M'))
                    {
                        continue;
                    }
                    else { ch += 100; }
                }
                else if (a[i] == 'D')
                {
                    if (i > 0 && a[i - 1] == 'C')
                    {
                        ch += 400;
                    }
                    else { ch += 500; }
                }

                else if (a[i] == 'M')
                {
                    if (i > 0 && a[i - 1] == 'C')
                    {
                        ch += 900;
                    }
                    else { ch += 1000; }
                }
            }
            Console.WriteLine(ch);

            Console.WriteLine("Перевод числа из арабского в римское");
            Console.WriteLine("Введите число в арабских цифрах");
            int r = Convert.ToInt32(Console.ReadLine());
            int[] ara = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] rim = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int j = 0;
            string rm = "";
            while (r > 0)
            {
                if (ara[j] <= r)
                {
                    r = r - ara[j];
                    rm = rm + rim[j];
                }
                else j++;

            }

            Console.Write(rm);
        }
    }
}