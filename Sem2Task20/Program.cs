// Задача №20 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

void PrintData(string msg, double val)
{
    Console.WriteLine(msg + val);
}

double CalcLen(int x1, int x2, int y1, int y2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
}

int x1 = ReadData("Введите координату Х точки А: ");
int x2 = ReadData("Введите координату Х точки А: ");
int y1 = ReadData("Введите координату Х точки B: ");
int y2 = ReadData("Введите координату Х точки B: ");

double res = CalcLen(x1, x2, y1, y2);

PrintData("Расстояние между точками А и В: ", res);