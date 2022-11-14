// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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

bool ArrayControl(int[,] first, int[,] sec)
{
    if(first.GetLength(0) == sec.GetLength(1))
    {
        return true;
    }
    return false;
}

int[,] ProizvedMatrix(int[,] first , int[,] sec)
{
    int max = 0;
    if (first.GetLength(0) > sec.GetLength(1))
    {
        max = first.GetLength(0);
    }
    else
    {
        max = sec.GetLength(1);
    }
    int[,] array = new int[first.GetLength(0), sec.GetLength(1)];
    for (int i = 0; i < first.GetLength(0); i++)
    {
        for (int n = 0; n < max; n++)
        {
            int sum = 0;
            for (int j = 0; j < first.GetLength(0); j++)
            {
                sum = sum + first[i,j] * sec[j,n];
                array[i,n] = sum;
            }
        }
    }
    return array;
}

System.Console.WriteLine("Первая матрица ");
int stroki = Prompt("Введите число строк: ");
int stolb = Prompt("Введите число столбцов: ");
int[,] firstarray = CreateMasiv(stroki, stolb);
System.Console.WriteLine("Случайные числа: ");
PrintMultiArray(firstarray);
System.Console.WriteLine("Вторая матрица ");
int secstroki = Prompt("Введите число строк: ");
int secstolb = Prompt("Введите число столбцов: ");
int[,] secarray = CreateMasiv(secstroki, secstolb);
PrintMultiArray(secarray);
System.Console.WriteLine();
System.Console.WriteLine("Произведение двух матриц: ");
PrintMultiArray(ProizvedMatrix(firstarray, secarray));