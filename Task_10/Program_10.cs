﻿// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число");
int ThreeDigitNumber = Convert.ToInt32(Console.ReadLine());

void ShowSecondDigit(int number)
    {
       Console.WriteLine ("Вторая цифра числа " + (number % 100 / 10));
    }

ShowSecondDigit(ThreeDigitNumber);
