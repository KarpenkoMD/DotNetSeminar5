/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

void FillArray(int[] ArrayToFill, int BorderLeft, int BorderRight)
{
    for (int i = 0; i < ArrayToFill.Length; i++)
    {
        ArrayToFill[i] = new Random().Next(BorderLeft, BorderRight + 1);
    }
}

void PrintArray(int[] ArrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < ArrayToPrint.Length; i++)
    {
        Console.Write($"{ArrayToPrint[i]}");
        if (i < ArrayToPrint.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int FindEvenInArray(int[] ArrayToSeek)
{
    int result = 0;
    for (int i = 0; i < ArrayToSeek.Length; i++)
    {
        if (ArrayToSeek[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

int ArraySize = 0;
ArraySize = new Random().Next(1, 50);
Console.Clear();

int[] Array = new int[ArraySize];
FillArray(Array, 100, 999);
int EvensAmount = FindEvenInArray(Array);
Console.WriteLine("В массиве:");
PrintArray(Array);
Console.WriteLine($"{EvensAmount} четных чисел.");
