// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void NewArray (int [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-100, 101);
            Console.Write ($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void  Releas (int [,] array, int A, int B)
{
    if (A<= array.GetLength(0) && B<=array.GetLength(1))
    {
        Console.WriteLine ("Элемент равен: " + array [A,B]);
    }
    else
    {
        Console.WriteLine ("Такого элемента нет в массиве!");
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

Console.Write ("Введите позицию для поиска в массиве: ");
int[] position  = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int a = position [0];
int b = position [1];
int [,] matrix = new int [size[0], size[1]];
NewArray(matrix);
Console WriteLine();
Releas(matrix, a, b);