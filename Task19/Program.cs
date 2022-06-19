// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();

Console.WriteLine("Insert number:");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = 0;
int copy = num;

if (num < 10000 || num > 99999)
{
    Console.WriteLine("Error!!!");
}

else
{
    while (copy > 0)
    {
        num2 = num2 * 10 + copy % 10;
        copy = copy / 10;
    }
    if (num == num2)
    {
        Console.WriteLine("Polindrom");
    }
    else
    {
        Console.WriteLine("Not polindrom");
    }
}