// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа. 
//456 -> 6 
//782 -> 2 
//918 -> 8

int a = 0;
int b = 0;
System.Console.WriteLine("Введите трехзначное число: ");
a = int.Parse(Console.ReadLine());
if (a>=100 && a<1000)
{
    b = a % 10;
    System.Console.Write("Последней цифрой этого числа является ");
    System.Console.WriteLine(b);

}
else
{
    System.Console.WriteLine("Число некорректное!");
}