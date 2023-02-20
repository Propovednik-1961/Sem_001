Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int diji = number % 2;
if(diji == 0)
{
    Console.WriteLine("Четное " );
}
else
{
    Console.WriteLine($"Нечетное,остаток{diji}");
}
