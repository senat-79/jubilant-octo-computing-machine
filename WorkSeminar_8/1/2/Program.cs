/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
 которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка */

var matrix = GetMatrix();
PrintMatrix(matrix);
System.Console.WriteLine(" ");
SumLine(matrix);

int SumLine(int[,] matrix)
{
    int i = 0;
    int sum = matrix[i,0];
    for(int l= 1; l < matrix.GetLength(1); l++)
    {
        sum += matrix[i,l]; 
    }
    return sum;
}

/*int minSum = 1;
int sum = SumLine(matrix, 0);
for(int i = 1; i <matrix.GetLength(0); i++)
{
    if(sum > SumLine(matrix, i))
    {
        sum = SumLine(matrix, i);
        minSum = i + 1;
    }
}
*/
int[,] GetMatrix(int rows = 5, int columns = 5)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i,l] = rand.Next(1, 9);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write($"{matrix[i, l]} ");
        }
      Console.WriteLine();  
    }
}