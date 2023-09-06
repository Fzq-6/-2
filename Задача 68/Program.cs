//(Задача 68)//

Console.Write($"введиме число n-> ");
int num = int.Parse(Console.ReadLine()!);
Console.Write($"введиме число m-> ");
int mum = int.Parse(Console.ReadLine()!);
int result = AkkermanFunction(num, mum);
Console.WriteLine(result);

int AkkermanFunction(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if (m == 0)
        return AkkermanFunction(n - 1, 1);
    else
        return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
}