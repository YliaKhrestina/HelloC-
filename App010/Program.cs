// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

Number();

int Read()
{
    Console.WriteLine("введите число:");
    int N = int.Parse(Console.ReadLine());
    return N;
}

void Number()
{
    int n = 1;
    int N = Read();
    while (n <= N)
    {
        double d = Math.Pow(n, 2);
        Console.Write(d+" ");
        n++;
    }
   }
