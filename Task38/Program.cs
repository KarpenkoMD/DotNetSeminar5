/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

void FillArrayDouble(double[] ArrayToFill, int BorderLeft, int BorderRight)
{
    int random;
    for (int i = 0; i < ArrayToFill.Length; i++)
    {
        random = new Random().Next(BorderLeft, BorderRight);
        ArrayToFill[i] = new Random().NextDouble() * random;
  
    }
}

void PrintArray(double[] ArrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < ArrayToPrint.Length; i++)
    {
        Console.Write($"{Math.Round(ArrayToPrint[i], 2)}");
        if (i < ArrayToPrint.Length - 1)
        {
            Console.Write("   ");
        }
    }
    Console.WriteLine("]");
}

(double max, double min) DiffMinMax(double[] ArrayToSeek)
{
    var min = ArrayToSeek[0];
    var max = ArrayToSeek[1];

    if (min > max)
    {
        min = ArrayToSeek[1];
        max = ArrayToSeek[0];
    }

    for (int i = 2; i < ArrayToSeek.Length; i++)
    {
        if (min > ArrayToSeek[i])
        {
            min = ArrayToSeek[i];
        }
        if (max < ArrayToSeek[i])
        {
            max = ArrayToSeek[i];
        }
    }

    return (max, min);
}

int ArraySize = new Random().Next(2, 15);
//double[] Array = new double[] { 3, 7, 22, 2, 78}; 
double[] Array = new double[ArraySize];
Console.Clear();

FillArrayDouble(Array, -100, 50);
var (MaxValue, MinValue) = DiffMinMax(Array);
double Result = Math.Round(MaxValue - MinValue, 2);
Console.WriteLine($"Разница между максимальным \"{Math.Round(MaxValue, 2)}\" и минимальным \"{Math.Round(MinValue, 2)}\" элементами массива:");
PrintArray(Array);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Равна = {Result}");
Console.ForegroundColor = ConsoleColor.White;