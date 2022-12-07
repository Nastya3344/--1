Console.WriteLine("Введите первое число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("Число 1 является max");
}
else
{
    Console.WriteLine("Число 2 является max");
}