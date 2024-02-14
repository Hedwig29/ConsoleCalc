using System;
using System.Text;
using System.Xml.Schema;
using static System.Collections.Specialized.BitVector32;

class Calculator
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("Калькулятор:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Выход");

            Console.Write("Выберите операцию (1/2/3/4/5): ");
            string action = Console.ReadLine();
            bool result1 = int.TryParse(action, out int value);
            while (!result1) 
            {
                Console.WriteLine("Пожалуйста, введите число");
                action = Console.ReadLine();
                result1 = int.TryParse(action, out  value);
            }

            double number1, number2, total;

            Console.WriteLine("Введите первое число");
            number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            number2 = double.Parse(Console.ReadLine());
            
            switch (action)
            {
                case "1":
                    total = number1 + number2;
                    Console.WriteLine("Сумма " + number1 + " и " + number2 + " равна " + total + ".");
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    total = number1 - number2;
                    Console.WriteLine("Разность " + number1 + " и " + number2 + " равна " + total + ".");
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "3":
                    total = number1 * number2;
                    Console.WriteLine("Умножение " + number1 + " на " + number2 + " равно " + total + ".");
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "4":
                    total = number1 / number2;
                    Console.WriteLine("Деление " + number1 + " и " + number2 + " равно " + total + ".");
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                    if (number1 == 0)
                    {
                        Console.WriteLine(0);
                    }
                    if (number2 == 0)
                    {
                        Console.WriteLine(0);
                    }
                    break;
                case "5":
                    Console.Clear();
                    break;

                default:
                    Console.WriteLine("Неизвестная команда,повторите попытку");
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                    // Код пишем тут
                    // Не забываем про break;
                    // Не забываем про деление на ноль
                    // Не забываем про некорректный ввод (например, буквы)

                    //Console.Write("Введите первое число: ");

                    //Console.Write("Введите второе число: ");

            }
        }
    }
}