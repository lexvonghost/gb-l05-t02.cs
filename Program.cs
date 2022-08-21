//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите число, определяющее длинну массива");
int length =  Convert.ToInt32(Console.ReadLine());
int[] NewArray(int[] array)
{
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }

    return array;
}
int[] array = new int[length];
array = NewArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");