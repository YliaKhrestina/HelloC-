// два числа, ищем меньшее, к нему прибавляем разницу между большим и меньшим, столько раз, чему равняется меньшее

int a = 0, b = 0, result = 0;

if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b) && a != b)
{
    if (a < b)
    {
        result = a + b * (b-a);
        Console.WriteLine(result);
    }
    else
    {
        result = b + b * (a - b);
        Console.WriteLine(result);
    }
}
else
{
    Console.WriteLine("OOps");
}