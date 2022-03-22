/*
Напишите программу, которая задаёт массив из N(-100 100) рандомных элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
*/

int[] Array(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1)
        {
            Console.Write($", ");
        }
    }
}


Console.WriteLine("Введите количество элементов в массиве: ");
int UserNumber = Convert.ToInt32(Console.ReadLine());

int[] UserArray = Array(UserNumber);
ShowArray(UserArray);