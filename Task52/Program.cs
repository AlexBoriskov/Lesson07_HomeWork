// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void NewArray (double [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(new Random().NextDouble()*(10 - 0) + 0, 0);
            Console.Write ($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void Releas (double [,] array)
{   
    for (int j=0; j<array.GetLength(1); j++)
    {
        double Summa = 0;
        for (int i=0; i<array.GetLength(0); i++)
        {
            Summa += array[i,j];
        }
        double Res = Summa / array.GetLength(0);
        Console.WriteLine ("Среднее арифметические в столбе №" + (j+1) + " = " + Res);
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
Console.WriteLine();
Releas(matrix);
