/*адача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1
 строка*/

void RandomArrey(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArrey(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void SummElement(int[,] arr)
{
    int minNam = 0;
    int minSummNam = 0;
    int summNam = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        minNam += arr[0, i];
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) summNam += arr[i, j];
        if (summNam < minNam)
        {
            minNam = summNam;
            minSummNam= i;
        }
        summNam = 0;
    }
    Console.Write($"{minSummNam + 1} строка");
}
int[,] arrey = new int[4, 4];
RandomArrey(arrey);
PrintArrey(arrey);
SummElement(arrey);
