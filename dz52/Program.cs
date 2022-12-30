// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



void FillArray (int[, ]matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray (int[, ]matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int [, ] matrix = new int [4, 6];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

for (int i = 0; i < matrix.GetLength(1); i++)
{
    int average = 0;

    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        average = average + matrix [j,i];
    }
    Console.WriteLine($" Среднее арифметическое элементов {i+1} столбца = {((float)average / matrix.GetLength(0))}");
}