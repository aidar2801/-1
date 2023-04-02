// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int secondRank = number / 10 % 10;
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Число не трехзначное");
    return;
}
else
{
Console.WriteLine($"Вторая цифра {secondRank}");
}
