/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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

//Сортировка элементов пузырком
void SortArray(int[,] array)
{
    int temporaryValue = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {


        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i,k] < array[i,k+1])
                {
                    temporaryValue = array[i,k];
                    array[i,k] = array[i,k+1];
                    array[i,k+1] = temporaryValue;
                }
            }

        }
    }
}


int rows = GetNumber("Введите количество строк");
int columns = GetNumber("Введите количество столбцов");
int leftBound = GetNumber("Введите левую границу значений");
int rightBound = GetNumber("Введите правую границу значений");

int[,] matrix = InitArray(rows, columns, leftBound, rightBound);
PrintArray(matrix);
SortArray(matrix);
PrintArray(matrix);
