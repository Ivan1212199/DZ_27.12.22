﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.Write("Введите трёхзначное число: ");
Num_1 = Console.WriteLine(Console.ReadLine());

for (int ii = 1; ii < 3 && (Num_1 <= 100 | Num_1 > 999); ii++)
{
    Console.Write(ii + " Кажется это не трёхзначное число, попробуем ещё раз: ");
    Num_1 = Console.WriteLine(Console.ReadLine());
}
if (Num_1 <= 100 | Num_1 > 999)
{
    Console.WriteLine("Чтото пошло не так, программа прервана: ");
break;
}

Num_1 = Num_1 / 10 % 10;
Console.WriteLine($"Вторая цифра введённого числа: {Num_1}");
break;