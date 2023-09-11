/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих 
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] arr = GetRandomArray (10);
PrintArray(arr);
Console.WriteLine(SumElements(arr));

int SumElements(int[] array)
{
    int sum = 0;
    int i = 0;
    while (i < array.Length)
    {
       sum = sum + array[i];
       i = i + 2;
    }
    return sum;
} 


void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
       Console.Write(item + ""); 
    }
}

int[] GetRandomArray(int length)
{
    int [] result = new int [length];
    for (int i = 0; i < length; i++)
    {
        result [i] = new Random().Next (0, 99);
    }
    return result;
}
