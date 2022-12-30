// Напишите программу, которая на вход принимает число, 
// и возвращает индексы числа в двумерном массиве или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillNewArr (int[,] NewArr)

{
for (int i = 0; i < NewArr.GetLength(0); i++)
{
    for (int j = 0; j < NewArr.GetLength(1); j++)
    {
        NewArr[i, j] = new Random().Next(1, 10);
    }
}
return NewArr;
}
void PrintNewArr (int[,] NewArr)
{
for (int i = 0; i < NewArr.GetLength(0); i++)
 {
     for (int j = 0; j < NewArr.GetLength(1); j++)
     {
       Console.Write(NewArr[i, j] + " ");
     }
     Console.WriteLine();
 }
}

int[,] NewArr = new int[3,4];
NewArr = FillNewArr(NewArr);
PrintNewArr(NewArr);

Console.Write("\n введите число -> ");
int number = int.Parse(Console.ReadLine());

Console.Write("\n"); 
bool numberInArr = false; 

for (int i = 0; i < NewArr.GetLength(0); i++)
{
    for (int j = 0; j < NewArr.GetLength(1); j++)
    {
         if (NewArr[i,j] == number) 
        { 
            numberInArr = true;
            Console.WriteLine($"[{Convert.ToInt32(i)},{Convert.ToInt32(j)}]"); 
        } 
    } 
} 
if (numberInArr) 
    {} 
else 
    { 
        Console.Write($"такого числа нет"); 
    }
