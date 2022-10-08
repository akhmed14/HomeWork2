//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.Write("Введите трехзначное число ");
int num = int.Parse(Console.ReadLine());
if (num > 99 & num < 1000)
{
    int a = num/10%10;
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("ошибка!!");
}
