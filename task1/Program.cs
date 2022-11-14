// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

int Prompt(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintMultiArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] CreateMasiv(int line, int col)
{
    int[,] createarray = new int[line, col];
    for (int i = 0; i < createarray.GetLength(0); i++)
    {
        for (int j = 0; j < createarray.GetLength(1); j++)
        {
            createarray[i, j] = new Random().Next(1, 10);
        }
    }
    return createarray;
}

int[,] SortirArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int index = 0; index < array.GetLength(1); index++)
        {
            int max = array[i, index];
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < max)
                {
                    max = array[i, j];
                    array[i, j] = array[i, index];
                    array[i, index] = max;
                }
            }
        }
    }
    return array;
}

int stroki = Prompt("Введите число строк: ");
int stolb = Prompt("Введите число столбцов: ");
int[,] array = CreateMasiv(stroki, stolb);
System.Console.WriteLine("Случайные числа: ");
PrintMultiArray(array);
int[,] sortirovka = SortirArray(array);
System.Console.WriteLine("Массив с упорядочеными элементами строки: ");
PrintMultiArray(sortirovka);