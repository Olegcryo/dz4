//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

System.Console.Write("Введите число -> ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int number)
{
    int advance = 0;
    int result = 0;

    while (number > 0)
    {
        advance = number % 10;
        result = result + (advance);
        number = number / 10;
    }
    return result;
}
int sumNumber = SumNumber(number);
System.Console.WriteLine("Сумма цифр в числе: " + sumNumber);