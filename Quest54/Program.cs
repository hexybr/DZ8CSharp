// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);
SortAndPrint(array);

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

void SortAndPrint(int[,] array)   // Сортировка пузырьком 
{
    int[,] sorting = array;

    for (int i = 0; i < sorting.GetLength(0); i++) // Сортировка СТРОК
    {
        for (int j = 0; j < sorting.GetLength(1); j++) // Сортировка пузырьком
        {
            for (int k = 0; k < sorting.GetLength(1); k++)
            {
                if (sorting[i, j] >= sorting[i, k])
                {
                    int shift = sorting[i, j];
                    sorting[i, j] = sorting[i, k];
                    sorting[i, k] = shift;
                }
            }
        }
    }

    Console.WriteLine("Отсортированный массив:");
    for (int i = 0; i < sorting.GetLength(0); i++)
    {
        for (int k = 0; k < sorting.GetLength(1); k++)
        {
            Console.Write(String.Format("{0,5}", sorting[i, k]));
        }
        Console.WriteLine();
    }
}
