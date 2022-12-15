/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16*/

System.Console.Write("Введите число A: ");
int num = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите число B: ");
int level = int.Parse(Console.ReadLine()!);
int exponentiation(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return result;
}
System.Console.WriteLine($"Результат: {exponentiation(num, level)}");