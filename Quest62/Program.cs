// Напишите программу, которая заполнит спирально массив 4 на 4.
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


void FillArray(int[,] array) // спиральное заполнение матрицы....Небеса свидетель это было очень сложно...только с подсказками...
{

    int i = 0;
    int j = 0;
    int count = 1;
    int Istart = 0; int Jstart = 0;
    int Iend = 0; int Jend = 0;

    while (count < rows * columns)
    {
        array[i, j] = count;
        if (i == Istart && j < columns - Jend - 1) 
        {
            j++;
        }
        else if (j == columns - Jend - 1 && i < rows - Iend - 1) 
        {
            i++;
        }
        else if (i == rows - Iend - 1 && j > Jstart)  
        {
            j--;
        }
        else
        {
            i--;
        }

        if ((i == Istart + 1) && (j == Jstart))
        {
            Istart++;
            Iend++;
            Jstart++;
            Jend++;
        }
        count++;
    }
    array[i,j] = count;
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