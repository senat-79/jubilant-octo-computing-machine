/*Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

int[] arr = GetRandomArray (10);
PrintArray(arr);

int a = 0;
double[] randomArray = new double[a];

void mas(int a)
{
Random rand = new Random();
for (int i = 0; i < a; i++)
{
   randomArray[i] = rand.NextDouble();
   Console.Write($"{randomArray[i]:F2}");
}
}

double raz(double[] randomArrya)
{
    double min = randomArray[0];
    double max = randomArray[0];
    int i = 1;
    while (i < randomArray.Length)
{
    if (max<randomArray[i])
    max = randomArray[i];
    if (min>randomArray[i])
    min = randomArray[i];
    i = i + 1;
}
return max-min;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
       Console.WriteLine(item + ""); 
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