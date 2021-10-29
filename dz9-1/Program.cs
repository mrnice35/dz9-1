using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz9_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Вас приветствует калькулятор!");
            Console.WriteLine("Введите число a");
            double a = 0;
            double b = 0;
            while (true)
            {
                try
                {
                    double a1 = Convert.ToInt32(Console.ReadLine());
                    a = a1;
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели не число!повторите ввод");
                    continue;
                }
            }
            Console.WriteLine("Введите число b");
            while (true)
            {
                try
                {
                    double b1 = Convert.ToInt32(Console.ReadLine());
                    b = b1;
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели не число.повторите ввод");
                    continue;
                }
            }
            Console.WriteLine("Введите номер операции: 1-Сложение  2-Вычитание  3-Произведение 4-Частное ");
            int operation = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            switch (operation)
            {
                case 1:
                    result = a + b;
                    Console.WriteLine("Результат операции {0}", result);
                    break;
                case 2:
                    result = a - b;
                    Console.WriteLine("Результат операции {0}", result);
                    break;
                case 3:
                    result = a * b;
                    Console.WriteLine("Результат операции {0}", result);
                    break;
                case 4:
                    if (b > 0)
                    {
                        result = a / b;
                        Console.WriteLine("Результат операции {0}", result);
                    }
                    else
                    {
                        Console.WriteLine("Деление на ноль!");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
      