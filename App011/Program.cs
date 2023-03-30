// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

int N = GetInt();

int GetInt()
{
    System.Console.WriteLine("Введите целое число: ");
    int N = int.Parse(Console.ReadLine());
    return N;
}

string SquareNumber(int N)
{
    string result = "";
    for (int n = 1; n <= N; n++)
    {
        result += Math.Pow(n, 2)+" ";
    }
    return result;
}

System.Console.WriteLine(SquareNumber(N));
