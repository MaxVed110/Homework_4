/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
натуральную степень B.
3, 5 -> 243 (3⁵)
*/

double NumberPow(double[] array)
{
   double result = Math.Pow(array[0], array[1]);
   return result;
}

Console.WriteLine("Введите 2 числа через пробел: ");

double[] TwoNumber = Console.ReadLine()!.Split(' ').Select(x => Convert.ToDouble(x)).ToArray();

double resultPow =  NumberPow(TwoNumber);

Console.WriteLine($"Число {TwoNumber[0]} в степени {TwoNumber[1]}  = {resultPow}");