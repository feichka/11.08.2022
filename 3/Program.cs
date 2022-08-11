/*Задана целочисленная квадратная матрица размером N x N. 
Требуется транспонировать ее относительно главной диагонали.

Первая строка входного файла INPUT.TXT содержит натуральное число N – количество строк и столбцов матрицы. В каждой из последующих N строк записаны N целых чисел – элементы матрицы.
 Все числа во входных данных не превышают 100 по абсолютной величине.
*/
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[n,n];
void PrintArray (int[,]array)
{
for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(($"{array [i, j]} ")); 
        }
        Console.WriteLine();
    }
} 

void FillArray(int[,]array)
{
    {
 for (int i = 0; i < array.GetLength(0); i++)
 {
 for (int j = 0; j < array.GetLength(1); j++)
 {
 array[i,j] = new Random().Next(1,10);
 }
 }
}
}

FillArray(array);
Console.WriteLine();
PrintArray(array);

{
    for (int i = 0; i < array.GetLength(0); i++)
 {
 for (int j = 0; j < array.GetLength(1); j++)

{
    if (i > j-1)
    {
    int x = array[i,j];
    array[i,j] = array[j,i];
    array[j,i] = x;
    }
 }
}
}
Console.WriteLine();
PrintArray(array);