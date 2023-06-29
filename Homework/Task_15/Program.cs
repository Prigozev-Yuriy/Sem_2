Console.Write("Введите цифру: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7)
{
    Console.WriteLine("Вы ввели число, не соответсвующее дню недели");
}
else
{
    if (number == 6 ^ number == 7)
    {
        Console.WriteLine($"Этот день является выходным днем!");
    }
    else
        Console.WriteLine("Этот день является рабочим днем!");
}