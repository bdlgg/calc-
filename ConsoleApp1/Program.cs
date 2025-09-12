// See https://aka.ms/new-console-template for more information
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Security.Policy;
// using System.Text;
// using System.Threading.Tasks;
//
// namespace ConsoleApp1
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             double one, two, result;
//             double memory = 0;
//             string znak;
//             Console.WriteLine("Добро пожаловать в калькулятор. Вам необходимо ввести первое\nчисло, затем знак действия(+,-,*,/, %, ^2, sqrt, 1/x, m+, m-, mr ), которое хотите совершить и второе число.");
//             Console.WriteLine("Чтобы выйти напишите exit вместо знака");
//             while (true)
//             {
//                 Console.Write("Введите первое число: ");
//                 if (!double.TryParse(Console.ReadLine(), out one))
//                 {
//                     Console.WriteLine("Ошибка ввода числа, попробуйте снова.\n");
//                     continue;
//                 }
//
//                 Console.Write("Введите знак действия: ");
//                 znak = Console.ReadLine();
//
//                 if (znak == "exit")
//                 {
//                     Console.WriteLine("Выход из калькулятора.");
//                     break;
//                 }
//                 if (znak != "+" && znak != "-" && znak != "*" && znak != "/" && znak != "%" &&
//                     znak != "^2" && znak != "sqrt" && znak != "1/x" &&
//                     znak != "m+" && znak != "m-" && znak != "mr")
//                 {
//                     Console.WriteLine("Неизвестный знак!\n");
//                     continue;
//                 }
//                 if (znak == "+")
//                 {
//                     Console.Write("Введите второе число: ");
//                     two = Convert.ToDouble(Console.ReadLine());
//                     result = one + two;
//                     Console.WriteLine("Результат: " + result + "\n");
//                 }
//                 if (znak == "-")
//                 {
//                     Console.Write("Введите второе число: ");
//                     two = Convert.ToDouble(Console.ReadLine());
//                     result = one - two;
//                     Console.WriteLine("Результат: " + result + "\n");
//                 }
//                 if (znak == "*")
//                 {
//                     Console.Write("Введите второе число: ");
//                     two = Convert.ToDouble(Console.ReadLine());
//                     result = one * two;
//                     Console.WriteLine("Результат: " + result + "\n");
//                 }
//                 if (znak == "/")
//                 {
//                     Console.Write("Введите второе число: ");
//                     two = Convert.ToDouble(Console.ReadLine());
//                     if (two == 0)
//                     {
//                         Console.WriteLine("На 0 делить нельзя!\n");
//                     }
//                     else
//                     {
//                         result = one / two;
//                         Console.WriteLine("Результат: " + result + "\n");
//                     }
//                 }
//                 if (znak == "%")
//                 {
//                     Console.Write("Введите второе число: ");
//                     two = Convert.ToDouble(Console.ReadLine());
//                     if (two == 0)
//                     {
//                         Console.WriteLine("На 0 делить нельзя!\n");
//                     }
//                     else
//                     {
//                         result = one % two;
//                         Console.WriteLine("Результат: " + result + "\n");
//                     }
//                 }
//                 if (znak == "^2")
//                 {
//                     result = one * one;
//                     Console.WriteLine("Результат: " + result + "\n");
//                 }
//                 if (znak == "1/x")
//                 {
//                     if (one == 0)
//                     {
//                         Console.WriteLine("На 0 делить нельзя!\n");
//                     }
//                     else
//                     {
//                         result = 1 / one;
//                         Console.WriteLine("Результат: " + result + "\n");
//                     }
//                 }
//                 if (znak == "sqrt")
//                 {
//                     if (one < 0)
//                     {
//                         Console.WriteLine("Корень из отрицательного числа невозможен!\n");
//                     }
//                     else
//                     {
//                         result = Math.Sqrt(one);
//                         Console.WriteLine("Результат: " + result + "\n");
//                     }
//                 }
//                 if (znak == "m+")
//                 {
//                     memory += one;
//                     Console.WriteLine("Память: " + memory + "\n");
//                 }
//                 if (znak == "m-")
//                 {
//                     memory -= one;
//                     Console.WriteLine("Память: " + memory + "\n");
//                 }
//                 if (znak == "mr")
//                 {
//                     Console.WriteLine("Значение из памяти: " + memory + "\n");
//                 }
//             }
//         }
//     }
// }