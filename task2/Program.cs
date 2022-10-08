//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Write("Введите число ");
int a = int.Parse(Console.ReadLine());
int b = 0;
if (a < 100)
{
    Console.Write("Нет третьей цифры");
}
else if (a > 99)
{
    while (a > 999)
    {
        a = a/10;
    }
    b = a%10;
    Console.WriteLine(b);

}
