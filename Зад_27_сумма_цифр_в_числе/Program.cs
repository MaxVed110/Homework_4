/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
*/

int SumNumber(int number)
{
    int sum = 0;
    if (number >= 0)
    {
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
    }
    else
    {
        number *= (-1);
        while (number > 0)
        {
            sum = sum + number % 10;
            number = number / 10;
        }
    }
    return sum;
}

Console.WriteLine("Введите число: ");

int UserNumber = Convert.ToInt32(Console.ReadLine());
int sum = SumNumber(UserNumber);

Console.WriteLine($"Сумма цифр в числе {UserNumber} = {sum}");