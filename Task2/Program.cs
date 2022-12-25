 // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите любое число: ");
int num = int.Parse(Console.ReadLine());
int numDigit = NumberDigit(num);

if (numDigit <= 2)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    if (numDigit > 3)
    {
        num = num / int.Parse(Math.Pow(10, numDigit - 3));
    }
    num = num % 10;
    Console.WriteLine($"Третья цифра введённого числа: {num}");
}