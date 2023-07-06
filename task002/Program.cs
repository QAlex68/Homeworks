// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7->max = 7
// a = 2 b = 10->max = 10
// a = -9 b = -3->max = -3

Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
//int sqr = number2 * number2;

if (number1 > number2) Console.WriteLine($"Число {number1} больше числа " + number2 + " !");

if (number1 < number2) Console.WriteLine($"Число {number2}  больше числа " + number1 + " !");

if (number1 == number2) Console.WriteLine($"Число {number1}  равно числу  " + number2 + " !");