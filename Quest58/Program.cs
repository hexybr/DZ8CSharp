// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите количество строк первой матрицы:");
int rows;
if (!int.TryParse(Console.ReadLine()!, out rows))
{
    Console.WriteLine("Неверный ввод");
    return;
}
Console.WriteLine("Введите количество столбцов первой матрицы:");
int columns;
if (!int.TryParse(Console.ReadLine()!, out columns))
{
    Console.WriteLine("Неверный ввод");
    return;
}
Console.WriteLine("Введите количество строк второй матрицы:");
int rows2;
if (!int.TryParse(Console.ReadLine()!, out rows2))
{
    Console.WriteLine("Неверный ввод");
    return;
}
Console.WriteLine("Введите количество столбцов второй матрицы:");
int columns2;
if (!int.TryParse(Console.ReadLine()!, out columns2))
{
    Console.WriteLine("Неверный ввод");
    return;
}
if (columns != rows2)
{
    Console.WriteLine("Число столбцов первой матрицы не совпадает с числом строк второй");
    return;
}
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows2, columns2];

FillArray(array);
FillArray2(secondArray);
PrintArray(array);
PrintArray2(secondArray);
ProductOfMatrices(array, secondArray);

void FillArray(int[,] array)
{

    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i, k] = rnd.Next(0, 11);
        }
    }
}
void FillArray2(int[,] secondArray)
{

    Random rnd = new Random();
    for (int i = 0; i < secondArray.GetLength(0); i++)
    {
        for (int k = 0; k < secondArray.GetLength(1); k++)
        {
            secondArray[i, k] = rnd.Next(0, 11);
        }
    }
}
void PrintArray(int[,] input)
{
    Console.WriteLine("Первая матрица: ");
    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int k = 0; k < input.GetLength(1); k++)
        {
            Console.Write(String.Format("{0,5}", input[i, k]));
        }
        Console.WriteLine();
    }
}
void PrintArray2(int[,] input2)
{
    Console.WriteLine("Вторая матрица: ");
    for (int i = 0; i < input2.GetLength(0); i++)
    {
        for (int k = 0; k < input2.GetLength(1); k++)
        {
            Console.Write(String.Format("{0,5}", input2[i, k]));
        }
        Console.WriteLine();
    }
}
void ProductOfMatrices(int[,] array, int[,] secondArray)  // Произведение матриц
{
    int[,] array3 = new int[rows, columns2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                array3[i, j] += array[i, k] * secondArray[k, j];
            }
        }
    }
    
    Console.WriteLine("Результат умножения: ");
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int k = 0; k < array3.GetLength(1); k++)
        {
            Console.Write(String.Format("{0,5}", array3[i, k]));
        }
        Console.WriteLine();
    }
}