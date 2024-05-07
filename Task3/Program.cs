/*
Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
*/

int[] array = {5, 4, 3, 2, 1};
System.Console.Write("Элементы массива начиная с конца: ");
PrintArrayReversed (array, array.Length - 1);

void PrintArrayReversed (int[] array, int index)
{
    if (index >= 0)
    {
        System.Console.Write(array[index] + " ");
        PrintArrayReversed (array, index -1);
    }
}

