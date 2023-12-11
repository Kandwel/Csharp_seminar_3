//Задача 1: Напишите программу, которая бесконечно
//запрашивает целые числа с консоли. Программа
//завершается при вводе символа ‘q’ или при вводе
//числа, сумма цифр которого четная.

int count = 0, sum = 0, num;
string input; 

System.Console.WriteLine("Задание 1");
System.Console.WriteLine("Программа бесконечно запрашивает числа.");
System.Console.WriteLine("Если пользователь вводит q или сумма цифр числа чётное,");
System.Console.WriteLine("то программа завершает работу.");
Console.WriteLine();

InfinityNumbers();

void InfinityNumbers()
{
    System.Console.WriteLine("Введите любое число либо введите 'q' для выхода: ");
    input = Console.ReadLine();
    if (input != "q" || input != "Q")
    {
        sum = 0;
        if (int.TryParse(input, out num))
        {
            while (num > 0)
            {
                sum = sum + (num % 10);
                num = num / 10;
            }

            if (sum % 2 == 0)
            {
                System.Console.WriteLine("Сумма цифр чётная, программа завершена!");
            }
            else
                InfinityNumbers();
        }
    }
    else if (input == "q" || input == "Q")
    {
        System.Console.WriteLine("Вы ввели 'q', программа завершена!");
    }
    
}
