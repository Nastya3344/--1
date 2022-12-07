Console.WriteLine("Введите первое число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    if(number1 > number3)
    {
        Console.WriteLine("Число 1 является max");
    }
    else
    {
    Console.WriteLine("Число 3 является max");
    }
}
else
{
    if(number2 > number3)
    {
        Console.WriteLine("Число 2 является max");
    }
     else
     {
        Console.WriteLine("Число 3 является max");
     }   
}