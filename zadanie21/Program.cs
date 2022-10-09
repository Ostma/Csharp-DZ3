// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadData (string line)
{
Console.WriteLine(line);
int number = int.Parse(Console.ReadLine()??"");
return number;
}

void PrintData (string prefix, string value)
{
    Console.WriteLine(prefix+value);
}

double FindLen(int x1, int y1, int z1, int x2, int y2, int z2)
// double res = 0;
// {
//     res = ;
// }
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2));
}


int x1 = ReadData("Введите координату x точки 1 :");
int y1 = ReadData("Введите координату y точки 1 :");
int z1 = ReadData("Введите координату z точки 1 :");
int x2 = ReadData("Введите координату x точки 2 :");
int y2 = ReadData("Введите координату y точки 2 :");
int z2 = ReadData("Введите координату z точки 2 :");

double res = FindLen(x1, y1, z1, x2, y2, z2);
PrintData("Расстояние между точками:", res.ToString());