using System;

class Calculator
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Возведение в степень");
            Console.WriteLine("6. Квадратный корень");
            Console.WriteLine("7. 1 процент от числа");
            Console.WriteLine("8. Факториал");
            Console.WriteLine("9. Выйти из программы");
            Console.Write("Введите номер операции: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = Sum();
                        break;
                    case 2:
                        result = Subtract();
                        break;
                    case 3:
                        result = Multiply();
                        break;
                    case 4:
                        result = Divide();
                        break;
                    case 5:
                        result = Power();
                        break;
                    case 6:
                        result = SquareRoot();
                        break;
                    case 7:
                        result = Percent();
                        break;
                    case 8:
                        result = Factorial();
                        break;
                    case 9:
                        Console.WriteLine("Программа завершена.");
                        return;
                    default:
                        Console.WriteLine("Некорректный ввод. Пожалуйста, выберите существующую операцию.");
                        break;
                }

                Console.WriteLine($"Результат: {result}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 9.");
            }

        } while (true);
    }

    static double GetNumberFromUser(string prompt)
    {
        double number;
        bool isValid;
        do
        {
            Console.Write(prompt);
            isValid = double.TryParse(Console.ReadLine(), out number);
            if (!isValid)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            }
        } while (!isValid);

        return number;
    }

    static double Sum()
    {
        double a = GetNumberFromUser("Введите первое число: ");
        double b = GetNumberFromUser("Введите второе число: ");
        return a + b;
    }

    static double Subtract()
    {
        double a = GetNumberFromUser("Введите первое число: ");
        double b = GetNumberFromUser("Введите второе число: ");
        return a - b;
    }

    static double Multiply()
    {
        double a = GetNumberFromUser("Введите первое число: ");
        double b = GetNumberFromUser("Введите второе число: ");
        return a * b;
    }

    static double Divide()
    {
        double a = GetNumberFromUser("Введите первое число: ");
        double b;
        do
        {
            b = GetNumberFromUser("Введите второе число (не равное нулю): ");
            if (b == 0)
            {
                Console.WriteLine("Деление на ноль невозможно. Пожалуйста, введите другое число.");
            }
        } while (b == 0);

        return a / b;
    }

    static double Power()
    {
        double baseNumber = GetNumberFromUser("Введите число: ");
        double exponent = GetNumberFromUser("Введите степень: ");
        return Math.Pow(baseNumber, exponent);
    }

    static double SquareRoot()
    {
        double number = GetNumberFromUser("Введите число: ");
        return Math.Sqrt(number);
    }

    static double Percent()
    {
        double number = GetNumberFromUser("Введите число: ");
        return 0.01 * number;
    }

    static double Factorial()
    {
        int number = (int)GetNumberFromUser("Введите целое неотрицательное число для вычисления факториала: ");
        if (number < 0)
        {
            Console.WriteLine("Факториал отрицательного числа не определен.");
            return double.NaN;
        }

        double result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }
}
