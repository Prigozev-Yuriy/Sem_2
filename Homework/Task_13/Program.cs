// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. До 10 символов
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите число до 10 символов: ");
string? number = Console.ReadLine();
if (number.Length > 10)
{
    Console.WriteLine("Ведено слишком большое число!");
}
else
{
    if (number.Length < 3)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
        Console.WriteLine($"Третья цифра в числе {number} является {number.ToString()[2]} ");
}