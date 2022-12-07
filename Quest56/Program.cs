//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Введите количество строк:");
int rows;
if (!int.TryParse(Console.ReadLine()!, out rows))
{
    Console.WriteLine("Неверный ввод");
    return;
}
Console.WriteLine("Введите количество столбцов:");
int columns;
if (!int.TryParse(Console.ReadLine()!, out columns))
{
    Console.WriteLine("Неверный ввод");
    return;
}

if (rows == columns)
{
    Console.WriteLine("Задан не прямоугольный массив");
    return;
}

int[,] array = new int[rows, columns];
int[] secondArray = new int[rows];
FillArray(array);
PrintArray(array);
FillsecondArray(secondArray);
SmallestSum(secondArray);
void FillArray(int[,] array)
{

    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i, k] = rnd.Next(-100, 101);
        }
    }
}
void PrintArray(int[,] input)
{
    Console.WriteLine("Полученный массив: ");
    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int k = 0; k < input.GetLength(1); k++)
        {
            Console.Write(String.Format("{0,5}", input[i, k]));
        }
        Console.WriteLine();
    }
}
void FillsecondArray(int[] secondArray)
{
    for (int k = 0; k < secondArray.Length;)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
            secondArray[k] = sum;
            k++;
        }
    }
}
void SmallestSum(int[] secondArray)
{
    int minSum = secondArray[0];
    int indmin = 0;
    for (int i = 0; i < secondArray.Length; i++)
    {
        if (secondArray[i] < minSum)
        {
            minSum = secondArray[i];
            indmin = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов:{indmin + 1} строка");
}