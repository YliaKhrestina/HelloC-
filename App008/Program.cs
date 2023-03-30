//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int Read()

{
    System.Console.WriteLine($"Введите номер четверти:");
    int num = int.Parse(Console.ReadLine());
    return num;
}
System.Console.WriteLine(QouteNumb(Read()));

String QouteNumb( int num)
{
    if (num == 1) return ("x>0; y>0"); 
    else if (num == 2) return ("x<0; y>0");   
    else if (num == 3) return ("x<0; y<0");
    else return ("x>0; y<0"); 
}