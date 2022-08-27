// ДОП ЗАДАЧКА:
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

using System;
class myclass
{
    static void Main()
    {
        int number;
        Console.Write("Введите число: ");
        number = Convert.ToInt32(Console.ReadLine());
        int count;
        string result = " ";
        while (number >= 1)
        {
            count = number / 2;
            result += (number % 2).ToString();
            number = count;
        }
        string binary = " ";
        for (int i = result.Length - 1; i >= 0; i--)
        {
            binary = binary + result[i];
        }
        Console.WriteLine("Бинарный формат для заданного числа {0}", binary);
    }
}