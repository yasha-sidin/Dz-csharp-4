// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSumDigits(int number)
{
    string allDigits = number.ToString();
    int sum = 0;
    for (int i = 0; i < allDigits.Length; i++)
    {
        int toSum = number % 10;
        sum = sum + toSum;
    }

    return sum;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма чисел равна: {GetSumDigits(number)}");