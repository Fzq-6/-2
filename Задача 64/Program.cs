//(Задача 64)//

Console.Write($"введиме число N-> ");
int Num = int.Parse(Console.ReadLine()!);
CalculationNum(Num);

void CalculationNum(int N)
{
    Console.Write($"{N} ");
    if(N > 1)
    CalculationNum(N - 1);
}