/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int GetSumNums (int number)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    Console.WriteLine(sum);
    return number;
}
Console.WriteLine($"Сумма чисел = {GetSumNums(num)}");




