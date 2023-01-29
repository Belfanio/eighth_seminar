
/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:*/

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

//произведение двух матриц
int[,] FindMultiplicationArray(int[,] firstArray, int[,] secondArray)
{
    //[1,1]x[1,1]+[1,2]x[2,1]+[1,3]x[3,1]
    //[1,1]x[2,1]+[1,2]x[2,2]+[1,3]x[2,3]
    //[1,1]x[3,1]+[1,2]x[3,2]+[1,3]x[3,3]
    int[,] multiplicationArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];

    for (int i = 0; i < multiplicationArray.GetLength(0); i++)
    {
        for (int j = 0; j < multiplicationArray.GetLength(1); j++)
        {
           for (int k = 0; k < firstArray.GetLength(1); k++)
           {
            multiplicationArray[i,j] += firstArray[i,k]*secondArray[k,j];
           }
        }
        
    }
    return multiplicationArray;
     
}


int rowsFirstMatrix = GetNumber("Введите количество строк в первой матрице");
int columnsFirstMatrix = GetNumber("Введите количество столбцов в первой матрице и строк во второй матрицах");
int rowsSecondMatrix = columnsFirstMatrix;
int columnsSecondMatrix = GetNumber("Введите количество столбов во второй матрице");
int leftBound = GetNumber("Введите левую границу значений");
int rightBound = GetNumber("Введите правую границу значений");

int[,] firstMatrix = InitArray(rowsFirstMatrix, columnsFirstMatrix, leftBound, rightBound);
Console.WriteLine("Первая матрица");
PrintArray(firstMatrix);
int[,] secondMatrix = InitArray(rowsSecondMatrix, columnsSecondMatrix, leftBound, rightBound);
Console.WriteLine("Вторая матрица");
PrintArray(secondMatrix);
int[,] multiplicationMatrix = FindMultiplicationArray(firstMatrix, secondMatrix);
Console.WriteLine("Произведение двух матриц");
PrintArray(multiplicationMatrix);

