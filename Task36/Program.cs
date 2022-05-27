/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


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

int SumOddElements(int[] ArrayToSeek)
{
    int result = 0;
    for (int i = 1; i < ArrayToSeek.Length; i++)
    {
        if (i % 2 != 0)
        {
            result = result + ArrayToSeek[i];
        }
    }
    return result;
}

int ArraySize = new Random().Next(1, 20);
int[] Array = new int[ArraySize];
int Result = 0;

Console.Clear();

FillArray(Array, -10, 10);
Result = SumOddElements(Array);
Console.WriteLine("В массиве:");
PrintArray(Array);

Console.WriteLine($"Сумма значений нечётных элементов =  {Result}");
