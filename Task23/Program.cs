// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27.
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.Write("Insert a number N: ");
int N = Convert.ToInt32(Console.ReadLine());
int num = 0;
int count = 1;

while (count < N)
{
    num = Convert.ToInt32(Math.Pow(count,3));
    count++;
    Console.Write($"{num}, ");
}
N = Convert.ToInt32(Math.Pow(N,3));
Console.Write(N);