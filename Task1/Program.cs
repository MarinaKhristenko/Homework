/*
Задача 1: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
*/

System.Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

void PrintNaturalNumbers (int M, int N)
{
    if (M > N)
    {
        return;
    }
    if (M % 2 == 0)
    {
        System.Console.WriteLine($"{M}");
    }
    
    PrintNaturalNumbers (M + 1, N);
}
PrintNaturalNumbers (M, N);