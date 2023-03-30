// ((x2-x1)^2+(y2-y1)^2)^(1/2)
//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

int Read(string coordinate)
{
    System.Console.WriteLine($"Введите координаты двух точек {coordinate}:");
    int x = int.Parse(Console.ReadLine());
    return x;
}

int x1 = Read("x1");
int y1 = Read("y1");
int x2 = Read("x2");
int y2 = Read("y2");

double Lenght (int x1, int y1, int x2, int y2)

{
   return Math.Round(Math.Sqrt (Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2)),3); 
}

System.Console.WriteLine($"Расстояние между двумя точками - {Lenght(x1, y1, x2, y2)}");