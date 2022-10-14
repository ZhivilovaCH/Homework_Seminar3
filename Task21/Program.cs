// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


double Dist (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result;
    result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
    return result;
}

Console.Write("Введите x координаты точки А:");
int ax=int.Parse(Console.ReadLine()!);

Console.Write("Введите y координаты точки А:");
int ay=int.Parse(Console.ReadLine()!);

Console.Write("Введите z координаты точки А:");
int az=int.Parse(Console.ReadLine()!);

Console.Write("Введите x координаты точки B:");
int bx=int.Parse(Console.ReadLine()!);

Console.Write("Введите y координаты точки B:");
int by=int.Parse(Console.ReadLine()!);

Console.Write("Введите z координаты точки B:");
int bz=int.Parse(Console.ReadLine()!);

Console.Write($"Расстояние между точками: {Dist(ax,ay,az,bx,by,bz):f2}");
