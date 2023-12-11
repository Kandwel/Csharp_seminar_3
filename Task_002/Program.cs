//Задача 2: Задайте массив заполненный случайными
//трёхзначными числами. Напишите программу,
//которая покажет количество чётных чисел в
//массиве

int lenght = 10, i = 0, count = 0, chet = 0;
int[] n = new int[lenght];

Random rand = new Random();

string reading;

System.Console.WriteLine("Программа вычисляет, сколько чётных чисел в данном массиве из трёхзначных чисел");
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
            n[i] = rand.Next(100,999);
            System.Console.Write($" {n[i]},");
        }
        else
        {
            n[i] = rand.Next(100,999);
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
            ProvNaChet();            
        }
        else if (reading == "n" || reading == "N")
        {
            GenerateArray();
        }
        else
            Proverka();
    }
}

void ProvNaChet()
{
    for (i = 0; i < lenght; i++)
    {
        if (n[i] % 2 == 0)
        chet++;
    }
    Console.WriteLine($"Чётных чисел в массиве: {chet}");
}