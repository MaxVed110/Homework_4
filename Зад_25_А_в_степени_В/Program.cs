/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
натуральную степень B.
3, 5 -> 243 (3⁵)
*/

double NumberPow(int numberA, int numberB)
{
   double result = Math.Pow(numberA, numberB);
   return result;
}

Console.WriteLine("Введите 2 числа: ");

int FirstNumber = Convert.ToInt32(Console.ReadLine());
int TwoNumber = Convert.ToInt32(Console.ReadLine());

double resultPow =  NumberPow(FirstNumber, TwoNumber);

Console.WriteLine($"Число {FirstNumber} в степени {TwoNumber}  = {resultPow}");