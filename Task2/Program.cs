/*
Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
*/

System.Console.Write("Введите неотрицательное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите неотрицательное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = AckermannFunction (M, N);
System.Console.WriteLine($"Значение функции Аккермана для ({M}, {N}) равно {result}");
int AckermannFunction (int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0)
    {
        return AckermannFunction (M - 1, 1);
    }
    else
    {
        return AckermannFunction (M - 1, AckermannFunction (M, N - 1));
    }
}
