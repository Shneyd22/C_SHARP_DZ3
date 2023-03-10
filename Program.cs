Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
double i = num % 2;
if (i == 0)
{
    Console.WriteLine ("Это число - четное");
}
else
{
    Console.WriteLine ("Это число - нечетное");
}