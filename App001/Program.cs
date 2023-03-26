// Программа, которвя на вход принимает число и выдает его квадрат.

int i = 0;

if (int.TryParse(Console.ReadLine(), out i))
{
    Console.WriteLine(i * i);
}
else
{
    Console.WriteLine("OOps");
}