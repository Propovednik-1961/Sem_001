// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
int numbers = num1 + 2;

if(numbers < numberN)
{
    Console.WriteLine($"Четные числа {numbers}");
}
else
{
    Console.WriteLine(numberN);
    num1 = num1 + 1;
}
