// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 

Console.Write("Введите колличество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < m; i++)
{
    Console.Write($"Введите число {i + 1}: "); 
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 0)
    count++;
}
Console.WriteLine($"Количество чисел больше нуля: {count}");

