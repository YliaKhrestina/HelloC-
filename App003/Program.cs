// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

int a = 0;

if (int.TryParse(Console.ReadLine(), out a) && a >= 1 && a <= 7)
{
    if (a == 1)
    {
        Console.Write("понедельник");
    }
    else if (a == 2)
    {
        Console.Write("вторник");
    }
    else if (a == 3)
    {
        Console.Write("среда");
    }
    else if (a == 4)
    {
        Console.Write("четверг");
    }
    else if (a == 5)
    {
        Console.Write("пятница");
    }
    else if (a == 6)
    {
        Console.Write("суббота");
    }
    else if (a == 7)
    {
        Console.Write("воскресенье");
    }
}
else
{
    Console.Write("OOps");
}