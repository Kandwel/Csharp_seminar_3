//Задача 3: Напишите программу, которая перевернёт
//одномерный массив (первый элемент станет
//последним, второй – предпоследним и т.д.)


int lenght = 10, i = 0, num = 0, chet = 0;
int[] n = new int[lenght];

Random rand = new Random();

string reading;

System.Console.WriteLine("Программа переворачивает массив");
Console.WriteLine();

GenerateArray();

void GenerateArray()
{
    i = 0;
    System.Console.Write("Массив чисел: ");
    for (i = 0; i < lenght; i++)
    {
        if (i != lenght - 1)
        {
            n[i] = rand.Next(1,100);
            System.Console.Write($" {n[i]},");
        }
        else
        {
            n[i] = rand.Next(1,100);
            System.Console.Write($" {n[i]}");
        }
    }

    Proverka();
}

void Proverka()
{
    Console.WriteLine();
    System.Console.Write("Вас устраивает массив? (Y/N) ");
    reading = Console.ReadLine();
    Console.WriteLine();
    if (reading != null)
    {
        if (reading == "Y" || reading == "y")
        {
            Revers();            
        }
        else if (reading == "n" || reading == "N")
        {
            GenerateArray();
        }
        else
            Proverka();
    }
}

void Revers()
{
    for (i = 0; i < lenght / 2; i++)
    {
        num = n[i];
        n[i] = n[lenght - (1 + i)];
        n[lenght - (1 + i)] = num;  
    }

    Console.WriteLine();
    System.Console.Write("Перевёрнутый массив чисел: ");

    for (i = 0; i < lenght; i++)
    {
        if (i != lenght - 1)
        {
            System.Console.Write($" {n[i]},");
        }
        else
        {
            System.Console.Write($" {n[i]}");
        }
    }
}