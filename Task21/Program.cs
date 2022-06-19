// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Введите координаты x1");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y1");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты z1");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты x2");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y2");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты z2");
double z2 = Convert.ToInt32(Console.ReadLine());

double lineX = x1 - x2;
double lineY = y1 - y2;
double lineZ = z1 - z2;

double sum = Math.Sqrt((lineX*lineX) + (lineY * lineY) + (lineZ * lineZ));

Console.WriteLine($"Расстояние между точками = {sum}");
