// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите цифру: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = (number - number%10)/10 - (number/100)*10;
Console.WriteLine($"Вторая цифра в числе {number} является {secondDigit}");