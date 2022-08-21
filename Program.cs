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
int Sum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < length; i = i + 2)
    {
        if (i < length)
        sum = sum + array[i];
    }
    return sum;
}
Console.WriteLine("суммa элементов, стоящих на нечётных позициях:" + Sum(array));
