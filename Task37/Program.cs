/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

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

int[] PairMult(int[] ArrayToSeek)
{
    // double Size = ArrayToSeek.Length / 2;
    // Size = Convert.ToInt32(Math.Round(Size, MidpointRounding.ToPositiveInfinity));
    // округление получилось "громоздким", 
    // переменную double Size нельзя использовать как индекс массива

    int Size = ArrayToSeek.Length / 2;
    if (ArrayToSeek.Length % 2 != 0)
    {
        Size++;
    }

    int[] result = new int[Size];
    for (int i = 0; i < Size; i++)
    {
        result[i] = ArrayToSeek[i] * ArrayToSeek[ArrayToSeek.Length - 1 - i];
    }

    if (ArrayToSeek.Length % 2 != 0)
    {
        result[Size - 1] = ArrayToSeek[Size - 1];
    }
    return result;
}

int ArraySize = new Random().Next(1, 15);
//int[] Array = new int[] { 1, 2, 3, 4, 5 }; 
//int[] Array = new int[] { 6, 7, 3, 6}; 
int[] Array = new int[ArraySize];
int[] Result;

Console.Clear();

FillArray(Array, -10, 10);
Result = PairMult(Array);
Console.WriteLine("Произведение пар чисел в одномерном массиве:");
PrintArray(Array);
Console.WriteLine("----------------------");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Является = ");
PrintArray(Result);
Console.ForegroundColor = ConsoleColor.White;