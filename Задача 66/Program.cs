﻿//(Задача 66)//

Console.Write("Введите число M = ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N = ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от M до N = {SumNumbers(M, N)}");
 
static int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;
    else if (N == 0) return (M * (M + 1)) / 2;
    else if (M == N) return M;
    else if (M < N) return N + SumNumbers(M, N - 1);
    else return N + SumNumbers(M, N + 1);
}