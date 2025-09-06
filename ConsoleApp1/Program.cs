// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double one, two, result;
            string znak;
            Console.WriteLine("Добро пожаловать в калькулятор. Вам необходимо ввести первое\nчисло, затем знак действия(+,-,*,/, %, ^2, sqrt, 1/x, m+, m-, mr ), которое хотите совершить и второе число.");
            Console.Write("Введите первое число");
            one = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите знак действия");
            znak = Convert.ToString(Console.ReadLine());
            if (znak != "+" || znak != "-" || znak != "*" || znak != "/" || znak != "%" || znak != "^2" ||
                znak != "sqrt" || znak != "1/x" || znak != "m+" || znak != "mr" || znak != "m-")
            {
                Console.WriteLine("неизвестный знак!");
            }
            else
            { 
                if (znak == "+")
                {
                    Console.WriteLine("Введите второе число");
                    two = Convert.ToSingle(Console.ReadLine());
                    result = one + two;
                    Console.WriteLine("результат: " +  result);
                    Console.WriteLine("для выхода нажмите любую клавишу");
                    Console.ReadKey();
                }
                if (znak == "-")
                {
                    Console.WriteLine("Введите второе число");
                    two = Convert.ToSingle(Console.ReadLine());
                    result = one - two;
                    Console.WriteLine("результат: " +  result);
                    Console.WriteLine("для выхода нажмите любую клавишу");
                    Console.ReadKey();
                }
                if (znak == "*")
                {
                    Console.WriteLine("Введите второе число");
                    two = Convert.ToSingle(Console.ReadLine());
                    result = one * two;
                    Console.WriteLine("результат: " +  result);
                    Console.WriteLine("для выхода нажмите любую клавишу");
                    Console.ReadKey();
                }
                if (znak == "/")
                {
                    Console.WriteLine("Введите второе число");
                    two = Convert.ToSingle(Console.ReadLine());
                    if (two == 0)
                    {
                        Console.WriteLine("на 0 делить нельзя!");
                        Console.WriteLine("для выхода нажмите любую клавишу");
                        Console.ReadKey();
                    }
                    else
                    {
                        result = one / two;
                        Console.WriteLine("результат: " +  result);
                        Console.WriteLine("для выхода нажмите любую клавишу");
                        Console.ReadKey();
                    }
                }
                if (znak == "%")
                {
                    Console.WriteLine("Введите второе число");
                    two = Convert.ToSingle(Console.ReadLine());
                    if (two == 0)
                    {
                        Console.WriteLine("на 0 делить нельзя!");
                        Console.WriteLine("для выхода нажмите любую клавишу");
                        Console.ReadKey();
                    }
                    else
                    {
                        result = one % two;
                        Console.WriteLine("результат: " +  result);
                        Console.WriteLine("для выхода нажмите любую клавишу");
                        Console.ReadKey();
                    }
                }
                if (znak == "^2")
                {
                    result = one * one;
                    Console.WriteLine("результат: " +  result);
                    Console.WriteLine("для выхода нажмите любую клавишу");
                    Console.ReadKey();
                }
                if (znak == "1/x")
                {
                    if (one == 0)
                    {
                        Console.WriteLine("на 0 делить нельзя!");
                        Console.WriteLine("для выхода нажмите любую клавишу");
                        Console.ReadKey();
                    }
                    else
                    {
                        result = 1/one;
                        Console.WriteLine("результат: " +  result);
                        Console.WriteLine("для выхода нажмите любую клавишу");
                        Console.ReadKey();
                    }
                }
                if (znak == "sqrt")
                {
                    if (one < 0)
                    {
                        Console.WriteLine("корень из отрицательного числа невозможен!");
                        Console.WriteLine("для выхода нажмите любую клавишу");
                        Console.ReadKey();
                    }
                    else
                    {
                        result = Math.Sqrt(one);
                        Console.WriteLine("результат: " +  result);
                        Console.WriteLine("для выхода нажмите любую клавишу");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}