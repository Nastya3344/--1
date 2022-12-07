Console.WriteLine("Введите первое число 1: ");
int N = Convert.ToInt32(Console.ReadLine());
int Ost = N%2;

if (Ost == 0 )
{
    Console.WriteLine("Число N является четное");
}
else
{
    Console.WriteLine("Число N является нечетное");
}
