// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());

int result1 = number / 10000;
int result2 = number % 10;

if(result1 == result2)
{
    result1 = number / 1000 % 10;
    result2= number / 10 % 10;
}
if(result2 == result1)
{
    Console.WriteLine ($"Число {number} является палиндромом");
}
else
{
Console.WriteLine ($"Число {number} не является палиндромом");
}