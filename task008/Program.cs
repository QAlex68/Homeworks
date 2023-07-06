// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine());
n = Math.Abs(n);
if (n % 2 != 0) n--;

if (n <= 1) Console.WriteLine("Четные числа числа в в указанном промежутке: 0");
else
{
    Console.WriteLine($"Четные числа числа в промежутке от -{n} до {n}: ", n);

    for (int i = -n; i < n; i = i + 2)
    {
        Console.Write(i + ", ");
    }

    Console.Write(n);
}