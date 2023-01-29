
/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/


//метод для инициализации массива 
int[,,] InitArray(int rows, int columns, int depth)
{
    int[,,] result = new int[rows, columns, depth];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {

                result[i, j, k] = rnd.Next(10, 100);

            }
        }
    }
    return result;
}

// метод печати массива
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {

                Console.Write($"{array[i, j, k]} [{i},{j},{k}] ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();

}

int rows = 2;
int columns = 2;
int depth = 2;

int[,,] matrix = InitArray(rows, columns, depth);
Console.WriteLine("Элементы матрицы и их позиция");
PrintArray(matrix);

