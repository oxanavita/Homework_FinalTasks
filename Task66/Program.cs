// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int GetSumRec(int n, int m)
{
    if (m == n)  return m;
    return m + GetSumRec(n, m-1);
}

Console.Clear();
Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());     
Console.WriteLine(GetSumRec(m, n));