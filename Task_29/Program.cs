// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void FillIntArray(int[] array, int startRange, int endRange)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(startRange, endRange);
    }
}

void PrintIntArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1)
        {
            Console.Write($"{array[i]}]");
            break;
        }
        Console.Write($"{array[i]}, ");
    }
}

Console.Write("Напишите, какое количество элементов вы хотите увидеть в массиве: ");
int countElements = int.Parse(Console.ReadLine());

int[] arrayInt = new int[countElements];

Console.Write("Напишите начало диапозона чисел, которые нобходимо добавить в массив: ");
int startRange = int.Parse(Console.ReadLine());
Console.Write("Напишите конец диапозона чисел, которые нобходимо добавить в массив: ");
int endRange = int.Parse(Console.ReadLine());

FillIntArray(arrayInt, startRange, endRange);
PrintIntArray(arrayInt);