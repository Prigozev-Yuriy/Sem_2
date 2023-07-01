// Назовём число «интересным» если его произведение цифр делится на их сумму БЕЗ остатка. Напишите программу, 
//которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000(999 - последнее). 
//(каждый эл-т массива – сгенерирован случайно)
// Пример для 1 элемента массива: 591, сумма: 5+9+1 = 15; произведение: 5*9*1 = 45; 45 / 15 - делится НАЦЕЛО, 
//число "интересное"
// [591, 532, 189, 523, 333, 546, 527, 275, 456, 264]
int[] array = new int[10];
Random rnd = new Random();
for (int i = 0; i < array.Length;)
{
    int number = rnd.Next(10, 1000);
    int sumNumber = number % 10 + ((number - number % 10) / 10 - (number / 100) * 10) + number / 100;
    int prodOfNumber = (number % 10) * ((number - number % 10) / 10 - (number / 100) * 10) * (number / 100);
    if (prodOfNumber % sumNumber == 0 && prodOfNumber != 0)
    {
        array[i] = number;
        i++;
    }
}
Console.WriteLine(string.Join(", ", array));