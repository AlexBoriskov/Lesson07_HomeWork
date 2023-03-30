// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void NewArray (double [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(new Random().NextDouble()*(100 - 0) + 0, 1);
            Console.Write ($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write ("Введите размер массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

while (size[0]< 0 || size[1]<0)
{
    Console.WriteLine ("Индекс массива не может быть меньше 0!!!");
    Console.WriteLine ("Повтори попытку!");
    Console.Write ("Введите размер массива: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}

double [,] matrix = new double [size[0], size[1]];
NewArray(matrix);

