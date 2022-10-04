//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер
// строки с наименьшей суммой элементов: 1 строка

int rows = 3;
int columns = 4;

int[,] Numbers(int m, int n)
{
    var result = new int[m, n]; 
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}
void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Summer(int[,] array)
{
    int Summ = 0;
    int SummMin = 0;
    int minRows = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        SummMin += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Summ += array[i, j];
            if (Summ < SummMin)
            {
                SummMin = Summ;
                minRows = i;
            }
        }
         
    }
    Console.WriteLine(minRows+1);
}

int[,] arr = Numbers(rows, columns);
PrintArray(arr);
Console.WriteLine();
Summer(arr);

