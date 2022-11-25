
/*
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());               //Целочисленная переменная для хранения количества строк m
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());               //Целочисленная переменная для хранения количества столбцов n
Random random = new Random();                              //экземпляр класса Random для генерации случайных вещественных чисел
int[,] arr = new int[m, n];                                // объявление вещественного двумерного массива
                                                        //цикл для заполнения массива случайными вещественными числами
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = random.Next(0, 1000);               //генерация элементов 
        Console.Write($"{arr[i, j]} \t");               //вывод
    }
    Console.WriteLine();
}
                                                        //цикл по элементам
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < n - 1; k++)
        {
            if (arr[i, k] < arr[i, k + 1])
            {
                int temp = arr[i, k + 1];
                arr[i, k + 1] = arr[i, k];
                arr[i, k] = temp;
            }
        }
    }
}
Console.WriteLine("Упорядоченный массив");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{arr[i, j]} \t");                    //вывод
    }
    Console.WriteLine();
}
*/

/*
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());           //Целочисленная переменная для хранения количества строк m
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());           //Целочисленная переменная для хранения количества столбцов n
Random random = new Random();                          //экземпляр класса Random для генерации случайных вещественных чисел
int[,] arr = new int[m, n];                            // объявление вещественного двумерного массива
                                                       //цикл для заполнения массива случайными вещественными числами
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = random.Next(0, 1000);              //генерация элементов 
        Console.Write($"{arr[i, j]} \t");               //вывод
    }
    Console.WriteLine();
}
int MinRowSum = int.MaxValue, indexMinRow = 0;          //переменнная для хранения индекса строки с минимальной суммой

for (int i = 0; i < m; i++)
{
    int rowSum = 0;
    for (int j = 0; j < n; j++)
        rowSum += arr[i, j];

    if (rowSum < MinRowSum)
    {
        MinRowSum = rowSum;
        indexMinRow = i;
    }
}
                                                         //вывод результата
Console.WriteLine("Строка с минимальной суммой элементов");
for (int j = 0; j < n; j++)
    Console.Write(arr[indexMinRow, j] + "\t");
*/


/*
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


Console.WriteLine("Введите количество строк первой матрицы");
int m = Convert.ToInt32(Console.ReadLine());                  //Целочисленная переменная для хранения количества строк m
Console.WriteLine("Введите количество столбцов первой матрицы");
int n = Convert.ToInt32(Console.ReadLine());                  //Целочисленная переменная для хранения количества столбцов n
Console.WriteLine("Введите количество строк второй матрицы");
int m2 = Convert.ToInt32(Console.ReadLine());                  //Целочисленная переменная для хранения количества строк m2
Console.WriteLine("Введите количество столбцов второй матрицы");
int n2 = Convert.ToInt32(Console.ReadLine());                  //Целочисленная переменная для хранения количества столбцов n2

Random random = new Random();                                  //экземпляр класса Random для генерации случайных вещественных чисел
int[,] arr = new int[m, n];                                    // объявление вещественного двумерного массива
int[,] arr2 = new int[m, n];                                   // объявление вещественного двумерного массива

                                                          //цикл для заполнения массива случайными вещественными числами
Console.WriteLine("Первая матрица");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = random.Next(0, 1000);                 //генерация элементов
        Console.Write($"{arr[i, j]} \t");                //вывод
    }
    Console.WriteLine();
}
Console.WriteLine("Вторая матрица");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr2[i, j] = random.Next(0, 1000);        //генерация элементов
        Console.Write($"{arr2[i, j]} \t");        //вывод
    }
    Console.WriteLine();
}
var arr3 = new int[m, n2];                       //массив для хранения результата
                                                 //перемножение матриц
if (n == m2)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n2; j++)
        {
            arr3[i, j] = 0;
            for (int k = 0; k < n2; k++)
            {
                arr3[i, j] += arr[i, k] * arr2[k, j];
            }
        }
    }
}
                                                    //вывод результата
Console.WriteLine("Произведение матриц");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n2; j++)
    {
        Console.Write($"{arr3[i, j]} \t");           //вывод
    }
    Console.WriteLine();
}
*/

/*
//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2

Console.WriteLine("Введите x");
int m = Convert.ToInt32(Console.ReadLine());        //Целочисленная переменная для хранения количества строк m
Console.WriteLine("Введите y");
int n = Convert.ToInt32(Console.ReadLine());       //Целочисленная переменная для хранения количества столбцов n
Console.WriteLine("Введите z");
int k = Convert.ToInt32(Console.ReadLine());     //Целочисленная переменная для хранения количества столбцов n
int [,,] arr = new int[m,n,k];                  //объявление основного массива
int[] temp = new int[m * n * k];                //объявление одномерного массива для заплнения 
for (int i = 0; i < temp.GetLength(0); i++)
{
    temp[i] = new Random().Next(10, 100);
    int number = temp[i];
    if (i >= 1)
    {
        for (int j = 0; j < i; j++)
        {
            while (temp[i] == temp[j])
            {
                temp[i] = new Random().Next(10, 100);
                j = 0;
                number = temp[i];
            }
            number = temp[i];
        }
    }
}
int count = 0;
for (int x = 0; x < m; x++)
{
    for (int y = 0; y < n; y++)
    {
        for (int z = 0; z < k; z++)
        {
            arr[x, y, z] = temp[count];
            count++;
        }
    }
}
                                            //вывод массива
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int z = 0; z < k; z++)
        {
            Console.Write($"{arr[i, j, z]} ({i},{j},{z}) ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
*/


/*
//Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.

int N = 4, M = 4;                     //размер массива
int[,] A = new int[N, M];             //объявление массива

int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = M;    //объявление необходимых переменных
                                      // цикл по элементам массива для заполнения по спирали
for (int i = 0; i < A.Length; i++)
{
    A[col, row] = i + 1;
    if (--gran == 0)
    {
        gran = M * (dirChanges % 2) + N * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
        int temp = dx;
        dx = -dy;
        dy = temp;
        dirChanges++;
    }
    col += dx;
    row += dy;
}
                                      //вывод массива
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}
*/