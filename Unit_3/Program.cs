// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cub(int N)
{
int number = 0;
for (int i = 1; i <= N; i++)
{
    int sum = number + i;
    int sum1 = sum * sum * sum;
    Console.Write(sum1);
    if (i<N)
    {
    Console.Write(", ");
    }
}
}

Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
Cub(N);
