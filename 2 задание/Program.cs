
/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int GetNumber(string message)

{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

//метод для инициализации массива рандомными числами
int[,] InitArray(int rows, int columns, int leftBound, int rightBound)
{
    int[,] result = new int[rows,columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {

            {
                result[i, j] = rnd.Next(leftBound, rightBound);
            }
          
        }
    return result;
}

// метод печати массива
void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {


            {
                Console.Write($"{array[i,j]} ");
            }
        }
            Console.WriteLine();
    }
    Console.WriteLine(); 

}

//Нахождение строки с минимальной суммой элементов
int FindMinRow(int[,] array)
{
    int minRow = 0;
    int summMin = 0;
    int summNewMin = 0;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summNewMin += array[i, j];
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summMin += array[i, j];
        }
        Console.WriteLine($"Сумма элементов {i+1} строки - {summMin}");
        if (summMin < summNewMin)
        {
            minRow = i;
            summNewMin = summMin;
        }
        summMin = 0;
    }
    return minRow;
}


int rows = GetNumber("Введите количество строк");
int columns = GetNumber("Введите количество столбцов");
int leftBound = GetNumber("Введите левую границу значений");
int rightBound = GetNumber("Введите правую границу значений");

int[,] matrix = InitArray(rows, columns, leftBound, rightBound);
PrintArray(matrix);
int minRow = FindMinRow(matrix);
Console.WriteLine($"Строка с минимальной суммой элементов - {minRow+1}");
