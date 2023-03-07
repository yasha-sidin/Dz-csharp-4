// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int number, int numberIn)
{
    int exp = 1;
    for (int i = 0; i < numberIn; i++)
    {
        exp = exp * number;
    }

    return exp;
}

Console.Write("Введите число, которое хотите возвести в степень: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Введите число степени: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine($"Число {firstNumber} в степени {secondNumber} равно {Exponentiation(firstNumber, secondNumber)}");
