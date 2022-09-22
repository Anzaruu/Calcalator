bool check = true;

Console.WriteLine("1. Сложить 2 числа");
Console.WriteLine("2. Вычесть первое из второго");
Console.WriteLine("3. Перемножить два числа");
Console.WriteLine("4. Разделить первое на второе");
Console.WriteLine("5. Возвести в степень N первое число");
Console.WriteLine("6. Найти квадратный корень из числа");
Console.WriteLine("7. Найти 1 процент от числа");
Console.WriteLine("8. Найти факториал из числа");
Console.WriteLine("9. Выйти из программы");
do
{   
    Console.WriteLine("Введите номер команды:");
    string nomer = Console.ReadLine();
    int a = Convert.ToInt32(nomer);

    if (a == 1)
    {
        Console.WriteLine("Введите первое число: ");
        string chislo1 = Console.ReadLine();
        int b = Convert.ToInt32(nomer);

        Console.WriteLine("Введите второе число: ");
        string chislo2 = Console.ReadLine();
        int c = Convert.ToInt32(nomer);

        Console.WriteLine("Результат: ");
        Console.WriteLine(b + c);
    }
    if (a == 2)
    {
        Console.WriteLine("Введите первое число: ");
        string chislo1 = Console.ReadLine();
        int b = Convert.ToInt32(nomer);

        Console.WriteLine("Введите второе число: ");
        string chislo2 = Console.ReadLine();
        int c = Convert.ToInt32(nomer);

        Console.WriteLine("Результат: ");
        Console.WriteLine(b - c);
    }
    if (a == 3)
    {
        Console.WriteLine("Введите первое число: ");
        string chislo1 = Console.ReadLine();
        int b = Convert.ToInt32(chislo1);

        Console.WriteLine("Введите второе число: ");
        string chislo2 = Console.ReadLine();
        int c = Convert.ToInt32(chislo2);

        Console.WriteLine("Результат: ");
        Console.WriteLine(b * c);
    }
    if (a == 4)
    {
        Console.WriteLine("Введите первое число: ");
        string chislo1 = Console.ReadLine();
        int b = Convert.ToInt32(chislo1);

        Console.WriteLine("Введите второе число: ");
        string chislo2 = Console.ReadLine();
        int c = Convert.ToInt32(chislo2);

        float k = b / c;
        Console.WriteLine("Результат: ");
        Console.WriteLine(k);
    }
    if (a == 5)
    {
        Console.WriteLine("Введите число: ");
        string chislo1 = Console.ReadLine();
        int b = Convert.ToInt32(chislo1);

        Console.WriteLine("Введите в какую степень хотите ввести число: ");
        string stepen = Console.ReadLine();
        int d = Convert.ToInt32(stepen);

        Console.WriteLine("Результат: ");
        Console.WriteLine(Math.Pow(b, d));
    }
    if (a == 6)
    {
        Console.WriteLine("Введите число: ");
        string chislo1 = Console.ReadLine();
        int b = Convert.ToInt32(chislo1);

        Console.WriteLine("Результат: ");
        Console.WriteLine(Math.Sqrt(b));
    }
    if (a == 7)
    {
        Console.WriteLine("Введите число: ");
        string chislo1 = Console.ReadLine();
        int b = Convert.ToInt32(chislo1);

        Console.WriteLine("Результат : ");
        Console.WriteLine((b * 1) / 100);
    }
    if (a == 8)
    {
        Console.WriteLine("Введите число: ");
        string chislo1 = Console.ReadLine();
        int b = Convert.ToInt32(chislo1);

        int factorial = 1;

        for (int i = 2; i <= b; i++)
        {
            factorial = factorial * i;
        }
    }
    if (a == 9)
    {
        check = false;
    }
}
while (check == true);