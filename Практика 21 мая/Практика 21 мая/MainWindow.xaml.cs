using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Практика_21_мая
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int r = Convert.ToInt32(arab.Text);
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
            tt.Text = rm;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            string a = rimsk.Text;
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
            tk.Text = Convert.ToString(ch);
        }
    }
}
