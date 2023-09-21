using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main()
    {
        bool exit = false;
        while (!exit) 
        {
            Console.Clear();
            Console.WriteLine("Виберіть завдання:");
            Console.WriteLine("1. Завдання номер 1");
            Console.WriteLine("2. Завдання номер 2");
            Console.WriteLine("3. Завдання номер 3");
            Console.WriteLine("4. Завдання номер 4");
            Console.WriteLine("5. Завдання номер 5");
            Console.WriteLine("6. Завдання номер 6");
            Console.WriteLine("7. Завдання номер 7");
            Console.WriteLine("8. Завдання номер 8");
            Console.WriteLine("Номер завдання: ");
            string input = Console.ReadLine();
            if (input.ToLower()== "n")
            {
                exit=true;
            }
            else if (int.TryParse(input, out int choice))
                switch (choice)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;

                    case 4:
                        Task4();
                        break;

                    case 5:
                        Task5();
                        break;

                    case 6:
                        Task6();
                        break;
                    case 7:
                        Task7();
                        break;
                    case 8:
                        Task8();
                        break;

                    default:
                        Console.WriteLine("Невірне завдання.");
                        break;
                }
            Console.WriteLine("Натисніть любу клавішу для продовження або 'n' для виходу...");
            var key = Console.ReadKey().Key;
            if (key == ConsoleKey.N)
            {
                exit = true;
            }
            else
            {
                Console.WriteLine("Помилка при вводі літер.");
            }
        }
       
    }
    static void Task1()
    {
        Console.Write("перше число ");
        string input1 = Console.ReadLine();
        int num1 = int.Parse(input1);
        Console.Write("друге число ");
        string input2 = Console.ReadLine();
        int num2 = int.Parse(input2);
        if ((num1 >= 1 && num1 <= 12) && (num2 >= 1 && num2 <= 12))
        {
            Console.Write("Обидва числа можуть бути місяцем");
        }
        else if ((num1 >= 1 && num1 <= 12) && (num2 > 12 || num2 < 1))
        {
            Console.Write("Лише перше чмсло може бути місяцем ");
        }
        else if ((num2 >= 1 && num2 <= 12) && (num1 > 12 || num1 < 1))
        {
            Console.Write("Лише друге чмсло може бути місяцем");
        }
        else if ((num1 < 1 || num1 > 12) && (num2 < 1 || num2 > 12))
        {
            Console.Write("Обидва числа не можуть бути місяцем");
        }

        if ((num1 >= 1 && num1 <= 31) && (num2 >= 1 && num2 <= 31))
        {
            Console.Write(" i обидва числа можуть бути днем");
        }
        else if ((num1 >= 1 && num1 <= 31) && (num2 > 31 || num2 < 1))
        {
            Console.Write(" i лише перше чмсло може бути днем ");
        }
        else if ((num2 >= 1 && num2 <= 31) && (num1 > 31 || num1 < 1))
        {
            Console.Write(" i лише друге чмсло може бути днем");
        }
        else if ((num1 < 1 || num1 > 31) && (num2 < 1 || num2 > 31))
        {
            Console.Write(" i oбидва числа не можуть бути днем");
        }
    }
    static void Task2()
    {
        Console.Write("Введіть дійсне число: ");
        double number = double.Parse(Console.ReadLine());
        int sum = (int)((number * 100) % 10) + (int)((number * 10) % 10);
        Console.WriteLine($"Результат: {sum}");
    }


    static void Task5()
    {
        Console.Write("Enter the length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());
        double area = length * width;
        Console.WriteLine($"The area of the rectangle is {area}");
    }

    static void Task6()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }
    }

    static void Task3()
    {
        Console.Write("Enter the time (0-24): ");
        int time = int.Parse(Console.ReadLine());
        string greeting = "";

        if (time < 7)
        {
            greeting = "Доброї ночі";
        }
        else if (time < 12)
        {
            greeting = "Доброго ранку";
        }
        else if (time < 19)
        {
            greeting = "Добрий день";
        }
        else if (time < 23)
        {
            greeting = "Добрий вечір";
        }
        else if (time <= 24)
        {
            greeting = "Доброї ночі";
        }
        else
        {
            greeting = "Помилка";
        }

        Console.WriteLine(greeting);
    }

    static void Task4()
    {
        int[] numbers = new int[3];
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Enter your {i + 1} number - ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int num))
            {
                numbers[i] = num;
            }
        }
        int min = numbers[0];
        int max = numbers[0];
        for (int i = 1; i < 3; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }

            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        Console.WriteLine($"Minimum: {min}");
        Console.WriteLine($"Maximum: {max}");
    }
    static void Task7()
    {
        Console.WriteLine("Напишіть градуси Ферингейта - ");
        string Fstr = Console.ReadLine();
        double F = double.Parse( Fstr);
        double C = (F - 32) * 5 / 9;
        Console.WriteLine(C);
    }
    static void Task8()
    {
        Console.WriteLine("Напишіть кількість натуральних чисел - ");
        if (int.TryParse(Console.ReadLine(), out int n));
        int sum = 0;
        for (int i = 1; i <=n; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Сума перших {n} натуральних чисел дорівнює {sum}");
    }
}
