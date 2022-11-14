// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int Prompt(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintMultiArray(int[,] array)
{
    for (int  i= 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] CreateMasiv(int line, int col)
{
    int[,] createarray = new int [line,col];
    for  (int  i= 0; i < createarray.GetLength(0); i++)
    {
        for (int  j= 0; j < createarray.GetLength(1); j++)
        {
            createarray[i,j] = new Random().Next(1, 10);
        }
    }
    return createarray;
}

int SumElement(int[,] arr, int str)
{
    int sum = 0;
    for (int  j= 0; j < arr.GetLength(1); j++)
    {
        sum = sum + arr[str, j];
    }
    return sum;
}

int FindMinSum(int[,] arr)
{
    int minsum = SumElement(arr, 0);
    int minstr = 0;
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        if (SumElement(arr, i) < minsum)
        {
            minsum = SumElement(arr , i);
            minstr = i;
        }
    }
    return minstr;
}

int stroki = Prompt("Введите число строк: ");
int stolb = Prompt("Введите число столбцов: ");
int[,] array = CreateMasiv(stroki, stolb);
System.Console.WriteLine("Случайные числа: ");
PrintMultiArray(array);
System.Console.WriteLine($"Строка с наименьше суммой: {FindMinSum(array)}");