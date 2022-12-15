/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

void arrayZ(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(0, 99);
    }
}
void printArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]} ");
    }
}
int[] array = new int[8];
arrayZ(array);
printArray(array);