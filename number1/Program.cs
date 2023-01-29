﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int numberA = ReadInt("Введите первое число --> ");
int numberB = ReadInt("Введите второе число --> ");
ToDegree(numberA,numberB);

void ToDegree(int a,int b)
{
    int result = 1;
    for(int i=1; i<=b; i++)
    {
        result=result * a;
    }
    System.Console.WriteLine(result);
}
int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} 